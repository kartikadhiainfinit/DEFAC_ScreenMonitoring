﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace Tieto.MonitorClient
{
    public static class Db
    {
        //private const string tietoConnectionStringName = "deFacto";
        //private const string itCampusConnectionStringName = "itCampus";

        //TODO: remove multi connections strings, we don't need it
      
        private static readonly string _dataProvider = ConfigurationManager.AppSettings.Get("DataProvider");
        private static readonly DbProviderFactory _factory = DbProviderFactories.GetFactory(_dataProvider);
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings[_dataProvider].ConnectionString;
   
        #region OverLoads
        /// <summary>
        /// returns scalar value
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="connectionStringName"></param>
        /// <returns></returns>
        //public static object GetScalar(string sql, string connectionStringName)
        //{
        //    object retValue = null;
        //    switch (connectionStringName)
        //    {
        //        case tietoConnectionStringName:
        //            _dataProvider = ConfigurationManager.ConnectionStrings[tietoConnectionStringName].ProviderName;
        //            _factory = DbProviderFactories.GetFactory(_dataProvider);
        //            _connectionString = ConfigurationManager.ConnectionStrings[_dataProvider].ConnectionString;
        //            retValue = GetScalar(sql);
        //            _dataProvider = null;
        //            _factory = null;
        //            _connectionString = null;
        //            break;
        //        case itCampusConnectionStringName:
        //            _dataProvider = ConfigurationManager.ConnectionStrings[itCampusConnectionStringName].ProviderName;
        //            _factory = DbProviderFactories.GetFactory(_dataProvider);
        //            _connectionString = ConfigurationManager.ConnectionStrings[itCampusConnectionStringName].ConnectionString;
        //            retValue = GetScalar(sql);
        //            _dataProvider = null;
        //            _factory = null;
        //            _connectionString = null;
        //            break;
        //    }

        //    return retValue;
        //}
        #endregion OverLoads

        #region Data Update handlers

        /// <summary>
        /// Executes Update statements in the database.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Number of rows affected.</returns>
        public static int Update(string sql)
        {
            using (DbConnection connection = _factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;

                using (DbCommand command = _factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Executes Insert statements in the database. 
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        public static void Insert(string sql)
        {
            using (DbConnection connection = _factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;

                using (DbCommand command = _factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion


        #region Data Retrieve Handlers

        /// <summary>
        /// Populates a DataSet according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataSet.</returns>
        public static DataSet GetDataSet(string sql)
        {
            using (DbConnection connection = _factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;

                using (DbCommand command = _factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;

                    using (DbDataAdapter adapter = _factory.CreateDataAdapter())
                    {
                        adapter.SelectCommand = command;

                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        return ds;
                    }
                }
            }
        }

        /// <summary>
        /// Populates a DataTable according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataTable.</returns>
        public static DataTable GetDataTable(string sql)
        {
            return GetDataSet(sql).Tables[0];
        }

        /// <summary>
        /// Populates a DataRow according to a Sql statement.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Populated DataRow.</returns>
        public static DataRow GetDataRow(string sql)
        {
            DataRow row = null;

            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[0];
            }

            return row;
        }

        /// <summary>
        /// Executes a Sql statement and returns a scalar value.
        /// </summary>
        /// <param name="sql">Sql statement.</param>
        /// <returns>Scalar value.</returns>
        public static object GetScalar(string sql)
        {
            using (DbConnection connection = _factory.CreateConnection())
            {
                connection.ConnectionString = _connectionString;

                using (DbCommand command = _factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        #endregion

        #region Utility methods

        /// <summary>
        /// Escapes an input string for database processing, that is, 
        /// surround it with quotes and change any quote in the string to 
        /// two adjacent quotes (i.e. escape it). 
        /// If input string is null or empty a NULL string is returned.
        /// </summary>
        /// <param name="s">Input string.</param>
        /// <returns>Escaped output string.</returns>
        public static string Escape(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "NULL";
            else
                return "'" + s.Trim().Replace("'", "''") + "'";
        }

        /// <summary>
        /// Escapes an input string for database processing, that is, 
        /// surround it with quotes and change any quote in the string to 
        /// two adjacent quotes (i.e. escape it). 
        /// Also trims string at a given maximum length.
        /// If input string is null or empty a NULL string is returned.
        /// </summary>
        /// <param name="s">Input string.</param>
        /// <param name="maxLength">Maximum length of output string.</param>
        /// <returns>Escaped output string.</returns>
        public static string Escape(string s, int maxLength)
        {
            if (String.IsNullOrEmpty(s))
                return "NULL";
            else
            {
                s = s.Trim();
                if (s.Length > maxLength) s = s.Substring(0, maxLength - 1);
                return "'" + s.Trim().Replace("'", "''") + "'";
            }
        }

        #endregion
    }
}
