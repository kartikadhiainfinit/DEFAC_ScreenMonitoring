using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TietoVNCServerStarter
{
    /// <summary>
    /// Sql Server specific data access object that handles data access
    /// of customers.
    /// </summary>
    class SQLServerDAO
    {
        public void InsertStartParameter(VNCStartParameter startParam)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" INSERT INTO vnc_startparameter (user_name, user_SID, email, host_name, port_number, process_id, session_id, time_stamp) ");
            sql.Append("    VALUES( " + Db.Escape(startParam.UserName) + ", ");
            sql.Append("            " + Db.Escape(startParam.UserSID) + ", ");
            sql.Append("            " + Db.Escape(startParam.EMail) + ", ");
            sql.Append("            " + Db.Escape(startParam.HostName) + ", ");
            sql.Append("            " + startParam.PortNumber + ", ");
            sql.Append("            " + startParam.ProcessID + ", ");
            sql.Append("            " + startParam.SessionID + ", ");
            sql.Append("            " + "GetDate())" );

            try
            {
                Db.Insert(sql.ToString());
            }
            catch (Exception e)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Inserting into data base is not successful");
                message.AppendLine(e.Message);
                Logger.Log.Error(message.ToString());
            }

        }

        /// <summary>
        /// Updates a VNC start parameter for user.
        /// </summary>
        /// <param name="customer">Customer.</param>
        /// <returns>Number of customer records updated.</returns>
        public void UpdateStartParameter(VNCStartParameter startParam)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" UPDATE vnc_startparameter ");
            sql.Append("    SET user_name = " + Db.Escape(startParam.UserName) + ", ");
            sql.Append("        email = " + Db.Escape(startParam.EMail) + ", ");
            sql.Append("        host_name = " + Db.Escape(startParam.HostName) + ", ");
            sql.Append("        port_number = " + startParam.PortNumber + ", ");
            sql.Append("        process_id = " + startParam.ProcessID + ", ");
            sql.Append("        session_id = " + startParam.SessionID + ", ");
            sql.Append("        time_stamp = GetDate()");
            sql.Append(" WHERE user_SID = " + Db.Escape(startParam.UserSID));

            try
            {
                Db.Update(sql.ToString());
            }
            catch (Exception e)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Updating data base is not successful");
                message.AppendLine(e.Message);
                Logger.Log.Error(message.ToString());
            }
        }

        /// <summary>
        /// Deletes a user start parameter
        /// </summary>
        /// <param name="customer">user SID.</param>
        /// <returns>Number of customer records deleted.</returns>
        public int DeleteStartParameter(string userID)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append(" DELETE FROM vnc_startparameter  ");
            sql.Append("  WHERE user_SID = " + Db.Escape(userID));

            return Db.Update(sql.ToString());
        }

        /// <summary>
        /// Checks if SID exist in Data  Base
        /// </summary>
        /// <param name="user_SID"></param>
        /// <returns>true if SID exist in data base</returns>
        public bool UserSIDExistInDB(string user_SID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT user_SID");
            sql.Append("   FROM vnc_startparameter");
            sql.Append("  WHERE user_SID = " + Db.Escape(user_SID));

            DataRow row = Db.GetDataRow(sql.ToString());

            if (null == row)
            {
                return false;
            }

            string DBUser_SID = row["user_SID"].ToString();

            if (user_SID.Equals(DBUser_SID))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public VNCStartParameter GetVNCStartParameterForUserSID(string userSID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append("   FROM vnc_startparameter");
            sql.Append("  WHERE user_SID = " + Db.Escape(userSID));

            DataRow row = Db.GetDataRow(sql.ToString());
            string userName = row["user_name"].ToString();
            string hostName = row["host_name"].ToString();
            int portNumber =  (int)row["port_number"];
            int processID = (int)row["process_id"];
            int sessionID = (int)row["session_id"];

            VNCStartParameter vncStartParameter = new VNCStartParameter();
            vncStartParameter.HostName = hostName;
            vncStartParameter.PortNumber = portNumber;
            vncStartParameter.ProcessID = processID;
            vncStartParameter.SessionID = sessionID;
            return vncStartParameter;
        }
    }
}
