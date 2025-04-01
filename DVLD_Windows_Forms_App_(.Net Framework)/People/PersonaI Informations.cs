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
    public partial class frmPersonInformatins : Form
    {

        clsPerson person;
        public frmPersonInformatins( int personID)
        {
            InitializeComponent();
            person = clsPerson.Find(personID);
        }
        public frmPersonInformatins(clsPerson person)
        {
            InitializeComponent();
            this.person = person ;
        }
        private void frmPersonInformatins_Load(object sender, EventArgs e)
        {
            ctrlPersonInformation1.LoadInfoToCtrl(person);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
