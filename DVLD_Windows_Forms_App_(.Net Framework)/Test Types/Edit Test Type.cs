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
    public partial class frmEditTestType : Form
    {
        clsTestType _Type;
        public frmEditTestType(clsTestType.enTypeID ID)
        {
            _Type = clsTestType.Find(ID);
            InitializeComponent();
        }

        public frmEditTestType(clsTestType type)
        {
            _Type = type;
            InitializeComponent();
        }


        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            lblID.Text = ((int)_Type.ID).ToString();
            txtbTitel.Text = _Type.Titel.ToString();
            txtbDescription.Text = _Type.Description.ToString();
            txtbFees.Text = _Type.Fees.ToString();  
        } 

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _Type.Titel = txtbTitel.Text;
                _Type.Description = txtbDescription.Text;
                _Type.Fees = Convert.ToDecimal(txtbFees.Text);
                if (_Type.Save())
                {
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbTitel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbTitel.Text.Trim()))
            {
                errorProvider1.SetError(txtbTitel, "Titel can not be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtbTitel, null);
            }
        }

        private void txtbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbDescription.Text.Trim()))
            {
                errorProvider1.SetError(txtbDescription, "Description can not be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtbDescription, null);
            }
        }

        private void txtbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbFees.Text.Trim()))
            {
                errorProvider1.SetError(txtbFees, "Fee can not be empty");
                e.Cancel = true;
            }
            else
            {
                if (clsValidation.IsCurrency(txtbFees.Text.Trim()))
                {
                    errorProvider1.SetError(txtbFees, null);
                }
                else
                {
                    errorProvider1.SetError(txtbFees, "Invalid Number!");
                    e.Cancel = true;
                }

            }
        }
    }
}
