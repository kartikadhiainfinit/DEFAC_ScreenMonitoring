using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Security;

namespace TietoVNCServerStarter
{
    internal  class PortNumber
    {
        private static int _port = 4917;
        private List<int> _localPorts = new List<int>();

        private  void GetAllPortsNumbers()
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();

             TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            IPEndPoint[] IPEndPointArray = ipGlobalProperties.GetActiveTcpListeners();

            foreach (TcpConnectionInformation tcpInfo in tcpConnInfoArray)
            {
               _localPorts.Add( tcpInfo.LocalEndPoint.Port);
            }

            foreach (IPEndPoint tcpi in IPEndPointArray)
            {
                if (!_localPorts.Contains(tcpi.Port))
                {
                    _localPorts.Add(tcpi.Port);
                }
            }

        }

        public  int SetVNCPortNumber()
        {
            GetAllPortsNumbers();

            //TO DO: check if the port is not used,  see in the port list
            //while ()
            //{
            //}   
            //if port number is free let's try to start socket on that port
            //TcpListener newsock = null;
            //try
            //{
            //    newsock = new TcpListener(_port);
            //    newsock.Start();
            //}
            //catch (SecurityException e)
            //{
            //    _port++;
            //    loopSearch();
            //}

            //if (null != newsock)
            //{
            //    newsock.Stop();
            //}

            return _port;
        }

        private static void loopSearch()
        {
            
            //SetVNCPortNumber();
        }

    }
}
