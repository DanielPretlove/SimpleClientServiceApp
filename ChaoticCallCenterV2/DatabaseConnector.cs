using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; 

namespace ChaoticCallCenterV2
{
    class DatabaseConnector
    {
        const string CONNECTION_STRING = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ChaoticCallCenter.accdb";

        static OleDbConnection DBCONN = new OleDbConnection(CONNECTION_STRING);

        /// <summary>
        /// Executes given query 
        /// </summary>
        /// <parm name="query">Query to be executed</parm>
        /// <returns>Rows affected</returns>
        public static int ExecuteNonQuery(string query)
        {
            if (DBCONN.State != System.Data.ConnectionState.Open) DBCONN.Open();

            OleDbCommand dbCmd = new OleDbCommand(query, DBCONN);
            int results = dbCmd.ExecuteNonQuery();
            DBCONN.Close();
            return results;
        }
       

        /// <summary>
        /// Prepares a data reader for iterating through a result set - does not close DB connection
        /// </summary>
        /// <param name="query">Query to send to database</param>
        /// <returns>Prepared reader</returns>
        public static OleDbDataReader GetReader(string query)
        {
            if (DBCONN.State != System.Data.ConnectionState.Open) DBCONN.Open();

            OleDbCommand dbCmd = new OleDbCommand(query, DBCONN);
            OleDbDataReader reader = dbCmd.ExecuteReader();

            return reader;
        }

        public static void InsertEntity(string query)
        {
            if (DBCONN.State != System.Data.ConnectionState.Open) DBCONN.Open();

            OleDbCommand dbCmd = new OleDbCommand(query, DBCONN);
            int results = dbCmd.ExecuteNonQuery();
           // OleDbCommand identityCmd = new OleDbCommand("SELECT @@IDENTITY", DBCONN);
            //entity.ID = (int)identityCmd.ExecuteScalar();
            DBCONN.Close();
        }

        /// <summary>
        /// Helper method to close connection to the database
        /// </summary>
        public static void Disconnect()
        {
            if (DBCONN.State == System.Data.ConnectionState.Open) DBCONN.Close();
        }

    }
}