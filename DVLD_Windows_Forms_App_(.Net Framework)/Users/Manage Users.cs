using DVLD_Buisnes_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Driving_License_Management
{
    
    public partial class frmManageUser : Form
    {
       

        private DataView dataView;
        public frmManageUser()
        {
            InitializeComponent();
        }

        private void txtValueForFiltring_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check if the pressed key is a digit or a control key(e.g., backspace)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                // If it's not a digit or control key, prevent the input

                e.Handled = true;
                

                }
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frm = new frmAddOrEditUser();
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void toolStripMenuItemUpdateUser_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            frmAddOrEditUser frm = new frmAddOrEditUser(UserID);
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            frmUserDetail frm = new frmUserDetail(UserID);
            frm.ShowDialog();
        }


        private void toolStripMenuItemDeleteUser_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvUsersList .CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion"
                                                 , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result== DialogResult.Yes)
            {
                if (clsUser.Delete(PersonID))
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManageUsers_Load(null, null);
                }
                else
                {
                    MessageBox.Show("User didn't deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("User deletion canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void toolStripMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            frmChangeUserPassword FRM = new frmChangeUserPassword(UserID);
            FRM.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            dataView = clsUser.GetAllUsersListe().DefaultView;
            dgvUsersList.DataSource = dataView;
            lblNumberOfRecord.Text = dgvUsersList.Rows.Count.ToString();
            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.Columns["FirstName"].Visible = false;
                dgvUsersList.Columns["SecondName"].Visible = false;
                dgvUsersList.Columns["ThirdName"].Visible = false;
                dgvUsersList.Columns["LastName"].Visible = false;
                dgvUsersList.Columns["PhoneNumber"].Visible = false;
                dgvUsersList.Columns["Email"].Visible = false;
                dgvUsersList.Columns["CountryName"].Visible = false;
                dgvUsersList.Columns["PersonalPhoto"].Visible = false;

                dgvUsersList.Columns["User ID"].HeaderText = "User ID";
                dgvUsersList.Columns["User ID"].Width = 130;

                dgvUsersList.Columns["Person"].HeaderText = "Person ID";
                dgvUsersList.Columns["Person"].Width = 130;

                dgvUsersList.Columns["Fullname"].HeaderText = "Full Name";
                dgvUsersList.Columns["Fullname"].Width = 130;

                dgvUsersList.Columns["Username"].HeaderText = "Username";
                dgvUsersList.Columns["Username"].Width = 130;

                dgvUsersList.Columns["Is Active"].HeaderText = "Is Active";
                dgvUsersList.Columns["Is Active"].Width = 50;
            }

            cbxFilterBy.SelectedIndex = 0;
            txtValueForFiltring.Text = string.Empty;
            txtValueForFiltring.Hide();
            cmbIsActivValues.Hide();

        }

        private void cbxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtValueForFiltring.KeyPress -= txtValueForFiltring_KeyPress;
            txtValueForFiltring.Visible = cbxFilterBy.Text != "NON" && cbxFilterBy.Text != "Is Active";
            cmbIsActivValues.Visible = cbxFilterBy.Text == "Is Active";
            if (txtValueForFiltring.Visible)
            {
                if (cbxFilterBy.Text == "Person ID" || cbxFilterBy.Text == "User ID")
                {
                    txtValueForFiltring.KeyPress += txtValueForFiltring_KeyPress;
                }
                txtValueForFiltring.Focus();
                txtValueForFiltring.Text = string.Empty;
            }
            else if (cmbIsActivValues.Visible)
            {
                cmbIsActivValues.Visible = true;
                cmbIsActivValues.SelectedIndex = 0;
                cmbIsActivValues.Focus();
            }
        }

        private void txtValueForFiltring_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbxFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "User ID";
                    break;
                case "UserName":
                    FilterColumn = "Username";
                    break;

                case "Person ID":
                    FilterColumn = "Person";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }
            if (FilterColumn == "NON" || txtValueForFiltring.Text.Trim() == "")
            {
                dataView.RowFilter = string.Empty;
            }
            else if (FilterColumn == "User ID" || FilterColumn == "Person ID")
            {
                dataView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtValueForFiltring.Text.Trim());
            }
            else
            {
                dataView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtValueForFiltring.Text.Trim());
            }

            lblNumberOfRecord.Text = dgvUsersList.Rows.Count.ToString();
        }

        private void cmbIsActivValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value;
            switch (cmbIsActivValues.Text)
            {
                case "Yes":
                    value = "1";
                    break;

                case "No":
                    value = "0";
                    break;
                default:
                    value = "All";
                    break;
            }
            if (value == "All")
            {
                dataView.RowFilter = "";
            }
            else
            {
                dataView.RowFilter = "[Is Active] = " + value.ToString();
            }

            lblNumberOfRecord.Text = dgvUsersList.Rows.Count.ToString();
        }

     
    }
}
