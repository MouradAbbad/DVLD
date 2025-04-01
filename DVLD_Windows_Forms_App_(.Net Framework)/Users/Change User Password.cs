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
    
    public partial class frmChangeUserPassword : Form
    {
        
        private clsUser _user;
        public frmChangeUserPassword(int UserID)
        {
            this._user = clsUser.Find(UserID);
            InitializeComponent();
        }
        public frmChangeUserPassword(clsUser User)
        {
            this._user = User;
            InitializeComponent();
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
           
            uctrlUserInfo1.LoaductrlUserInf(_user);
            txtbConfirmePassword.Text = "";
            txtbCurrentPassword.Text = "";
            txtbNewPasword.Text = "";
            txtbCurrentPassword.Focus();    
        }
        

      

      

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _user.Password = txtbNewPasword.Text.Trim();
                if (_user.Save())
                {
                    MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password didn't change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmChangeUserPassword_Load(null, null);
            }
            else
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCurrentPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtbCurrentPassword, "Current password can not be blanck.");
                e.Cancel = true;
            }
            else
            {
                if (_user.Password != txtbCurrentPassword.Text.Trim())
                {
                    errorProvider1.SetError(txtbCurrentPassword, "Invalid current password.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtbCurrentPassword, null);
                }
            }
          
        }

        private void txtbNewPasword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNewPasword.Text.Trim()))
            {
                errorProvider1.SetError(txtbNewPasword, "New password can not be blanck.");
                e.Cancel = true;
            }
            else
            {
                if (String.IsNullOrEmpty(txtbNewPasword.Text.Trim()))
                {
                    errorProvider1.SetError(txtbNewPasword, "New Password can not be blank");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtbNewPasword, null);
                }
            }   

            
           
        }

        private void txtbConfirmePassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtbConfirmePassword.Text.Trim() != txtbNewPasword.Text.Trim())
            {
                errorProvider1.SetError(txtbConfirmePassword, "Confirm Password is not match the new password");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtbConfirmePassword, null);
            }
        }
    }
}
