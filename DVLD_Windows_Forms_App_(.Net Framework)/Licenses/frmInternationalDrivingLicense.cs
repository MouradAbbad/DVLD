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
    public partial class frmInternationalDrivingLicense : Form
    {
        private int _InternationalLicenseID;
        public frmInternationalDrivingLicense(int InternationalLicenseID)
        {
            InitializeComponent();
            this._InternationalLicenseID = InternationalLicenseID;
        }

        private void clsInternationalDrivingLicense_Load(object sender, EventArgs e)
        {
            uctrlInternationalLicenseInfo1.InternationalLicenseID = _InternationalLicenseID;
            uctrlInternationalLicenseInfo1.DetailInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
