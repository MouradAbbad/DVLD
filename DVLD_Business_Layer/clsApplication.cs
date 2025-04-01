using DVLD_Buisnes_Laye;
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
    public class clsApplication
    {

        //Application fields and prperties get set
        enum enMode
        {
            AddNewMode, UpdateMode
        }
        public int ApplicationID { get; private set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime StatuDate { get; set; }

        public int PersonID { get; set; }
        public int ApplicationType { get; set; }
        public string Applicationstatu { get; set; }
        public decimal ApplicationPaidFees { get; set; }
        public int UserCreator {  get; set; }

        private enMode Mode { get; set; }

        private clsApplication(int personID,int appType, string appStatu,int user)
        {
           this.ApplicationID = -1;
            this.PersonID = personID;
            this.ApplicationType = appType;
            this.Applicationstatu = appStatu;
            this.ApplicationDate = DateTime.Today;
            this.StatuDate = DateTime.Today;
            this.ApplicationPaidFees = clsAppType.Find(appType).Fee;  
            this.UserCreator = user;
            Mode = enMode.AddNewMode;
        }
        public clsApplication()
        {

            Mode = enMode.AddNewMode;
        }

        //Private contractor for build a full object
        private clsApplication(int ApplicationID, DateTime ApplicationDate, int PersonID, int ApplicationType, DateTime StatuDate, string Applicationstatu, decimal ApplicationPaidFees, int userCreator)
        {

            this.ApplicationID = ApplicationID;
            this.ApplicationDate = ApplicationDate;
            this.PersonID = PersonID;
            this.ApplicationType = ApplicationType;
            this.StatuDate = StatuDate;
            this.Applicationstatu = Applicationstatu;
            this.ApplicationPaidFees = ApplicationPaidFees;
            Mode = enMode.UpdateMode;
            UserCreator = userCreator;
        }

        private clsApplication( int PersonID, int ApplicationType, DateTime StatuDate, string Applicationstatu, decimal ApplicationPaidFees, int userCreator)
        {

            this.ApplicationID = ApplicationID;
            this.ApplicationDate = ApplicationDate;
            this.PersonID = PersonID;
            this.ApplicationType = ApplicationType;
            this.StatuDate = StatuDate;
            this.Applicationstatu = Applicationstatu;
            this.ApplicationPaidFees = ApplicationPaidFees;
            Mode = enMode.UpdateMode;
            UserCreator = userCreator;
        }

        //Find Application Object  by ApplicationID static method
        static public clsApplication Find(int ApplicationID)
        {
            // int ApplicationID        = -1;
            DateTime ApplicationDate = DateTime.Now;
            DateTime StatuDate = DateTime.Now; 
            int PersonID = -1;
            int ApplicationType = -1;
            string Applicationstatu = "";
            decimal ApplicationPaidFees = 0;
            int UserCreator = -1;
            if (clsApplications.GetApplicationInfoByApplicationID(ref ApplicationID, ref ApplicationDate, ref PersonID
                , ref ApplicationType, ref StatuDate, ref Applicationstatu, ref ApplicationPaidFees,ref UserCreator))
            {
                return new clsApplication(ApplicationID, ApplicationDate, PersonID, ApplicationType, StatuDate, Applicationstatu, ApplicationPaidFees, UserCreator);
            }
            else
            {
                return null;
            }
        }

        //Find Applications list  by Person ID static method
        static public DataTable GetApplicationsList(int PersonID)
        {
            return clsApplications.GetApplicationsList(PersonID);
        }

        //Get All Applications list  by Person ID static method
        static public DataTable GetApplicationsList()
        {
            return clsApplications.GetApplicationsList();
        }

        //Filter requests by status.
        //Filter Applications Lists  by  status static method
        static public DataTable GetApplicationsList(string statu)
        {
            return clsApplications.GetApplicationsList(statu);
        }

        //Get Active New License Applecation By PersonID and License Class
        static public int GetActiveNewLicenseAppID(int PersonID, short LicenseClassID)
        {
            return clsLocalLicenseApplecationDataAccess.GetActiveApplecationID(PersonID, LicenseClassID);
        }

        private bool _AddNew(ref int AppID,short ClassID)
        {
            AppID = clsApplications.Insert(this.ApplicationDate, this.PersonID, this.ApplicationType
                ,this.StatuDate, this.Applicationstatu, this.ApplicationPaidFees,this.UserCreator,ClassID);
            return AppID != -1;
        }
        private bool _AddNew(ref int AppID)
        {
            AppID = clsApplications.Insert(this.ApplicationDate, this.PersonID, this.ApplicationType,this.StatuDate, this.Applicationstatu, this.ApplicationPaidFees,this.UserCreator);
            return AppID != -1;
        }

        private bool _Update()
        {

            return clsApplications.Update(this.ApplicationID,this.StatuDate,this.Applicationstatu,this.ApplicationPaidFees);


        }

        

        public bool Save(ref int AppID)
        {
            switch (this.Mode)
            { 
                case enMode.AddNewMode:
                    if (_AddNew(ref AppID))
                    {
                        this.Mode= enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.UpdateMode:
                    
                        return _Update();
            }
            return false;
        }
        public bool Save(ref int AppID, short ClassID)
        {
            switch (this.Mode)
            {
                case enMode.AddNewMode:
                    if (_AddNew(ref AppID,ClassID))
                    {
                        this.Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdateMode:

                    return _Update();
            }
            return false;
        }

        static public bool Delete(int AppID) 
        {
            return clsApplications.Delete(AppID);
        }

        private bool _AddNew( )
        {
            this.ApplicationID = clsApplications.Insert(this.ApplicationDate, this.PersonID, this.ApplicationType
                , this.StatuDate, this.Applicationstatu, this.ApplicationPaidFees, this.UserCreator);
            return this.ApplicationID != -1;
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNewMode:
                    if (_AddNew())
                    {
                        this.Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdateMode:

                    return _Update();
            }
            return false;
        }
        static public clsApplication IssueInternationalLicence(clsLocalLicense localLicence,int user)
        {
            if (localLicence.HasActiveNationalLicences() && localLicence.isActive && !localLicence.IsExpird())
            {
                return new clsApplication(localLicence.personID, 7,"New", user);
            }
            else
            {
                return null;
            }
        }
    }
}
