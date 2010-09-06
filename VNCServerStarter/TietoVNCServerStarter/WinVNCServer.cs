using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Configuration;
using Microsoft.Win32;

namespace TietoVNCServerStarter
{
    /// <summary>
    /// Class used to start VNC Server
    /// </summary>
    public class WinVNCServer
    {
        private static readonly string _fileName = ConfigurationManager.AppSettings.Get("VNCFileName");
        private static readonly string _arguments = ConfigurationManager.AppSettings.Get("VNCArguments");

        private IPProperties _ipproperties;
        private int _portNumber;
        private string _hostName;
        private int _procId;
        private int _sessId;
        private string _userSID;

        // writing TCP port number to registry
        private RegistryKey _rkeyHKCU = Registry.CurrentUser;
        private RegistryKey _rkeyWinVNC4;

        //private EditVNCIniFile _editIniFile;
        private Process _winVNCexe;
        private StringBuilder _message;

        public WinVNCServer(string userSID)
        {
            this._userSID = userSID;
            // Einstellungen initialisieren
            Initialize();
        }

        #region Properties
        /// <summary>
        /// Gets the port number of VNC server
        /// </summary>
        public int PortNumber
        {
            get { return _portNumber; }
        }

        /// <summary>
        /// Gets Host name
        /// </summary>
        public string HostName
        {
            get { return _hostName; }
        }

        /// <summary>
        /// Gets process ID
        /// </summary>
        public int ProcId
        {
            get { return _procId; }
        }

        /// <summary>
        /// Gets Terminal Server seesion ID
        /// </summary>
        public int SessionId
        {
            get { return _sessId; }
        }
        #endregion Properties

        /// <summary>
        ///Getting host name, TCP port number
        /// </summary>
        private void Initialize()
        {
            // here we findout which tcp port number to use
            _ipproperties = new IPProperties();
            _portNumber = _ipproperties.TCPPortNumber;
            _hostName = _ipproperties.HostName;

            // first check if VNC is runnnig, then kill it
            CheckVNCServerRunning();

            // now start VNC
            WinVNCRun();

        }

        /// <summary>
        /// Check if VNC server is already running on the machine
        /// If process with same name found, then it will be killed
        /// </summary>
        private void CheckVNCServerRunning()
        {
            Logger.Log.Info("Check if VNC is running");
            // get start up parameter from db for userSID
            SQLServerDAO startParamDAO = new SQLServerDAO();

            VNCStartParameter vncStartParameterFromDB = startParamDAO.GetVNCStartParameterForUserSID(_userSID);

            Process localProcess = null;

            try
            {
                localProcess = Process.GetProcessById(vncStartParameterFromDB.ProcessID);
            }
            catch (Exception e)
            {
                Logger.Log.Info(e.Message);
            }

            // if the process with same name, exist on the same host, then kill the process
            if (null != localProcess &&
                localProcess.ProcessName.Equals(_fileName) &&
                vncStartParameterFromDB.HostName.Equals(_hostName))
            {
                try
                {
                    Logger.Log.Info("VNC Process exist and will be terminated");
                    Logger.Log.Info("Killing Process ID: " + localProcess.Id.ToString());
                    localProcess.Kill();
                }
                catch (Exception e)
                {
                    Logger.Log.Fatal("Process ID: " + localProcess.Id.ToString() + ", could not be killed");
                    Logger.Log.Fatal(e.Message);
                }
            }
        }

        /// <summary>
        /// Starts winvnc.exe process
        /// </summary>
        public void WinVNCRun()
        {
            SetRegistryPortNumber();

            _winVNCexe = new Process();
            _winVNCexe.EnableRaisingEvents = false;
            _winVNCexe.StartInfo.CreateNoWindow = true;
            _winVNCexe.StartInfo.FileName = _fileName;
            _winVNCexe.StartInfo.Arguments = _arguments;
            _winVNCexe.StartInfo.UseShellExecute = false;
            _winVNCexe.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;


            //now starting vnc server in user mode
            if (_winVNCexe.Start())
            {
                //Logging some informations
                _message = new StringBuilder();
                _message.AppendFormat("VNC Server started on host: {0}, portnumber: {1}", _hostName, _portNumber.ToString());
                _message.AppendFormat(" VNC Process started, process  ID: {0}", _procId.ToString());
                Logger.Log.Info(_message.ToString());
                _procId = _winVNCexe.Id;
                _sessId = _winVNCexe.SessionId;
            }
            else
            {
                string message = "Start VNC failed";
                throw new Exception(message);
            }



        }

        /// <summary>
        /// Set TCP port number in registry 
        /// </summary>
        /// <returns></returns>
        private bool SetRegistryPortNumber()
        {
            try
            {
                _rkeyWinVNC4 = _rkeyHKCU.OpenSubKey(@"Software\RealVNC\WinVNC4", true);
            }
            catch (Exception e)
            {
                Logger.Log.Fatal("Unable to open the WinVNC4 subkey!");
                Logger.Log.Fatal(e.Message);
                _rkeyHKCU.Close();
                return false;
            }

            try
            {
                // create a value with name same as the data...
                _rkeyWinVNC4.SetValue("PortNumber", _portNumber.ToString());
                Logger.Log.Info("Entry successfully created in the registry!");
                return true;
            }
            catch (Exception e)
            {
                // error while creating entry...
                Logger.Log.Fatal("Unable to create an entry for the application!");
                Logger.Log.Fatal(e.Message);
                return false;
            }

        }

        /// <summary>
        /// Terminates VNC server process
        /// </summary>
        public void Kill()
        {
            _message = new StringBuilder();
            _message.AppendFormat("VNC process will be killed, process ID: {0}", _winVNCexe.Id.ToString());
            Logger.Log.Info(_message.ToString());
            _winVNCexe.Kill();
        }
    }
}
