using DVLD_Buisnes_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Driving_License_Management
{
    public partial class frmManagePeople : Form
    {
        static DataTable dtpeople = clsPerson.GetPeopleListe();

        DataView dataView = dtpeople.DefaultView;

        private void RefreshPeoplList()
        {
            dtpeople = clsPerson.GetPeopleListe();
            dataView = dtpeople.DefaultView;
            dgvPeopleList.DataSource = dataView;
            lblRecordsCount.Text = dgvPeopleList.Rows.Count.ToString();
        }
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            dgvPeopleList.DataSource = dataView;
            cbxFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text= dgvPeopleList.Rows.Count.ToString();
            if (dgvPeopleList.Rows.Count>0)
            {
                dgvPeopleList.Columns[0].HeaderText = "Person ID";
                dgvPeopleList.Columns[0].Width = 104;
                dgvPeopleList.Columns[1].HeaderText = "National ID";
                dgvPeopleList.Columns[1].Width = 117;
                dgvPeopleList.Columns[2].HeaderText = "First Name";
                dgvPeopleList.Columns[2].Width = 113;
                dgvPeopleList.Columns[3].HeaderText = "Last Name";
                dgvPeopleList.Columns[3].Width = 113;
                dgvPeopleList.Columns[4].HeaderText = "Gender";
                dgvPeopleList.Columns[4].Width = 70;
                dgvPeopleList.Columns[5].HeaderText = "Date of birth";
                dgvPeopleList.Columns[6].HeaderText = "Nationality";
                dgvPeopleList.Columns[6].Width = 110;
                dgvPeopleList.Columns[7].HeaderText = "Phone Number";
            }

        }

        private void txtValueForFiltring_TextChanged(object sender, EventArgs e)
        {
            if (cbxFilterBy.SelectedItem.ToString() == "NON" || string.IsNullOrWhiteSpace(txtValueForFiltring.Text.Trim()))
            {
                dataView.RowFilter = string.Empty;
            }
            else if (cbxFilterBy.SelectedItem.ToString() == "Person ID")
            {
                dataView.RowFilter = $"PersonID = {txtValueForFiltring.Text.Trim()}";
            }
            else
            {
                dataView.RowFilter = $"{cbxFilterBy.Text.Trim().Replace(" ", "")} Like '{txtValueForFiltring.Text.Trim()}%'";
            }
            
            dgvPeopleList.DataSource = dataView;
            lblRecordsCount.Text = dgvPeopleList.Rows.Count.ToString();
        }

        private void cbxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValueForFiltring.Visible = (cbxFilterBy.SelectedIndex != 0);
            
            txtValueForFiltring.KeyPress -= txtValueForFiltring_KeyPress;
            if (txtValueForFiltring.Visible)
            {
                txtValueForFiltring.Text = string.Empty;
                if (cbxFilterBy.SelectedItem.ToString() == "Person ID")
                {
                    txtValueForFiltring.KeyPress += txtValueForFiltring_KeyPress;
                }
                txtValueForFiltring.Focus();
            }


        }
      

        private void txtValueForFiltring_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!clsValidation.IsDigitOrControl(e.KeyChar))
            {
                // If it's not a digit or control key, prevent the input
                    e.Handled = true;
            }
        }
        

        private void AddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddOrEditPerson frm = new frmAddOrEditPerson();
            frm.ShowDialog();
            
            RefreshPeoplList();
        }
        private void toolStripMenuItemShowDetails_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;
            Form frm = new frmPersonInformatins(personID);
            frm.ShowDialog();
            RefreshPeoplList();
        }
     
        private void toolStripMenuItemEditePersonInfo_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;
            Form frm = new frmAddOrEditPerson(personID);
            frm.ShowDialog();
            RefreshPeoplList();
            
        }
        private void toolStripMenuItemDeletePerson_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvPeopleList.CurrentRow.Cells[0].Value;
            if ((MessageBox.Show($"Are you sure you want to delete Person [{personID}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                clsPerson person = clsPerson.Find(personID);
                string personalPhotoPath = person.PersonalPhoto;
                if (person.Delete())
                {
                    if (!string.IsNullOrEmpty(personalPhotoPath))
                    {
                        File.Delete(personalPhotoPath);
                    }
                    MessageBox.Show("Person deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPeoplList();

                }
                else
                {
                    MessageBox.Show("Cannot delete this person because they have related Data.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
          

           
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeopleList_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the row index at the current mouse position
            DataGridView.HitTestInfo hit = dgvPeopleList.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0 && hit.RowIndex < dgvPeopleList.Rows.Count) // Ensure it's a valid row
            {
                // Check if the current row is already selected to avoid unnecessary operations
                if (dgvPeopleList.CurrentRow == null || dgvPeopleList.CurrentRow.Index != hit.RowIndex)
                {
                    dgvPeopleList.ClearSelection(); // Clear previous selection
                    dgvPeopleList.Rows[hit.RowIndex].Selected = true; // Select the new row
                    dgvPeopleList.CurrentCell = dgvPeopleList.Rows[hit.RowIndex].Cells[0]; // Change current row
                }
            }
        }
    }
}
