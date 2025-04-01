using DVLD_Buisnes_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management
{
    public partial class frmManageAppointements : Form
    {
        private int _ID;
        private int _TestType;
        clsLocalLicenseApplecation localLicenseApplecation;
        public frmManageAppointements(int NLDLAppID/*,int testType*/)
        {
            InitializeComponent();
            _ID = NLDLAppID;
          //  _TestType = testType;
        }

        private void frmVisionTestAppointements_Load(object sender, EventArgs e)
        {
            localLicenseApplecation = clsLocalLicenseApplecation.Find(_ID);
            _TestType = localLicenseApplecation.PassedTests + 1;
            string TestTitel = clsTestType.Find((clsTestType.enTypeID)_TestType).Titel;
            lblTitel.Text= "Schedual " + TestTitel;
            this.Text = TestTitel + " Appointements";


            Filluctrl();
            FillDataGridView();
        }
        private void Filluctrl()
        {
            uctrlLocalDrivingLicenseApplication1.LDLAppID = _ID;
            uctrlLocalDrivingLicenseApplication1.FilluctrlLDLAppDetails();
        }


        private void FillDataGridView()
        {
           
            int AppID = localLicenseApplecation.Application;
            dataGridView1.DataSource=clsTestApointment.List(AppID, _TestType);
            lblRecords.Text= dataGridView1.Rows.Count.ToString();
        }

        private bool IsPassed()
        {
            return localLicenseApplecation.PassedTests == _TestType;
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (IsPassed())
            {
                MessageBox.Show("This Person Already Passed The Test");
                return;
            }
          //  int ActiveAppointmentID = clsTestApointment.ActiveAppointment(localLicenseApplecation.Application);
            clsTestApointment testApointment = clsTestApointment.Place(localLicenseApplecation.Application);
            if (testApointment != null)
            {
                int trail = CountTrails();
                frmPlaceAppiontment frm = new frmPlaceAppiontment(testApointment,trail);
                frm.ShowDialog();
                FillDataGridView();
                dataGridView1.Refresh();
            }
            else 
            {
                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{

                //    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == ActiveAppointmentID.ToString())
                //    {
                //        row.Selected = true;
                //        break;  // Select only the first matching row
                //    }
                //}
                MessageBox.Show("This Person Already hase an active Appointment");
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            bool IsLooked = (bool)dataGridView1.SelectedRows[0].Cells["Looked"].Value;
           // bool IsLooked= (bool)dataGridView1.SelectedRows[0].Cells["Looked"].Value;
            bool isDate= (DateTime)dataGridView1.SelectedRows[0].Cells["Date"].Value == DateTime.Today;
            editToolStripMenuItem.Enabled = true;
            takeTestToolStripMenuItem.Enabled = false;

            if (!IsLooked )
            {
                //editToolStripMenuItem.Enabled = true;
                if (isDate)
                {
                    takeTestToolStripMenuItem.Enabled = true;
                }
            }
        }

        private int CountTrails()
        {

            int trail = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ( (bool)row.Cells["Looked"].Value)
                {
                    trail++;
                }
            }
            return trail;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int trail = CountTrails();
            

            int AppointmenID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            clsTestApointment testApointment = clsTestApointment.Find(AppointmenID);
           // bool IsLooked = (bool)dataGridView1.SelectedRows[0].Cells["Looked"].Value;
            
            frmPlaceAppiontment frm = new frmPlaceAppiontment(testApointment, trail);
            frm.ShowDialog();
            FillDataGridView();
            dataGridView1.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int trail = CountTrails();
            int ActAppointment = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            clsTest test = clsTest.Take(ActAppointment);
            if (test!= null)
            {
                frmTakeTest frm = new frmTakeTest(test, trail);
                frm.ShowDialog();
                localLicenseApplecation = clsLocalLicenseApplecation.Find(_ID);
                Filluctrl();
                FillDataGridView();
                dataGridView1.Refresh();
            }
           
        }
    }
}
