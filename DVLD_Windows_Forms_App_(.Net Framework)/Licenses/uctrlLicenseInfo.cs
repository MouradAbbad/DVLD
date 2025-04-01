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
    public partial class uctrlLicenseInfo : UserControl
    {

        //public int personID;
        //public short licenseClass;
        //public ClsLocalLicence license;

        public uctrlLicenseInfo()
        {
            InitializeComponent();
        }

        public void FilluctrlLicenseInfo(clsLocalLicense license)
        {
            //ClsLocalLicence license = ClsLocalLicence.Fined(personID, licenseClass);
            if (license==null)
            {
                return;
            }
            lblClass.Text = clsLicenseClass.GetClassDescription(license.Class);
            clsPerson person = clsPerson.Find(license.personID);
            lblName.Text= person.FullName();
            lblLicenseID.Text = license.LicenseID.ToString();
            lblNationalNO.Text= person.NationalID.ToString();
            lblGendor.Text = person.gender ? "Male" : "Female";
            lblIssueDate.Text = license.IssuanceDate.ToShortDateString();
            lblIssueReason.Text= license.Statu.ToString();
            lblNotes.Text = license.Conditions == "" ? "No Notes" : license.Conditions;
            lblIsActive.Text = license.isActive ? "Yes" : "No";
            lblDateOfBirth.Text= person.DateofBirth.ToShortDateString();
            lblDriverID.Text =license.driverID.ToString();
            lblExpirationDate.Text=license.ExpiryDate.ToShortDateString();
            lblIsDetained.Text = "No";
            pctbxPersonalPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            string Imagepath= Path.Combine(clsDVLDAppSetting.PeoplepPhotosFolder,person.PersonalPhoto);
            pctbxPersonalPhoto.ImageLocation=Imagepath;
           

        }

    }
}
