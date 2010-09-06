using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TietoVNCServerStarter
{
    /// <summary>
    /// VNC start parameter Informations container
    /// </summary>
    public struct VNCStartParameter
    {
        private int _port;
        private string _hostname;
        private string _username;
        private string _userSID;
        private int _procId;
        private int _sessId;
        private string _email;

        /// <summary>
        /// Gets port number
        /// </summary>
        public int PortNumber
        {
            get { return _port; }
            set { _port = value; }
        }

        /// <summary>
        /// Gets Host name
        /// </summary>
        public string HostName
        {
            get { return _hostname; }
            set { _hostname = value; }
        }

        /// <summary>
        /// Gets user name
        /// </summary>
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        /// <summary>
        /// Gets user's SID
        /// </summary>
        public string UserSID
        {
            get { return _userSID; }
            set { _userSID = value; }
        }

        /// <summary>
        /// Gets VNC Server Process ID
        /// </summary>
        public int ProcessID
        {
            get { return _procId; }
            set { _procId = value; }
        }

        public int SessionID
        {
            get { return _sessId; }
            set { _sessId = value; }
        }

        public string EMail
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
