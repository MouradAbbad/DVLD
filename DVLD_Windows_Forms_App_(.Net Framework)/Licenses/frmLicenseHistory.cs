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
    public partial class frmLicenseHistory : Form
    {
        private string _nationalID;
        public frmLicenseHistory(string nationalID)
        {
            InitializeComponent();
            this._nationalID = nationalID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
           // uctrlPersonFind1.PersonBack(_nationalID);
            uctrlPersonFind1.Enabled = false;
            FillLocalLicensesHistory();


        }

        private void FillLocalLicensesHistory()
        {
            dgvLocalLicenses.DataSource = clsLocalLicense.LDLicensesList(uctrlPersonFind1.SelectedPerson.PersonID);
            lblRecordsLocalLicenses.Text= dgvLocalLicenses.RowCount.ToString();
        }

   
    }
}
