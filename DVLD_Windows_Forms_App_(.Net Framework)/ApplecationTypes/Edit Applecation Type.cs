using DVLD_Buisnes_Laye;
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
    public partial class frmEditApplecationType : Form
    {
      
        private clsAppType _type;
        public frmEditApplecationType(int ID)
        {
            _type =clsAppType.Find(ID);
            InitializeComponent();
          

        }
        public frmEditApplecationType(clsAppType appType)
        {
            _type = appType;
            InitializeComponent();
            

        }

        private void frmEditApplecationType_Load(object sender, EventArgs e)
        {
            
            lblID.Text = _type.TypeID.ToString();
            txtbTitel.Text = _type.TypeTitel;
            txtbFees.Text= _type.Fee.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _type.TypeTitel = txtbTitel.Text;
                _type.Fee = Convert.ToDecimal(txtbFees.Text);
                if (_type.Save())
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtbTitel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbTitel.Text.Trim()))
            {
                errorProvider1.SetError(txtbTitel, "Titel can not be empty");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtbTitel, null);
            }
        }

        private void txtbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbFees.Text.Trim()))
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
                    errorProvider1.SetError(txtbFees, "Invalid Number.");
                    e.Cancel = true;
                }

            }
        }
    }
}
