using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisnes_Layer;

namespace Driving_License_Management.Applecations.Issue_International_Driving__Licenses
{
    public partial class uctrlFindLicense: UserControl
    {

        public event Action<clsLocalLicense> onLicenssFind;

        protected virtual void LocalLicenssID(clsLocalLicense licenss)
        {
            if (onLicenssFind!= null)
            {
                onLicenssFind(licenss);
            }
        }



        //clsInternationalLicens InternationalLicense;
        
        public uctrlFindLicense()
        {
            InitializeComponent();
        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            int licenseID = int.Parse(txtbxLicenseID.Text.Trim());

            clsLocalLicense licenss = clsLocalLicense.Fined(licenseID);

            uctrlLicenseInfo1.FilluctrlLicenseInfo(licenss);
            if (licenss != null)
            {
                LocalLicenssID(licenss);
            }

        }

        private void txtbxLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& ! char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void Clear()
        {
            txtbxLicenseID.Clear();
            uctrlLicenseInfo1.FilluctrlLicenseInfo(null);
            txtbxLicenseID.Focus();
        }
    }
}
