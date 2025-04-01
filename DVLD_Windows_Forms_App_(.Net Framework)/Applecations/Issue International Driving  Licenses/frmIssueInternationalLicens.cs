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
    public partial class frmIssueInternationalLicens : Form
    {
        
        clsLocalLicense localLicence;
        
        int intLicensID;
        clsInternationalLicens InternationalLicense;
        clsApplication application;
        public frmIssueInternationalLicens()
        {
            InitializeComponent();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void Application()
        //{
        //    application = new clsApplication();
        //    // application.ApplicationID
        //    application.ApplicationDate = DateTime.Today;

        //    //application.PersonID = uctrlLicenseInfo1.personID;
        //    application.ApplicationType = 7;
        //    application.Applicationstatu = "New";
        //    application.ApplicationPaidFees = Convert.ToDecimal(lblFees.Text);
        //    application.UserCreator = clsDVLDAppSetting.CurrentUserID;
        //}
        private void frmInternationalLicens_Load(object sender, EventArgs e)
        {
            lklablLicenseInfo.Enabled = false;
          
            lblAppDate.Text= DateTime.Today.ToShortDateString();
    
            
            
            lblIssueDate.Text= DateTime.Today.ToShortDateString();
            lblFees.Text = clsAppType.Find(7).Fee.ToString(); 
            lblExpDate.Text= DateTime.Today.AddYears(1).ToShortDateString();
            lblCreatedBy.Text =clsUser.Find( clsDVLDAppSetting.currentuser.UserID).Username .ToString();

        }
        private void FillInterLicenseObject()
        {
            InternationalLicense.IssuanceDate= DateTime.Today;
            InternationalLicense.ExpiryDate = DateTime.Today.AddYears(1);
        }
        
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (localLicence!=null)
            {
                application = clsApplication.IssueInternationalLicence(localLicence, clsDVLDAppSetting.currentuser.UserID);
                if (application!= null)
                {
                    if (application.Save())
                    {
                        InternationalLicense = clsInternationalLicens.Issue(localLicence);
                        if (InternationalLicense!= null)
                        {
                            
                        }
                    }
                   
                }
            }
           
            
            
            
                //Application();
                //FillInterLicenseObject();
                //int appID = -1;
                //if (application.Save(ref appID))
                //{
                    
                //    if (InternationalLicense.Save(ref intLicensID))
                //    {
                //        MessageBox.Show($"International License Issued successfuly with License ID:[{intLicensID}]");
                //        lklablLicenseInfo.Enabled = true;
                //        application =clsApplication.Find(appID);
                //        application.Applicationstatu = "Completed";
                //        if (application.Save(ref appID))
                //        {
                //            MessageBox.Show($"Applecation completed successfuly");
                //        }
                //        else
                //        {
                //            MessageBox.Show($"Applecation completed faild");
                //        }

                //    }
                //    else
                //    {
                //        MessageBox.Show($"Issue International License  Failed License");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show($"Issue International License Application Failed ");
                //}

           
        }

        private void lklablLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalDrivingLicense frm = new frmInternationalDrivingLicense(intLicensID);
            frm.ShowDialog();
        }

        private void lklblLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string InternationalNO= clsPerson.Find(application.PersonID).NationalID;
            frmLicenseHistory frm = new frmLicenseHistory(InternationalNO);
            frm.ShowDialog();
        }
        private void uctrlFindLicense1_onLicenssFind(clsLocalLicense obj)
        {
            localLicence = obj;
           
            if (localLicence != null)
            {
                lblLLicenseID.Text = localLicence.LicenseID.ToString();
                if (localLicence.isActive )
                {
                    if (localLicence.Class == 3)
                    {
                        if (localLicence.HasActiveNationalLicences())
                        {
                            MessageBox.Show("Person with this license already has an active international license",
                                            "License Alert",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            btnIssue.Enabled = false;
                            localLicence=null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Only a third-class license can be an international license.",
                                         "License Restriction",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        localLicence=null;
                        uctrlFindLicense1.Clear();
                        
                    }

                }
                else 
                {
                    MessageBox.Show("The license is not active.",
                                    "License Status",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    btnIssue.Enabled = false;
                    localLicence=null;
                }
                
            }
        

        }

        
    }
}