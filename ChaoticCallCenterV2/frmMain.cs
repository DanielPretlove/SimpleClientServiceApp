using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaoticCallCenterV2
{
    public partial class frmMain : Form
    {
        #region vars
      
        
        private List<Client> Records { get; set; }
        

        Client currentClient = new Client();

        public string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ChaoticCallCenter.accdb";
        

        #endregion vars

        #region init 

        public frmMain()
        {
            InitializeComponent();
        }
       
        #endregion init 

        #region Client 
        /// <summary>
        /// Displays the record 
        /// </summary>
        /// <param name="Client"></param>
        private void DisplayClient(Client client)
        {
            lblID.Text = client.ID.ToString();
            txtFirstName.Text = currentClient.FirstName;
            txtLastName.Text = currentClient.LastName;
            txtComment.Text = currentClient.Comment;

            if (currentClient.Gender == "Male")
            {
                radMale.Checked = true;
            }
            else if (currentClient.Gender == "Female")
            {
                RadFemale.Checked = true;
            }
            else
            {
                RadOther.Checked = true;
            }

            if(currentClient.Happy)
            {
                RadYes.Checked = true;
                RadNo.Checked = false;
            }
            else
            {
                RadYes.Checked = false;
                RadNo.Checked = true;
            }

            CompDropDownBox.Text = currentClient.Company;
            BirthDate.Value = currentClient.BirthDate;

        }
        /// <summary>
        /// it loads the Client from the database 
        /// </summary>
        private void LoadClients()
        {
            if (!chkArchive.Checked)
            {
                LoadClient("SELECT * FROM tblChaoticCallCenter WHERE Archive <> -1");
            }
            else
            {
                LoadClient("SELECT * FROM tblChaoticCallCenter");
            }
        }
        /// <summary>
        /// loads the records of the clients from the database 
        /// </summary>
        /// <param name="query"></param>
        private void LoadClient(String query)
        {
            OleDbConnection dbConn = new OleDbConnection(ConnectionString);

            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);

            // Connect to database
            dbConn.Open();

            // Used to iterate through the DB records 
            OleDbDataReader reader = dbCmd.ExecuteReader();

            // Stores the records from the database 
            Records = new List<Client>();

            while (reader.Read())
            {
                // Create a new birthday instance 
                Client record = new Client();

                // Populate the new instance with data from the reader 
                record.ID = (int)reader["ClientID"];
                record.FirstName = (string)reader["FirstName"];
                record.LastName = (string)reader["LastName"];
                record.Gender = (string)reader["Gender"];
                record.Comment = (string)reader["Comment"];
                record.Happy = (bool)reader["Happy"];
                record.Archive = (bool)reader["Archive"];
                record.Company = (string)reader["Company"];
                record.BirthDate = (DateTime)reader["Birthdate"];

                if (record.Gender == "Male")
                {
                    radMale.Checked = true;
                }
                else if (record.Gender == "Female")
                {
                    RadFemale.Checked = true;
                }
                else
                {
                    RadOther.Checked = true;
                }

                // Add the record we just populated with data read from
                Records.Add(record);

            }


            // Bind the data grid view's data source to the list of records 
            dgvResults.DataSource = Records;
        }
        #endregion Client  

        #region events 
        /// <summary>
        /// Add a new record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            currentClient = new Client();
            DisplayClient(currentClient);
            txtFirstName.Clear();
            txtLastName.Clear();
            chkArchive.Checked = currentClient.Archive; 
            radMale.Checked = false;
            RadFemale.Checked = false;
            RadOther.Checked = true;
            isHappy();
            txtComment.Clear();
            CompDropDownBox.SelectedIndex = 1;
            BirthDate.MinDate = new System.DateTime(); 
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadClient("SELECT * FROM tblChaoticCallCenter");
            try
            {
                currentClient = Client.GetFirst();
                DisplayClient(currentClient);
            }
            catch
            {
                MessageBox.Show("Cannot load the record");
            }
        }
        /// <summary>
        /// goes to first record 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                currentClient = Client.GetFirst();
                DisplayClient(currentClient);
            }
            catch
            {
                MessageBox.Show("Cannot load the record");
            }
        }
        /// <summary>
        /// goes to last record 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                currentClient = Client.GetLast();
                DisplayClient(currentClient);
            }
            catch
            {
                MessageBox.Show("Cannot load the record");
            }
        }
        /// <summary>
        /// goes to the next record 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                currentClient = Client.GetNext(currentClient);
                DisplayClient(currentClient);
            }
            catch
            {
                MessageBox.Show("Cannot load the record");
            }
        }
        /// <summary>
        /// it goes back to the previous record 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                currentClient = Client.GetBack(currentClient);
                DisplayClient(currentClient);
            }
            catch
            {
                MessageBox.Show("Cannot load the record");
            }
        }
        /// <summary>
        /// saves the record 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            currentClient.FirstName = txtFirstName.Text;
            currentClient.LastName = txtLastName.Text;
            currentClient.Comment = txtComment.Text;

            if(radMale.Checked)
            {
                currentClient.Gender = "Male";
            }
            else if (RadFemale.Checked)
            {
                currentClient.Gender = "Female";
            }
            else
            {
                currentClient.Gender = "Other";
            }

            if(RadYes.Checked)
            {
                currentClient.Happy = true;
            }
            else
            {
                currentClient.Happy = false;
            }

            currentClient.Company = CompDropDownBox.Text;
            currentClient.BirthDate = BirthDate.Value;
            currentClient.Save();

            try
            {
                currentClient = Client.GetLast();
                DisplayClient(currentClient);
            }
            catch
            {
                MessageBox.Show("Cannot load the record");
            }


            LoadClient("SELECT * FROM tblChaoticCallCenter");
        }

       
        /// <summary>
        /// exits the program 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion events  


        #region methods 
        /// <summary>
        /// searches an record for you 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblChaoticCallCenter WHERE FirstName='" + txtSearch.Text+"'";
            LoadClient(query);        
        }
             
        /// <summary>
        /// updates any record you want 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE tblChaoticCallCenter ";
                query += "SET FirstName='{0}', LastName= '{1}', Birthdate='{2}', Gender='{3}', Happy={4}, Comment='{5}', Company='{6}', Archive={7} ";
                query += "WHERE ClientID = " + currentClient.ID;

                if (radMale.Checked)
                {
                    currentClient.Gender = "Male";
                }
                else if (RadFemale.Checked)
                {
                    currentClient.Gender = "Female";
                }
                else
                {
                    currentClient.Gender = "Other";
                }

                query = string.Format(query,
                txtFirstName.Text,
                txtLastName.Text,
                BirthDate.Value,
                currentClient.Gender,
                RadYes.Checked ? -1 : 0,
                txtComment.Text,
                CompDropDownBox.SelectedItem.ToString(),
                currentClient.Archive);

                DatabaseConnector.ExecuteNonQuery(query);
                LoadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!");
                Debug.WriteLine("DEBUG: " + ex.Message);
            }

        }


        /// <summary>
        /// Checks if the client is satisfied
        /// </summary>
        /// <returns>True/False Depending on what choice they select. </returns>
        private bool isHappy()
        {
            if (RadYes.Checked == true)
            {
                return true;
            } else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks the gender and returns the appropriate string to what has been checked.
        /// </summary>
        /// <returns>Gender.</returns>


        private void btnListAll_Click(object sender, EventArgs e)
        {
            LoadClient("SELECT * FROM tblChaoticCallCenter");
        }
        /// <summary>
        /// It archives a record 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to archive this record", "Archive Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                currentClient.Archive = true; 
        }
        /// <summary>
        /// it updates all of new performance that happened in the records of the database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadClients();
        }
    }

}

#endregion methods 

