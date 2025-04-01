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
    public partial class frmMainMenu : Form
    {
        private frmLogin frmLogin;
        public frmMainMenu(frmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
            
        }






        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManagePeople();
            //frm.MdiParent = this;

            frm.ShowDialog();

        }

        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm if the user wants to sign out
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                clsDVLDAppSetting.currentuser = null;
                this.frmLogin.Show();
                this.Close();
            }

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUser frm = new frmManageUser();
            //frm.MdiParent = this;

            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUserDetail frm = new frmUserDetail(clsDVLDAppSetting.currentuser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm =new frmChangeUserPassword(clsDVLDAppSetting.currentuser);
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageAplicationTypes frm =new frmManageAplicationTypes();   
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();  
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLocalLicensApplecation frm    = new frmAddLocalLicensApplecation();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplecationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplecations frm = new    frmManageLocalDrivingLicenseApplecations();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers frm =new frmDrivers();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicens frm =new frmIssueInternationalLicens();
            frm.ShowDialog();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if (clsDVLDAppSetting.currentuser!=null)
            {
                  lblUsername.Text = clsDVLDAppSetting.currentuser.Username;
            }
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frmLogin.Close();
        }
    }
}


