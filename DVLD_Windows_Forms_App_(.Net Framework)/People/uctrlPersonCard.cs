using DVLD_Buisnes_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management
{
    public partial class uctrlPersonCard : UserControl
    {
        public clsPerson person;
        public uctrlPersonCard()
        {
            InitializeComponent();
            
            
        }
       
        private void lklblEditePersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddOrEditPerson frm = new frmAddOrEditPerson(person);
            frm.ShowDialog();
            this.LoadInfoToCtrl(person);
        }
        public void LoadInfoToCtrl(clsPerson person)
        {
            if (person == null)
            {
                //MessageBox.Show($"No Person Exists with National ID: []!");
                lblPersonID.Text = "[?????]";
                lblFullName.Text = "[?????]";
                lblNationalID.Text = "[?????]";
                lblGender.Text =   "[?????]";
                lblEmail.Text =      "[?????]";
                lblAddress.Text = "[?????]";
                lblDateOfBirth.Text = "[?????]";
                lblPhoneNumber.Text = "[?????]";
                pbPersonalPhoto.Image =  Properties.Resources.boy ;
                lklblEditePersonInfo.Visible=false;
               
            }
            else
            {
                lblPersonID.Text = person.PersonID.ToString();
                lblFullName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                lblNationalID.Text = person.NationalID;
                lblGender.Text = person.gender ? "Male" : "Female";
                lblEmail.Text = person.Email;
                lblAddress.Text = person.Address;
                lblDateOfBirth.Text = person.DateofBirth.ToString();
                lblPhoneNumber.Text = person.PhoneNumber;
                lblCountry.Text = person.Country.CountryName;
                if (string.IsNullOrWhiteSpace(person.PersonalPhoto))
                {
                    pbPersonalPhoto.Image = person.gender ? Properties.Resources.boy : Properties.Resources.girl;
                }
                else
                {
                    pbPersonalPhoto.ImageLocation = person.PersonalPhoto;
                }
                lklblEditePersonInfo.Visible = true;
            }
           
           this.person = person;
        }

      
    }
}
