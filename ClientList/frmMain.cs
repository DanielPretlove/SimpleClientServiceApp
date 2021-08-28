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

        }

        private void dgvClientData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientData.SelectedCells[0].Style
   = new DataGridViewCellStyle { ForeColor = Color.Yellow };
        }
    }
}
