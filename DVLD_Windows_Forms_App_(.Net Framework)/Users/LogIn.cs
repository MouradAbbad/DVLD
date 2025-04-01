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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Driving_License_Management
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            
        }
        private void LoadCredentials()
        {
            string username = "";
            string password = "";
            if (clsDVLDAppSetting.Cardinality(ref username, ref password))
            {
                txtbUsername.Text = username;
                txtbPassword.Text = password;
                chkbRememberMe.Checked = true; // Automatically check the "Remember Me" checkbox
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (clsDVLDAppSetting.IsValidLogin(txtbUsername.Text.Trim(),txtbPassword.Text.Trim()))
            {
                if (clsDVLDAppSetting.currentuser.IsActive)
                {
                   
                    if (chkbRememberMe.Checked)
                    {
                        clsDVLDAppSetting. SaveCredentials(txtbUsername.Text.Trim(), txtbPassword.Text.Trim());
                    }
                    else
                    {
                        // Clear stored credentials if "Remember Me" is unchecked
                        clsDVLDAppSetting. ClearCredentials();
                    }
                    this.Hide();
                    frmMainMenu frm = new frmMainMenu(this);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your account not active pleas contact your admin");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadCredentials();
        }
    }
}
