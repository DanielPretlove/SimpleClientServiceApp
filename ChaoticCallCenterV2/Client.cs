using ChaoticCallCenterV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ChaoticCallCenterV2
{
    class Client
    {
        #region properties 
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }
        public string Gender { get; set; }
        public bool Happy { get; set; }
        public bool Archive { get; set; }
        public string Company { get; set; }
        public DateTime BirthDate { get; set; }




        #endregion properties

        #region Client 
        public Client()
        {
            ID = 0;
            FirstName = "";
            LastName = "";
            Comment = "";
            Gender = "";
            Happy = false;
            Archive = false; 
            BirthDate = DateTime.Now;
            Company = "Telstra";
        }


        public Client(OleDbDataReader reader)
        {
            ID = (int)reader["ClientID"];
            FirstName = (string)reader["FirstName"];
            LastName = (string)reader["LastName"];
            Gender = (string)reader["Gender"];
            Comment = (string)reader["Comment"];
            Archive = (bool)reader["Archive"];
            Happy = (bool)reader["Happy"];
            Company = (string)reader["Company"];
            BirthDate = (DateTime)reader["Birthdate"]; 
             
        }
        #endregion Client 

        #region Events 
        /// <summary>
        /// it connect to the database for it to go to the first record in the database 
        /// </summary>
        /// <returns></returns>
        public static Client GetFirst()
        {
            var reader = DatabaseConnector.GetReader("SELECT TOP 1 * FROM tblChaoticCallCenter");
            reader.Read();
            var client = new Client(reader);
            DatabaseConnector.Disconnect(); // always a good idea to disconnect the database when we're done
            return client;
        }
        /// <summary>
        /// it connect to the database for it to go to the previous record in the database 
        /// </summary>
        /// <param name="reference"></param>
        /// <returns></returns>
        public static Client GetBack(Client reference)
        {
            var reader = DatabaseConnector.GetReader("SELECT TOP 1 * FROM tblChaoticCallCenter WHERE ClientID < " + reference.ID.ToString() + " ORDER BY ClientID DESC");
            reader.Read();
            var client = new Client(reader);
            DatabaseConnector.Disconnect(); // always a good idea to disconnect the database when we're done
            return client;
        }
        /// <summary>
        /// it connect to the database for it to go to the next record in the database 
        /// </summary>
        /// <param name="reference"></param>
        /// <returns></returns>
        public static Client GetNext(Client reference)
        {
            var reader = DatabaseConnector.GetReader("SELECT TOP 1 * FROM tblChaoticCallCenter WHERE ClientID > " + reference.ID.ToString());
            reader.Read();
            var client = new Client(reader);
            DatabaseConnector.Disconnect(); // always a good idea to disconnect the database when we're done
            return client;
        }
        /// <summary>
        /// it connect to the database for it to go to the last record in the database 
        /// </summary>
        /// <returns></returns>
        public static Client GetLast()
        {
            var reader = DatabaseConnector.GetReader("SELECT TOP 1 * FROM tblChaoticCallCenter ORDER BY ClientID DESC" );
            reader.Read();
            var client = new Client(reader);
            DatabaseConnector.Disconnect(); // always a good idea to disconnect the database when we're done
            return client;
        }
        /// <summary>
        /// It saves the ID 
        /// </summary>
        public void Save()
        {
             if (ID > 0) Update();
             else Insert();

        }
        /// <summary>
        /// Inserts the database 
        /// </summary>
        private void Insert()
        {

            string query = "INSERT INTO tblChaoticCallCenter (FirstName, LastName, Birthdate, Gender,Happy, Comment,Company, Archive) ";
                query += "VALUES (\"{0}\", \"{1}\",  \"{2}\",\"{3}\", {4}, '{5}', \"{6}\", {7})";
            query = string.Format(query, FirstName, LastName, BirthDate.Date, Gender, Happy ? -1 : 0, Comment, Company, Archive);
            DatabaseConnector.InsertEntity(query);
        }

        private void Update()
        {
        }

    }
}
    #endregion Events  





