using System;
using System.Collections.Generic;
using System.Text;

namespace Tieto.MonitorClient
{
    public class VNCServer
    {
        private string _hostname;
        private int _portNumber;

        public VNCServer(string hostName, int portNumber)
        {
            this._hostname = hostName;
            this._portNumber = portNumber;
        }

        public string HostName
        {
            get { return _hostname; }
        }

        public int PortNumber
        {
            get { return _portNumber; }
        }
    }
}
