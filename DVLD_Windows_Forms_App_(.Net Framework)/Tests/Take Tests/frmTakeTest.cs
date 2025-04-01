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
    public partial class frmTakeTest : Form
    {
        private int _trail;

        private clsTest _test;
        
        public frmTakeTest(clsTest test, int trail)
        {
            InitializeComponent();
            this._test = test;
            this._trail = trail;
        }
        private void LoadInfo()
        {
            clsTestApointment apointment = clsTestApointment.Find(_test.AppointmentID);
            clsTestType testType = clsTestType.Find((clsTestType.enTypeID) apointment.TestType);
            if (testType != null)
            {
                lblTitel.Text =  testType.Titel;

                gbxTestInfo.Text = testType.Titel;
                lblFees.Text = testType.Fees.ToString();
            }
            clsLocalLicenseApplecation localLicenseApplecation =clsLocalLicenseApplecation.FindByMainApp(apointment.Application);
            lblLDLAppID.Text = localLicenseApplecation.NewLicenseApplicationID.ToString();
            lblClassName.Text = localLicenseApplecation.ClassDescription();
            lblName.Text = localLicenseApplecation.ApplicantFullName();
        }
        

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            lblTrail.Text = _trail.ToString();
            lblDate.Text = DateTime.Today.ToShortDateString();
            lblTestID.Text = "Not Taked Yet";
            rbPass.Checked = true;
            LoadInfo();




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTestObject()
        {
            _test.IsPassed= rbPass.Checked;

        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            FillTestObject();
            DialogResult result = MessageBox.Show(
            "Are you sur you want to save? After that you cann't change the result.", // Message text
            "Confirm",                // Title
            MessageBoxButtons.YesNo,   // Yes/No buttons
            MessageBoxIcon.Warning     // Warning icon
        );
            if (result == DialogResult.Yes)
            {
                int testID = -1;
                if (_test.Save(ref testID))
                {
                    lblTestID.Text = testID.ToString();
                    MessageBox.Show("Data saved successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data saved failed");
                }
            }
           
        }
    }
}
