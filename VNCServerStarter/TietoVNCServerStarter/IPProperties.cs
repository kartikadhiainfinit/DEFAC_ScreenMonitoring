using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Configuration;

namespace TietoVNCServerStarter
{
    /// <summary>
    /// static class, VNC Server host name and port number
    /// </summary>
    internal class IPProperties
    {
        IPGlobalProperties _ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
        private string _hostname ;
        private string _startPortNumer = ConfigurationManager.AppSettings.Get("VNCPortNumber");
        private int _portNumber;

        public IPProperties()
        {
            Initialize();
        }


        public string HostName
        {
            get { return _hostname; }
        }

        public int TCPPortNumber
        {
            get { return _portNumber; }
        }

        private void Initialize()
        {
            _hostname = _ipGlobalProperties.HostName;
            _startPortNumer = ConfigurationManager.AppSettings.Get("VNCPortNumber");
            _portNumber = CheckIfPortNumberIsFree(int.Parse(_startPortNumer));
        }

        /// <summary>
        /// this methode search for all TCP ports on local machine
        /// It checks for active TCP connections and active listeners
        /// </summary>
        private  bool TCPPortIsFree(int port)
        {

            /*************************************************************
             * check in all active connections if tcp port is being used *
            *************************************************************/
            TcpConnectionInformation[] tcpConnInfoArray = _ipGlobalProperties.GetActiveTcpConnections();
            foreach (TcpConnectionInformation tcpInfo in tcpConnInfoArray)
            {
                if (tcpInfo.LocalEndPoint.Port == port)
                {
                    return false;
                }
            }

            /****************************************************
             * check active listeners if the port is being used *
            *****************************************************/
            IPEndPoint[] IPEndPointArray = _ipGlobalProperties.GetActiveTcpListeners();
            foreach (IPEndPoint tcpEndPoint in IPEndPointArray)
            {
                if (tcpEndPoint.Port == port)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// this method finds free port number
        /// </summary>
        /// <returns>port for VNC Server</returns>
        public  int CheckIfPortNumberIsFree(int port)
        {
            //find free tcp port
            while (!TCPPortIsFree(port))
            {
                port++;

            }
            return port;
        }

        /// <summary>
        /// returns local Host name
        /// </summary>
        /// <returns>local hostname</returns>
        public  String GeHostName()
        {
            String hostName = _ipGlobalProperties.HostName;
            return hostName;
        }
    }
}
