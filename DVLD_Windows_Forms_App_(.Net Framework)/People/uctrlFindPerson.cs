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
    public partial class uctrlFindPerson : UserControl
    {
        public event Action <clsPerson> OnPersonFound;

        protected virtual void PersonFound(clsPerson person)
        {
            Action<clsPerson> action = this.OnPersonFound;
            if (action != null)
            {
                action(person);
            }
        }

        public clsPerson SelectedPerson 
        {
            get
            {
                return uctrlPersonCard.person;
            }
            set 
            {
                if (value==null)
                {
                    txtbValueOfFiltring.Text = string.Empty;
                }
                else
                {
                    
                    cbxFiltterby.SelectedIndex = 1;
                    txtbValueOfFiltring.Text = value.PersonID.ToString();
                }
                uctrlPersonCard.LoadInfoToCtrl(value);
            }
        }

        public bool Enabled
        {
            get
            {
                return groupBox1.Enabled;
            }
            set
            {
                groupBox1.Enabled=value;
            }
        }
        //public int PersonID {  get; set; }

        //public clsPerson person { get; private set; }
        public uctrlFindPerson()
        {
            InitializeComponent();
        }

        private void uctrlPersonFind_Load(object sender, EventArgs e)
        {
            cbxFiltterby.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
              

                switch (cbxFiltterby.SelectedIndex)
                {

                    case 0:
                        uctrlPersonCard.LoadInfoToCtrl(clsPerson.Find(txtbValueOfFiltring.Text.Trim()));
                        
                        break;
                    case 1:
                        uctrlPersonCard.LoadInfoToCtrl(clsPerson.Find(int.Parse(txtbValueOfFiltring.Text.Trim())));
                        break;
                    default:
                        
                        break;

                }
                if (uctrlPersonCard.person!=null)
                {
                    
                    PersonFound(uctrlPersonCard.person);
                }
            }
            else
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddOrEditPerson frm = new frmAddOrEditPerson();
            frm.GetBackPerson = PersonBack;
            frm.ShowDialog();
        }
       
        public void PersonBack(clsPerson person)
        {
            txtbValueOfFiltring.Text=person.NationalID;
            cbxFiltterby.SelectedIndex=0;
            uctrlPersonCard.LoadInfoToCtrl(person);
        }

        private void txtbValueOfFiltring_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
            if (cbxFiltterby.SelectedIndex == 1)
            {
                e.Handled = !clsValidation.IsDigitOrControl(e.KeyChar);
            }
           
        }

        private void cbxFiltterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbValueOfFiltring.Text=string.Empty;
            txtbValueOfFiltring.Focus();
        }

        private void txtbValueOfFiltring_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty((txtbValueOfFiltring.Text.Trim())))
            {
                errorProvider1.SetError(txtbValueOfFiltring, "This field is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtbValueOfFiltring, null);
            }
        }

        public void Focus()
        {
            txtbValueOfFiltring.Focus();
        }
    }
}
