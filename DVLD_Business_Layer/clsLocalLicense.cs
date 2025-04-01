using DVLD_Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisnes_Layer
{
    public class clsLocalLicense
    {
        public int LicenseID { get; }
        public short Class { get; }
        public DateTime IssuanceDate { get; }
        public DateTime ExpiryDate { get; }
        public string Conditions { get; }
        public string Statu { get; }
        public bool isActive { get; }
        public int driverID { get; }

        public int personID { get; }

        private clsLocalLicense(int Licenseid, short LicenseClass, DateTime IssuanceDate, DateTime ExpiryDate, string Conditions, string Statu
            , bool isactive,int driverID, int personID)
        {
            this.LicenseID = Licenseid;
            this.Class = LicenseClass;
            this.IssuanceDate = IssuanceDate;
            this.ExpiryDate = ExpiryDate;
            this.Conditions = Conditions;
            this.Statu = Statu;
            this.isActive = isactive;
            this.driverID = driverID;
            this.personID = personID;
        }


        static public DateTime ExpiryDateFromToDay(int LicenseClass)
        {


            short ValidityLength = clsLicenseClass.Find(LicenseClass).ValidityLength;
            DateTime ExpiryDate = DateTime.Today.AddYears(ValidityLength);
            return ExpiryDate;
        }

        static public int Issue(int LDLAppID, string Conditions, string Statue)
        {
            int licenseID = -1;
            clsLocalLicenseApplecation LDLApplecation = clsLocalLicenseApplecation.Find(LDLAppID);
            if (LDLApplecation.PassedTests == 3)
            {
                clsApplication application = clsApplication.Find(LDLApplecation.Application);
                if (clsLocalLicenses.Insert( ref licenseID, LDLApplecation.licenseClass, DateTime.Today
                   , ExpiryDateFromToDay(LDLApplecation.licenseClass), Conditions, Statue))
                {
                    int driverID = clsDriver.Issue(application.PersonID, licenseID);
                    if (driverID != -1)
                    {
                        application.Applicationstatu = "Completed";
                        application.StatuDate = DateTime.Today;
                        int appID = application.ApplicationID;
                        if (application.Save(ref appID))
                        {
                            return licenseID;
                        }
                    }
                }
            }
            return -1;
        }

        static public clsLocalLicense Fined(int PersonID, short LicenseClass)
        {
            int LicenseID = -1;

            DateTime IssuanceDate = DateTime.Today;
            DateTime ExpiryDate = DateTime.Today;
            string Conditions = "";
            string Statu = "";
            bool isactiv = false;
            int driverID = -1;
            
            if (clsLocalLicenses.GetInfo(PersonID, LicenseClass, ref LicenseID, ref IssuanceDate, ref ExpiryDate, ref Conditions
                , ref Statu, ref isactiv,ref driverID))
            {
                return new clsLocalLicense(LicenseID, LicenseClass, IssuanceDate, ExpiryDate, Conditions, Statu, isactiv, driverID, PersonID);
            }
            else
            {
                return null;
            }
        }
        static public clsLocalLicense Fined(int LicenseID)
        {
            short LicenseClass = -1;

            DateTime IssuanceDate = DateTime.Today;
            DateTime ExpiryDate = DateTime.Today;
            string Conditions = "";
            string Statu = "";
            bool isactiv = false;
            int driverID = -1;
            int persoonID = -1;
            if (clsLocalLicenses.GetInfo( LicenseID,ref driverID,ref persoonID,ref LicenseClass, ref IssuanceDate, ref ExpiryDate, ref Conditions
                , ref Statu, ref isactiv))
            {
                return new clsLocalLicense(LicenseID, LicenseClass, IssuanceDate, ExpiryDate, Conditions, Statu, isactiv,driverID,persoonID);
            }
            else
            {
                return null;
            }
        }
        public bool IsExpird()
        {
            return this.ExpiryDate > DateTime.Today;
        }
        static public DataTable LDLicensesList(int personID)
        {
            return clsLocalLicenses.LDLicensesList(personID);
        }

        //static public int OwnerID(int Licence)
        //{
        //    return clsDriver.Fined(Licence).Person;
        //}

        static public bool HasActiveNationalLicences(int locallicences)
        {
            return clsInternationalLicens.GetActiveLicens(locallicences)!= null;
        }
        public bool HasActiveNationalLicences()
        {
            return clsInternationalLicens.GetActiveLicens(this.LicenseID) != null;
        }
    }

}
