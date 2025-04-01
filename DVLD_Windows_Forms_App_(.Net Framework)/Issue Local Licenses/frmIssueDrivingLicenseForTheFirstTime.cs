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
    public partial class frmIssueDrivingLicenseForTheFirstTime : Form
    {
        private int _LDLAppID;
        public frmIssueDrivingLicenseForTheFirstTime(int lDLAppID)
        {
            InitializeComponent();
            _LDLAppID = lDLAppID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssueDrivingLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            uctrlLocalDrivingLicenseApplication1.LDLAppID= _LDLAppID;
            uctrlLocalDrivingLicenseApplication1.FilluctrlLDLAppDetails();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLocalLicense.Issue(_LDLAppID, txtbxNote.Text, "new");
            if (LicenseID!=-1)
            {
                MessageBox.Show($"License issued successfully. With License ID =[{LicenseID}].");
                this.Close();
            }
            else
            {
                MessageBox.Show($"License issue failed.");
            }
        }
    }
}
