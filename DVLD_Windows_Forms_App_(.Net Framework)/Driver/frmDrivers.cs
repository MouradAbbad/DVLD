using DVLD_Buisnes_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management
{
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
          
            cmbxFiltterby.SelectedIndex = 0;
            txtbxValueOfFiltring.Hide();

            FillDriverTable();
        }

        private void FillDriverTable()
        {
            if (cmbxFiltterby.SelectedIndex!=0)
            {
              
            
                dtgdDrivesTable.DataSource = clsDriver.List(cmbxFiltterby.SelectedItem.ToString(),txtbxValueOfFiltring.Text);

            }
            else
            {
                
                dtgdDrivesTable.DataSource = clsDriver.List();
            }
            lblRecords.Text= dtgdDrivesTable.RowCount.ToString();
        }

        private void cmbxFiltterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxFiltterby.SelectedIndex != 0)
            {
                txtbxValueOfFiltring.Show();
            }
            else
            {
                txtbxValueOfFiltring.Hide();
            }
        }

        private void txtbxValueOfFiltring_TextChanged(object sender, EventArgs e)
        {
            FillDriverTable();
            dtgdDrivesTable.Refresh();
        }
    }
}
