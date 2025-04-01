using DVLD_Buisnes_Laye;
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
    public partial class frmManageAplicationTypes : Form
    {
        DataView DataView;
        public frmManageAplicationTypes()
        {
            InitializeComponent();
            lblTitel.Text = "Manage Application Types";
            lblTitel.ForeColor=Color.Red;
            






        }
        private void frmManageAplicationTypes_Load(object sender, EventArgs e)
        {
            DataView = clsAppType.GetApplicationsTypeList().DefaultView;
            dgvTypesList.DataSource = DataView;
            lblNumberOfRecords.Text = DataView.Count.ToString();
            if (DataView.Count>0)
            {
                dgvTypesList.Columns[0].HeaderText = "ID";
                dgvTypesList.Columns[0].Width=50;

                dgvTypesList.Columns[1].HeaderText = "Titel";
                dgvTypesList.Columns[1].Width = 350;

                dgvTypesList.Columns[2].HeaderText = "Fee";
                dgvTypesList.Columns[2].Width = 99;
            }
        }

      


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplecationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int typeID = (int)dgvTypesList.CurrentRow.Cells[0].Value;
            frmEditApplecationType FRM = new frmEditApplecationType(typeID);
            FRM.ShowDialog();
            frmManageAplicationTypes_Load(null, null);
        }
    }
}
