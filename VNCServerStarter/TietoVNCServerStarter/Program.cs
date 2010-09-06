using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;

namespace TietoVNCServerStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder();

            // check connection string if it is encrypted
            Db.ProtectConnectionString();

            Logger.Log.Info("Start collecting user data");
            //collecting user informations
            UserData userData = new UserData();
            
            try
            {
                // starting vnc server
                WinVNCServer winVNCServer = new WinVNCServer(userData.UserSID);

                try
                {
                    //creating container for VNC start parameter
                    VNCStartParameter startParam = new VNCStartParameter();
                    startParam.EMail = userData.EMail;
                    startParam.UserName = userData.UserName;
                    startParam.UserSID = userData.UserSID;
                    startParam.HostName = winVNCServer.HostName;
                    startParam.PortNumber = winVNCServer.PortNumber;
                    startParam.ProcessID = winVNCServer.ProcId;
                    startParam.SessionID = winVNCServer.SessionId;

                    Logger.Log.Info("Start writing vnc start parameter to data base");
                    //writing to DB
                    PersistStartParameter persistStartParameter = new PersistStartParameter(startParam);
                }
                catch (Exception e)
                {
                    message.AppendLine("VNC Start parameter could not be saved to data base. ");
                    message.Append(e.Message);
                    Logger.Log.Error(message.ToString());

                    //cleaning, becouse data could not be saved, vnc server will be killed
                    winVNCServer.Kill();
                }
            }
            catch (Exception e)
            {
                message.AppendLine("VNC Server could not be started. ");
                message.Append(e.Message);
                Logger.Log.Error(message.ToString());
            }
        }
    }
}
