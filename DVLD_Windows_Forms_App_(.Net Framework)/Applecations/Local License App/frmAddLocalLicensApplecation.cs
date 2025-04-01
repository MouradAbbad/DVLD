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
using static System.Net.Mime.MediaTypeNames;

namespace Driving_License_Management
{
    public partial class frmAddLocalLicensApplecation : Form
    {
        clsApplication application;
        
        public frmAddLocalLicensApplecation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddLocalLicensApplecation_Load(object sender, EventArgs e)
        {

            ApplecationDate();
            ApplecationFees();
            UserCreator();
            FillcbxLicensesClass();
            
        }
        private void FiilApplecationObject()
        {
            application = new clsApplication();
            application.ApplicationDate = DateTime.Now;
            application.PersonID = uctrlPersonFind1.SelectedPerson.PersonID;
            application.ApplicationType = 1;
            application.StatuDate = DateTime.Now;
            application.Applicationstatu = "New";
            application.ApplicationPaidFees =Convert.ToDecimal(lblApplecationFees.Text);
            //application.UserCreator= clsUser.Find(lblUserCreator.Text).UserID;
        }
        private void ApplecationDate() 
        {
            lblApplecationDate.Text = DateTime.Today.ToShortDateString();
        }
        private void ApplecationFees()
        {
            
            clsAppType type =clsAppType.Find(1);
            lblApplecationFees.Text = type.Fee.ToString();
        }
        private void UserCreator()
        {
            lblUserCreator.Text = clsUser.Find(clsDVLDAppSetting.currentuser.UserID).Username;
        }
        private void FillcbxLicensesClass()
        {
            DataTable dt = clsLicenseClass.LicenseClassList();
            if (dt.Rows.Count>0 ) 
            {
                foreach (DataRow dr in dt.Rows) 
                {
                    cbxLicensesClass.Items.Add(dr[0].ToString()+"- "+ dr[1].ToString());
                }
            }
            cbxLicensesClass.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private string GetClassName()
        {
            string input= cbxLicensesClass.SelectedItem.ToString();
            char specificChar = '-';
            int index = input.IndexOf(specificChar);
            string className = "";
            if(index !=-1)
            {
                className = input.Substring(0, index);
            }
            return className;

        }
        private int GetActiveNewLocalLicenseAppID()
        {
            
            int PersonID=uctrlPersonFind1.SelectedPerson.PersonID;
            short classID = clsLicenseClass.GetLicenseClassID(GetClassName());
            int ID =clsLocalLicenseApplecation.GetActiveAppID(PersonID, classID);
            return ID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (uctrlPersonFind1.SelectedPerson.PersonID != -1)
            {
                int ActNewLLAppID= GetActiveNewLocalLicenseAppID();
                if (ActNewLLAppID == -1)
                {
                    FiilApplecationObject();
                    int AppID = -1;
                    short ClassID= clsLicenseClass.GetLicenseClassID(GetClassName());
                    if (application.Save(ref AppID, ClassID))
                    {
                        lblDLApplecationID.Text = AppID.ToString();
                        MessageBox.Show("Add New Applecation  Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Add New Applecation failde");

                    }
                }
                else
                {
                    clsLocalLicenseApplecation localLicenseApplecation = clsLocalLicenseApplecation.Find(ActNewLLAppID);
                    clsApplication Application = clsApplication.Find(localLicenseApplecation.Application);
                    if (Application.Applicationstatu=="Completed")
                    {
                        MessageBox.Show($"The Person Already Has this License please choose d diferent  class");
                    }
                    else
                    {
                        MessageBox.Show($"The Person Already Has a Active Applecation ID: [{ActNewLLAppID}]");

                    }

                }
            }
            else
            {
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("Pleas Choos A Person !");
            }
        }

       
    }
}
