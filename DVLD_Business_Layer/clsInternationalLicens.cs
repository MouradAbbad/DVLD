using DVLD_Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_Buisnes_Layer
{
    public class clsInternationalLicens
    {
        public int InternationalID { get; private set; }
        public int License { get; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool isActive { get; set; }

       
        private clsInternationalLicens(clsLocalLicense localLicense)
        {
            this.InternationalID=-1; 
            this.License = localLicense.LicenseID;
            this.IssuanceDate = DateTime.Today;
            this.ExpiryDate = DateTime.Today.AddYears(1)>localLicense.ExpiryDate? localLicense.ExpiryDate: DateTime.Today.AddYears(1);
            this.isActive = true;
        }
        private clsInternationalLicens(int InternationalID, int License, DateTime IssuanceDate, DateTime ExpiryDate, bool isActive)
        {
            this.InternationalID = InternationalID;
            this.License = License;
            this.IssuanceDate = IssuanceDate;
            this.ExpiryDate = ExpiryDate;
            this.isActive = isActive;
        }
        static public clsInternationalLicens Issue(clsLocalLicense localLicense)
        {
            if (localLicense != null)
            {
                if (localLicense.isActive && localLicense.Class==3)
                {
                    return new clsInternationalLicens(localLicense);
                }
                
            }
           
            
            return null;
            
        }
        
        public bool Save(ref int InternationalID)
        {

            return clsInternationalLicenses.Insert(ref InternationalID, this.License, this.IssuanceDate, this.ExpiryDate);
           
        }

        static public clsInternationalLicens Find(int InternationalID, ref int DriverID, ref bool isActive, ref string NationalID
            , ref string Name, ref DateTime DateofBirth, ref bool Gender, ref string PersonalPhoto)
        {

            int License = -1;
            DateTime IssuanceDate = DateTime.Today;
            DateTime ExpiryDate = DateTime.Today;

            if (clsInternationalLicenses.GetDetailsInfo(InternationalID, ref License, ref DriverID, ref IssuanceDate, ref ExpiryDate
            , ref isActive, ref NationalID, ref Name, ref DateofBirth, ref Gender, ref PersonalPhoto))
            {

                return new clsInternationalLicens(InternationalID, License, IssuanceDate, ExpiryDate,isActive);
            }
            else
            {
                return null;
            }
        }

        static public clsInternationalLicens GetActiveLicens(int locallicences)
        {
            int intenationalID = -1;
            DateTime issueDate = DateTime.Today;
            DateTime expiryDate = DateTime.Today;
            bool isActive = false;
            if (clsInternationalLicenses.SelectToWhere(ref intenationalID, locallicences, ref issueDate, ref expiryDate,ref isActive))
            {
                return new clsInternationalLicens(intenationalID,locallicences,issueDate,expiryDate,isActive);
            }
            else
            {
                return null ;
            }
        }

        //private bool _AddNew()
        //{
        //    return clsInternationalLicenses.Insert(ref this.InternationalID, this.License, this.IssuanceDate, this.ExpiryDate);
        //}
        
    }
}
