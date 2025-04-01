using DVLD_Buisnes_Layer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
 

namespace Driving_License_Management
{
    public partial class frmAddOrEditPerson : Form
    {
     
      
        clsPerson person;

        public frmAddOrEditPerson()
        {
            InitializeComponent();
            person = new clsPerson();
        }
        public frmAddOrEditPerson(int PersonID)
        {
            InitializeComponent();
            this.person = clsPerson.Find(PersonID);
        }
        public frmAddOrEditPerson(clsPerson Person)
        {
            InitializeComponent();
            this.person = Person;
        }

        // Delegate declaration

        public delegate void dlgPersonDataBak(clsPerson person);

        
        // Create an instance of the delegate
        public dlgPersonDataBak GetBackPerson;

        private void SendBackPerson(clsPerson Person)
        {
            GetBackPerson?.Invoke(person);
        }
        
        private void frmAddOrEditPerson_Load(object sender, EventArgs e)
        {
            FillNationalityComboBox();
            PopulateFormWithData();

        }
        
        private void PopulateFormWithData()
        {
            
            string formTitle = "";
            switch (person.Mode)
            {
                case clsPerson.enPersonMode.AddNewMode:
                    formTitle = "Add New Person";
                    lblPersonID.Text = "N/A";
                    rbMale.Checked = true;
                    dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
                    cbxNationality.SelectedIndex = cbxNationality.FindStringExact("Algeria");
                    txtbFirstname.Focus();
                    break;
                case clsPerson.enPersonMode.UpdateMode:

                    formTitle = "Edit Person Info";
                    lblPersonID.Text = person.PersonID.ToString();
                    txtbNationalID.Text = person.NationalID;
                    txtbFirstname.Text = person.FirstName;
                    txtbSecondname.Text = person.SecondName;
                    txtbThirdname.Text = person.ThirdName;
                    txtbLastname.Text = person.LastName;
                    if (person.gender)
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }
                    dtpDateOfBirth.Value = person.DateofBirth;
                    txtbAddress.Text = person.Address;
                    txtbPhone.Text = person.PhoneNumber;
                    txtbEmail.Text = person.Email;
                    cbxNationality.SelectedIndex = cbxNationality.FindStringExact(person.Country.CountryName);
                    pbPersonalPhoto.ImageLocation =  person.PersonalPhoto;  

                    break;
            }
            this.Text = formTitle;
            lblTitel.Text = formTitle;
            lklblRemoveImage.Visible = !string.IsNullOrWhiteSpace(pbPersonalPhoto.ImageLocation);
        }
        
        private void FillNationalityComboBox()
        {
            DataTable dtCountries = clsCountry.CountriesList();
            DataView dataView = dtCountries.DefaultView;
            cbxNationality.DataSource = dataView;
            cbxNationality.DisplayMember = "CountryName";
            cbxNationality.ValueMember = "CountryID";

        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pbPersonalPhoto.ImageLocation))
            {
                return;
            }
            if (rbMale.Checked)
            {
                pbPersonalPhoto.Image = Properties.Resources.boy;
            }
            else 
            {
                pbPersonalPhoto.Image = Properties.Resources.girl;
            }
        }

        private void lklblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonalPhoto.ImageLocation = clsUtil.SelectSourceImagePath();
            lklblRemoveImage.Visible = !string.IsNullOrWhiteSpace(pbPersonalPhoto.ImageLocation);
        }

        private  bool HandleImageSaveAndDisplay()
        {
            //1- In case the user didn't select any image, pictureBox.ImageLocation == person.Photo; in both person Modes  AddNew and Update.we don't have to do anything.
            //2- In case the user selected an new image, we have to delet the old image if exists than copy the new image to the target folder.
            //3- In case the user remove the existing image, we have to delet the old image if exists.

            bool isHandeld = false;

            //In case the user selected a new image or remove the existing image
            if (person.PersonalPhoto != pbPersonalPhoto.ImageLocation)
            {
                //we have to delet the old image if exists
                if (!string.IsNullOrWhiteSpace(person.PersonalPhoto))
                {
                    File.Delete(person.PersonalPhoto);
                }
                //if selected new image copy it to the target folder.
                if (!string.IsNullOrWhiteSpace(pbPersonalPhoto.ImageLocation))
                {
                    string imageSourcePath = pbPersonalPhoto.ImageLocation;
                    isHandeld = clsUtil.IsCopyImage(ref imageSourcePath);
                    pbPersonalPhoto.ImageLocation = imageSourcePath;
                }
                else
                {
                    isHandeld = true;
                }
            }
            else
            {
                //the user didn't select any image,
                isHandeld = true;
            }
            return isHandeld;
        }
        

        private void txtbXInput_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                erpCheckMandatorytxtbX.SetError(textBox, "This field is required.");
                e.Cancel = true; // Prevents focus loss
            }
            else
            {
                erpCheckMandatorytxtbX.SetError(textBox, ""); // Clears error if valid
            }

        }


        private void txtbNationalID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNationalID.Text))
            {
                erpCheckMandatorytxtbX.SetError(txtbNationalID, "This field is required.");
                e.Cancel = true; // Prevents focus loss
            }
            else
            {
                if (  txtbNationalID.Text.Trim()!=person.NationalID && clsPerson.IsExists(txtbNationalID.Text.Trim()))
                {
                    erpCheckMandatorytxtbX.SetError(txtbNationalID, "This national ID allready used");
                    e.Cancel = true; // Prevents focus loss
                }
                else
                {
                    erpCheckMandatorytxtbX.SetError(txtbNationalID, ""); // Clears error if valid
                }
            }
                    
        }


        private void txtbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbEmail.Text) && !clsValidation.IsValideEmail(txtbEmail.Text.Trim()))
            {
                erpCheckMandatorytxtbX.SetError(txtbEmail, "Please enter a valide email");
                e.Cancel = true; // Prevents focus loss
            }
            else
            {
               
                erpCheckMandatorytxtbX.SetError(txtbEmail, ""); // Clears error if valid
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                if (!HandleImageSaveAndDisplay())
                {
                    MessageBox.Show("Failed to save personal Photo. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                person.NationalID = txtbNationalID.Text;
                person.FirstName = txtbFirstname.Text;
                person.SecondName = txtbSecondname.Text;
                person.ThirdName = txtbThirdname.Text;
                person.LastName = txtbLastname.Text;
                person.gender = rbMale.Checked;
                person.DateofBirth = dtpDateOfBirth.Value;
                person.Address = txtbAddress.Text;
                person.PhoneNumber = txtbPhone.Text;
                person.Email = txtbEmail.Text;
                person.Nationality = Convert.ToInt32(cbxNationality.SelectedValue);
                person.PersonalPhoto = pbPersonalPhoto.ImageLocation;

               

                if (person.Save())
                {
                    if (MessageBox.Show("Personal information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                    {
                        
                        PopulateFormWithData();
                    }
                    SendBackPerson(this.person);
                }
                else
                {
                    MessageBox.Show("Failed to save personal information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.Delete(pbPersonalPhoto.ImageLocation);
                }
            }
            else
            {
                MessageBox.Show("Invalid input! Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void lklblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonalPhoto.ImageLocation = null;
            if (rbMale.Checked)
            {
                pbPersonalPhoto.Image = Properties.Resources.boy;
            }
            else
            {
                pbPersonalPhoto.Image = Properties.Resources.girl;
            }
            lklblRemoveImage.Visible=false;
           
        }
    }
}
