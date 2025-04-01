using DVLD_Buisnes_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management
{
    public partial class uctrlInternationalLicenseInfo : UserControl
    {
        public int InternationalLicenseID;
        public uctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public void DetailInfo()
        {
            int DriverID = -1;
            bool isActive=false;
            string NationalID = "";
            string Name = "";
            DateTime DateofBirth = DateTime.Today;
            bool Gender = false;
            string PersonalPhoto = "";
            
            clsInternationalLicens licens = clsInternationalLicens.Find(InternationalLicenseID, ref DriverID, ref isActive, ref NationalID
                , ref Name, ref DateofBirth, ref Gender, ref PersonalPhoto);
            if (licens!=null)
            {
            
                lblInternationalLicenseID.Text=InternationalLicenseID.ToString();
                lblDateOfBirth.Text=DateofBirth.ToShortDateString();
                lblDriverID.Text=DriverID.ToString();
                lblExpirationDate.Text=licens.ExpiryDate.ToShortDateString();
                lblGendor.Text = Gender ? "Male" : "Femal";
                lblIsActive.Text= isActive?"Yes" : "No";
                lblIssueDate.Text= licens.IssuanceDate.ToShortDateString();
                lblLicensID.Text= licens.License.ToString();
                lblName.Text= Name;
                lblNationalNO.Text= NationalID;
                pctbxPersonalPhoto.ImageLocation = Path.Combine(clsDVLDAppSetting.PeoplepPhotosFolder, PersonalPhoto);
                pctbxPersonalPhoto.SizeMode= PictureBoxSizeMode.StretchImage;
                
            }
        }

       
    }
}
