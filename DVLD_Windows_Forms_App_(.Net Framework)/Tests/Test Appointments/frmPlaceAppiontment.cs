using DVLD_Buisnes_Laye;
using DVLD_Buisnes_Layer;
using System;
using System.Windows.Forms;

namespace Driving_License_Management
{
    public partial class frmPlaceAppiontment : Form
    {
        private clsTestApointment TestApointment;
        private int _Trail;
        public frmPlaceAppiontment(clsTestApointment apointment, int trails)
        {
            InitializeComponent();
            this.TestApointment = apointment;
            _Trail = trails;
        }

        private void frmPlaceAppiontment_Load(object sender, EventArgs e)
         {
            lblTrail.Text = _Trail.ToString();
            LoadTestInfo();
            LoadApplicationInfo();
            if (TestApointment.AppointmentID == -1)
            {
                Add();
            }
            else
            {
                Edit();
            }
            if (!TestApointment.IsTheFirst())
            {
                Retake();
            }

            CalulateTotalFees();



        }
        private void LoadTestInfo()
        {
            clsTestType testType = clsTestType.Find((clsTestType.enTypeID)TestApointment.TestType);
            if (testType != null)
            {
                lblTitel.Text = "Schedule " + testType.Titel;
                gbxAppointmentInfo.Text = testType.Titel;
                lblFees.Text = testType.Fees.ToString();

            }
        }
        private void LoadApplicationInfo()
        {
            clsLocalLicenseApplecation localLicenseApplecation = clsLocalLicenseApplecation.FindByMainApp(TestApointment.Application);
            if (localLicenseApplecation != null)
            {
                lblLDLAppID.Text = localLicenseApplecation.NewLicenseApplicationID.ToString();
                lblClassName.Text = localLicenseApplecation.ClassDescription();
                lblName.Text = localLicenseApplecation.ApplicantFullName();
            }


        }

        private void CalulateTotalFees()
        {
            decimal totalFees = Convert.ToDecimal(lblFees.Text) + Convert.ToDecimal(lblRAppFee.Text);
            lblTotalFees.Text = totalFees.ToString();
        }

        private void Retake()
        {
            grbxRetakeTest.Enabled = true;
            decimal RTestFees = clsAppType.Find(2).Fee; 
            lblRAppFee.Text = RTestFees.ToString();
            if (TestApointment.AppointmentID != -1)
            {
                lblRTAppID.Text = TestApointment.AppointmentID.ToString();
            }
        }
        private void Add()
        {
            dtpAppointmentDate.MinDate = DateTime.Today;
           
            
        }

        private void Edit()
        {
            dtpAppointmentDate.Value = TestApointment.Date;
            if (TestApointment.Looked)
            {
                dtpAppointmentDate.Enabled = false;
                btnSave.Enabled = false;
                lblIsLooked.Visible = true;
            }
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillAppointmentObject()
        {
            TestApointment.Date    = dtpAppointmentDate.Value;
            TestApointment.PaidFee = Convert.ToDecimal(lblTotalFees.Text);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            FillAppointmentObject();
            if (TestApointment.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Save Data failed");
            }
        }
    }
}
