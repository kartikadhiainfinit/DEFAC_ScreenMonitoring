using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;

namespace Tieto.MonitorClient
{
    /// <summary>
    /// creats VNC viewer Process
    /// </summary>
    public class StartVNCViewer 
    {
        private const string _fileName = "vncviewer";
        private Process _procVNCViewer;
        private string _hostName;
        private string _portNumber;
        private string _userName;
        private VNCServer _vncServer;

        public StartVNCViewer(string userName)
        {
            this._userName = userName;
            Initialize();
            RunVNCviewer();
        }

        /// <summary>
        /// gets host name and port number where VNC server is running
        /// </summary>
        public VNCServer VNCServer
        {
            get { return _vncServer; }
        }

        /// <summary>
        /// gets System.Diagntostics.Process of veiwer
        /// </summary>
        public Process VNCViewer
        {
            get { return _procVNCViewer; }
        }

        /// <summary>
        /// Initialize Logger
        /// </summary>
        private void Initialize()
        {
            // Einstellungen initialisieren
            //Settings.Initialize();

            // Assembly ermitteln
            Assembly assembly = Assembly.GetAssembly(this.GetType());
            // Protokoll initialisieren
            Logger.Initialize(itCampus.bb.Common.Tools.GetFileName(assembly), true,
                "INFO");
        }

        public void Dispose()
        {
            Logger.Log.Info("Screen Monitor terminating ...");
            // Protokoll freigeben
            Logger.Terminate();
        }

        /// <summary>
        /// starts VNC viewer
        /// </summary>
        private void RunVNCviewer()
        {
            
            _vncServer = SQLServerDAO.GetVNCServerParameter(_userName);
            _hostName = _vncServer.HostName;
            _portNumber = _vncServer.PortNumber.ToString();

            //creating parameters for viewer
            StringBuilder parameter = new StringBuilder();
            parameter.Append(ConfigurationManager.AppSettings.Get("VncViewer"));
            parameter.AppendFormat(" {0}:{1}",  _hostName, _portNumber.ToString());
   
            _procVNCViewer = new Process();
            _procVNCViewer.EnableRaisingEvents = false;
            _procVNCViewer.StartInfo.FileName = _fileName;
            _procVNCViewer.StartInfo.Arguments = parameter.ToString();
            _procVNCViewer.EnableRaisingEvents = true;

            if (_procVNCViewer.Start())
            {
                Logger.Log.Info("Screen monitoring started on agent: " + _userName);
                _procVNCViewer.WaitForExit();
            }
            else
            {
                Logger.Log.Error("VNC viewer could not be started");
            }
        }
    }
}
