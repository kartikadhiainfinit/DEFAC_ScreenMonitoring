using System;
using System.Collections.Generic;
using System.Text;

namespace Tieto.MonitorClient
{
    /// <summary>
    /// Contains information about VNC Server
    /// </summary>
    public struct VNCServer
    {
        private string _hostname;
        private int _portNumber;

        public VNCServer(string hostName, int portNumber)
        {
            this._hostname = hostName;
            this._portNumber = portNumber;
        }

        /// <summary>
        /// Gets host name where the VNC server runs
        /// </summary>
        public string HostName
        {
            get { return _hostname; }
        }

        /// <summary>
        /// Gets TCP port number of VNC server
        /// </summary>
        public int PortNumber
        {
            get { return _portNumber; }
        }
    }
}
