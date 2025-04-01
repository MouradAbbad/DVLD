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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Driving_License_Management
{
    public partial class frmManageLocalDrivingLicenseApplecations : Form
    {
        //private DataTable table;
        public frmManageLocalDrivingLicenseApplecations()
        {
            InitializeComponent();
        }
        private void FillDataGridView()
        {
            if (cmbxFilterBy.SelectedIndex != 0)
            {
                FilterBy();
            }
            else
            {
                DataTable table = clsLocalLicenseApplecation.DetailsList();
                dgvLDLApp.DataSource = table;
                lblRecordsNumber.Text = table.Rows.Count.ToString();
            }
           
            
        }

        private void FilterBy()
        {
            DataTable table = clsLocalLicenseApplecation.DetailsListFilter(cmbxFilterBy.Text,txbValueForFiltring.Text);
            dgvLDLApp.DataSource = table;
            lblRecordsNumber.Text = table.Rows.Count.ToString();
        }

        private void frmLocalDrivingLicenseApplecations_Load(object sender, EventArgs e)
        {
            lblRecordsNumber.Text = "0";
            cmbxFilterBy.SelectedIndex = 0;
            txbValueForFiltring.Hide();
            
            FillDataGridView();
        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
           frmAddLocalLicensApplecation frm = new frmAddLocalLicensApplecation();
            frm.ShowDialog();
            FillDataGridView();
            dgvLDLApp.Refresh();
        }

        private void cmbxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbValueForFiltring.Text= string.Empty;
            txbValueForFiltring.Show();
            txbValueForFiltring.Focus();
            txbValueForFiltring.KeyPress -= txbValueForFiltring_KeyPress;
            
            if (cmbxFilterBy.SelectedItem.ToString()== "New License Application ID")
            {
                txbValueForFiltring.KeyPress += txbValueForFiltring_KeyPress;
            }
            if (cmbxFilterBy.SelectedIndex==0)
            {
                txbValueForFiltring.Hide();
            }
        }

        private void txbValueForFiltring_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void txbValueForFiltring_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a number (0-9) or backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If not, cancel the keypress event
                e.Handled = true;
            }
        }
        private void TestAppointement()
        {
            int LDLAppID = (int)dgvLDLApp.CurrentRow.Cells["New License Application ID"].Value;
           // int testtype = 1 + (short)dgvLDLApp.CurrentRow.Cells["Passed Tests"].Value;
            frmManageAppointements frm = new frmManageAppointements(LDLAppID/*, testtype*/);
            frm.ShowDialog();
            FillDataGridView();
            dgvLDLApp.Refresh();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TestAppointement();
        }
        private void CheckPassedTests()
        {
            
            short PassedTests= (short)dgvLDLApp.CurrentRow.Cells["Passed Tests"].Value;
            switch (PassedTests)
            { 
                   
                case 0:
                    tsmiScheduleVisionTest.Enabled = true;
                    return;
                case 1:
                    tsmiScheduleWritenTest.Enabled = true;
                    return;
                case 2:
                    tsmiScheduleStreetTest.Enabled = true;
                    return;
                case 3:
                    tsmiScheduleTest.Enabled  = false;
                tsmiIssueDrivingLicenseFirstTime.Enabled = true;
                    return;
            }
        }
        private void CheckStatus()
        {

            string Statu = dgvLDLApp.SelectedRows[0].Cells["Application Statu"].Value.ToString();
            switch (Statu)
            {

                case "New":
                    CheckPassedTests();
                    return;
                case "Completed":
                    tsmiCancelApplecation.Enabled = false;
                    tsmiDeleteApplecation.Enabled = false;
                    tsmiEditApplecation.Enabled = false;
                    tsmiIssueDrivingLicenseFirstTime.Enabled= false;
                    tsmiScheduleTest.Enabled= false;
                    tsmiShowLicense.Enabled = true;
                    return;
                case "Canceld":
                   
                    return;
                //case 3:
                //    tsmiScheduleTest.Enabled = false;
                //    tsmiIssueDrivingLicenseFirstTime.Enabled = true;
                //    return;
            }
        }
        private void dgvLDLApp_MouseDown(object sender, MouseEventArgs e)
        {
            tsmiShowAppDetail.Enabled = true;
            tsmiEditApplecation.Enabled = true;
            tsmiDeleteApplecation.Enabled = true;
            tsmiCancelApplecation.Enabled = true;
           
            tsmiScheduleTest.Enabled = true;
            tsmiScheduleVisionTest.Enabled = false;
            tsmiScheduleWritenTest.Enabled = false;
            tsmiScheduleStreetTest.Enabled = false;
          
            tsmiIssueDrivingLicenseFirstTime.Enabled = false;
            tsmiShowLicense.Enabled = false;
            tsmiShowPersonLicensHistory.Enabled = true;
            CheckStatus();


        }

        private void tsmiScheduleWritenTest_Click(object sender, EventArgs e)
        {

            TestAppointement();
        }

        private void tsmiScheduleStreetTest_Click(object sender, EventArgs e)
        {

            TestAppointement();
        }

        private void tsmiIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLDLApp.SelectedRows[0].Cells["New License Application ID"].Value;
            frmIssueDrivingLicenseForTheFirstTime frm = new frmIssueDrivingLicenseForTheFirstTime(LDLAppID);
            frm.ShowDialog();
            FillDataGridView();
            dgvLDLApp.Refresh();
        }

        private void tsmiShowLicense_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLDLApp.SelectedRows[0].Cells["New License Application ID"].Value;
            clsLocalLicenseApplecation licenseApplecation = clsLocalLicenseApplecation.Find(LDLAppID);
            short classID = licenseApplecation.licenseClass;
            int personID = clsApplication.Find(licenseApplecation.Application).PersonID;


            frmLicenseInfo frm =new frmLicenseInfo(personID,classID);
            frm.ShowDialog();
        }

        private void tsmiShowPersonLicensHistory_Click(object sender, EventArgs e)
        {
            string NationalID = (string)dgvLDLApp.SelectedRows[0].Cells["National ID"].Value;
            frmLicenseHistory frm = new frmLicenseHistory(NationalID);
            frm.ShowDialog();
        }

        private void tsmiDeleteApplecation_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sur do you delete this Application!?","Conferm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                int LDLAppID = (int)dgvLDLApp.SelectedRows[0].Cells["New License Application ID"].Value;
                if (clsLocalLicenseApplecation.Delete(LDLAppID))
                {
                    MessageBox.Show("This Application deleted successfully");
                    FillDataGridView();
                    dgvLDLApp.Refresh();
                }
                else
                {
                    MessageBox.Show("You cannot delete this application because there is data related to it.");

                }
            }
        }
    }
}
