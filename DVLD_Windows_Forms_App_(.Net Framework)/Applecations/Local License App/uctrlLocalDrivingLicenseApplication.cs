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

    public partial class uctrlLocalDrivingLicenseApplication : UserControl
    {

        public int LDLAppID;
        public uctrlLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        public void FilluctrlLDLAppDetails()
        {
            clsLocalLicenseApplecation LocalLicenseApplecation = clsLocalLicenseApplecation.Find(LDLAppID);
            lblLDLAppID.Text =LocalLicenseApplecation.NewLicenseApplicationID.ToString();
            lblClass.Text = clsLicenseClass.GetClassDescription(LocalLicenseApplecation.licenseClass);
            lblPassedTest.Text = LocalLicenseApplecation.PassedTests.ToString()+"/3";
            uctrlApplecationDetail1.AppID=LocalLicenseApplecation.Application;
            uctrlApplecationDetail1.FilluctrlApplicationDetail();
            
        }
       
    }
}
