using DVLD_Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Buisnes_Layer
{
    public class clsLocalLicenseApplecation
    {
        public int NewLicenseApplicationID { get;  }
        public int Application { get; set; }
        public short licenseClass { get; set; }
        public short PassedTests {  get; set; }
        private clsLocalLicenseApplecation( int newLicenseApplicationID, int application, short licenseClass, short PassedTests)
        {
            this.NewLicenseApplicationID = newLicenseApplicationID;
            this.Application = application;
            this.licenseClass = licenseClass;
            this.PassedTests = PassedTests;
        }

        //Gett Detail
        static public clsLocalLicenseApplecation Find(int LDLAppID)
        {
            int app = -1;
            short Class = -1;
            short PassedTests= -1;
            if (clsLocalLicenseApplecationDataAccess.GetDetail(ref LDLAppID,ref app,ref Class,ref PassedTests))
            {

                return new clsLocalLicenseApplecation(LDLAppID,app,Class,PassedTests);

            }
            else
            {
                return null;
            }


        }
        static public clsLocalLicenseApplecation FindByMainApp(int MainApp)
        {
            int LDLAppID = -1;
            short Class = -1;
            short PassedTests = -1;
            if (clsLocalLicenseApplecationDataAccess.GetDetailByMainApp(ref LDLAppID, ref MainApp, ref Class, ref PassedTests))
            {

                return new clsLocalLicenseApplecation(LDLAppID, MainApp, Class, PassedTests);

            }
            else
            {
                return null;
            }


        }

        //Get Active New License Applecation By PersonID and License Class
        static public int GetActiveAppID(int PersonID, short LicenseClassID)
        {
            return clsLocalLicenseApplecationDataAccess.GetActiveApplecationID(PersonID, LicenseClassID);

        }

        //Get all Detail List of Local License Applecations
        static public DataTable DetailsList()
        {
            return clsLocalLicenseApplecationDataAccess.DetailsList();
        }
        //Get filtred Detail List of Local License Applecations
        static public DataTable DetailsListFilter(string FilterBy, string ValuOfFilter)
        {
            return clsLocalLicenseApplecationDataAccess.DetailsListFilterd(FilterBy,ValuOfFilter);
        }

        //Get License Class Description

        public string ClassDescription()
        {
            return clsLocalLicenseApplecationDataAccess.ClassDescription(this.NewLicenseApplicationID);
        }
        //Get Applicant Full Name
        public string ApplicantFullName()
        {
            return clsLocalLicenseApplecationDataAccess.ApplicantFullName(this.NewLicenseApplicationID);    
        }
        public int ApplicantID()
        {
            return clsLocalLicenseApplecationDataAccess.ApplicantID(this.NewLicenseApplicationID);
        }
        private bool _Update()
        {
            return clsLocalLicenseApplecationDataAccess.Update(this.NewLicenseApplicationID,this.Application,this.licenseClass,this.PassedTests);
        }
        
        static public bool IncreasPasedTest(int LDLAppID)
        {
            clsLocalLicenseApplecation localLicenseApplecation = clsLocalLicenseApplecation.Find(LDLAppID);
            localLicenseApplecation.PassedTests++;
            return localLicenseApplecation._Update();
        }

        static public bool Delete(int LDLAppID) 
        {
            int mainappID = clsLocalLicenseApplecation.Find(LDLAppID).Application;
            if (clsLocalLicenseApplecationDataAccess.Delete(LDLAppID))
            {
                return clsApplication.Delete(mainappID);
            }
            else 
            {
                return false;
            }
        }

       
            

        
    }
}
