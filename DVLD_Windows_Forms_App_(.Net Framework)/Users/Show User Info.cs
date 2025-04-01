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
    public partial class frmUserDetail : Form
    {
        
        clsUser user;
        public frmUserDetail(int userID)
        {
            this.user = clsUser.Find(userID);
            InitializeComponent();
         
        }
        public frmUserDetail(clsUser user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            uctrlUserInfo1.LoaductrlUserInf(user);
        }
    }
}
