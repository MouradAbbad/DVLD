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
    public partial class frmAddOrEditUser : Form
    {
      
        clsUser user;
        public frmAddOrEditUser(int userID)
        {
            user = clsUser.Find(userID);
            InitializeComponent();
           
          
        }
        public frmAddOrEditUser(clsUser user)
        {
            this.user = user;
            InitializeComponent();
        }
        public frmAddOrEditUser()
        {
            InitializeComponent();
            user = new clsUser();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            string title = "";
            switch (user.Mode)
            {
                case clsUser.enUserMode.AddNewMode:
                    title = "Add New User";
                    lblUserID.Text = "????";
                    tpLogin.Enabled = false;
                    chkbIsActive.Checked = true;
                    uctrlPersonFind1.Focus();
                    break;
                case clsUser.enUserMode.UpdateMode:
                    title = "Edit User Info";
                    tpLogin.Enabled = true;
                  
                    uctrlPersonFind1.SelectedPerson = user.person;
                    uctrlPersonFind1.Enabled = false;
                    lblUserID.Text = user.UserID.ToString();
                    txtbUsername.Text = user.Username;
                    txtbPassword.Text = user.Password;
                    txtbConfirmPassword.Text = user.Password;
                    chkbIsActive.Checked = user.IsActive;
                    break;
                default:
                    return;
            }
            lblTitel.Text = title;
            this.Text = title;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (uctrlPersonFind1.SelectedPerson!=null)
            {
                if (clsUser.Exists(uctrlPersonFind1.SelectedPerson.PersonID)&&user.Mode ==clsUser.enUserMode.AddNewMode)
                {
                    MessageBox.Show("This person already has a user acount.");
                    btnSave.Enabled= false;
                    tpLogin.Enabled = false;
                    uctrlPersonFind1.Focus();
                }
                else
                {
                   
                    tpLogin.Enabled = true;
                    btnSave.Enabled = true;
                    tabContrl1.SelectedTab = tabContrl1.TabPages["tpLogin"];
                    txtbUsername.Focus();

                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uctrlPersonFind1.Focus();
            }


        }

        private void txtbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbUsername.Text))
            {
                errorProvider1.SetError(txtbUsername, "Username Can not be blank");
                e.Cancel= true;
            }
            else
            {
                if (clsUser.Exists(txtbUsername.Text.Trim()))
                {
                    errorProvider1.SetError(txtbUsername, "username is used by another user");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtbUsername, null);
                    txtbPassword.Focus();
                }
               
            }
        }
        private void txtbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbPassword.Text))
            {
                errorProvider1.SetError(txtbPassword, "Password Can not be blank");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtbPassword, null);
                txtbConfirmPassword.Focus();
            }
        }
        private void txtbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            
            if (txtbConfirmPassword.Text != txtbPassword.Text)
            {
                errorProvider1.SetError(txtbConfirmPassword, "Password Confirmation does not match Password ");
               e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtbConfirmPassword, null);
                chkbIsActive.Focus();
            }
        }
        private void chkbIsActive_CheckedChanged(object sender, EventArgs e)
        {
                chkbIsActive.Text = chkbIsActive.Checked? "Yes": "No";
        }

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                user.person = uctrlPersonFind1.SelectedPerson;
                user.PersonID = uctrlPersonFind1.SelectedPerson.PersonID;
                user.Username = txtbUsername.Text;
                user.Password = txtbPassword.Text;
                user.IsActive = chkbIsActive.Checked;
                if (user.Save())
                {
                    MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to save data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
