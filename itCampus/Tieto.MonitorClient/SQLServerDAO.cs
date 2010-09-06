using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Tieto.MonitorClient
{
    public static class SQLServerDAO
    {
        private const string tietoConnectionStringName = "deFacto";
        private const string itCampusConnectionStringName = "itCampus";


        public static string GetExchangeMailBox(string AgentCode)
        {
            string exchangeMailBox = null;
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT EXCHANGE_MAILBOX FROM USERS");
            sql.Append("    WHERE ID = " + Db.Escape(AgentCode));
            //exchangeMailBox = Db.GetScalar(sql.ToString(), itCampusConnectionStringName).ToString();
            return exchangeMailBox;
        }

        public static VNCServer GetVNCServerParameter(string AgentCode)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT host_name, port_number ");
            sql.Append("   FROM vnc_startparameter");
            sql.Append("  WHERE user_name = " + Db.Escape(AgentCode));

            DataRow row = Db.GetDataRow(sql.ToString());

            string hostName = row["host_name"].ToString();
            int portNumber = (int) row["port_number"];

            return new VNCServer( hostName, portNumber);

        }
    }
}
