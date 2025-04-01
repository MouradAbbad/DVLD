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
    public partial class frmLicenseInfo : Form
    {
        private int _PersonID;
        private short _ClassID;

        public frmLicenseInfo(int personID, short classID)
        {
            InitializeComponent();
            _PersonID = personID;
            _ClassID = classID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
           
            uctrlLicenseInfo1.FilluctrlLicenseInfo(clsLocalLicense.Fined(_PersonID,_ClassID));
        }
    }
}
