using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientList
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            dgvClientData.EnableHeadersVisualStyles = false;
            dgvClientData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientData.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvClientData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void dgvClientData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
