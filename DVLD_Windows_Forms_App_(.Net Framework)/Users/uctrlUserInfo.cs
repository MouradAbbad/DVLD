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
    public partial class uctrlUserInfo : UserControl
    {
   
        public int UserID { get; set; }
        clsUser user;
        public uctrlUserInfo()
        {
            InitializeComponent();
        }


        public void LoaductrlUserInf(clsUser user)
        {
            uctrlPersonCard.LoadInfoToCtrl(user.person);
            lblUserID.Text = user.UserID.ToString();
            LblUsername.Text = user.Username.ToString();
            lblIsActive.Text = user.IsActive ? "Yes" : "NO";
            this.user = user;
        }
    }
}
