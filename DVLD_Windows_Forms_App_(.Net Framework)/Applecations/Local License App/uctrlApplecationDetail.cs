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
    public partial class uctrlApplecationDetail : UserControl
    {
        public int AppID;

        public uctrlApplecationDetail()
        {
            InitializeComponent();
        }

        public void FilluctrlApplicationDetail()
        {
            clsApplication application = clsApplication.Find(AppID);
            if (application != null)
            {
                lblID.Text =application.ApplicationID.ToString();
                lblDate.Text =application.ApplicationDate.ToShortDateString();
                lblFees.Text =application.ApplicationPaidFees.ToString();
                lblStatu.Text=application.Applicationstatu.ToString();
                lblType.Text= clsAppType.Find(application.ApplicationType).TypeTitel;
               // lblApplicant.Text = clsPerson.GetFullName(application.PersonID);
                lblUserCreator.Text= clsUser.Find(application.UserCreator).Username;
                lblStatuDate.Text=application.StatuDate.ToShortDateString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInformatins frm = new frmPersonInformatins(AppID);
            frm.ShowDialog();
        }
    }
}
