using DVLD_Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisnes_Layer
{
    public class clsTestApointment
    {
        enum enMode
        {
            AddNewMode , UpdateMode
        }
        public int      AppointmentID { get; }
        public int      Application { get; }
        public int      TestType { get; }
        public DateTime Date { get; set; }
        public decimal  PaidFee { get; set; }
       
        public bool     Looked { get; set; }

        //public int MainAppointementID { get;  }



        enMode Mode;


        //Place Test Appointment
        private  clsTestApointment(int Application,int TestType)
        {
            Mode = enMode.AddNewMode;
            this.Application = Application;
            this.TestType = TestType;
            this.AppointmentID = -1;
          //  this.MainAppointementID = -1;
           
        }
        //retake Test Appointment
        //private  clsTestApointment(int MainApp)
        //{
        //    Mode = enMode.AddNewMode;
        //    this.MainAppointementID = MainAppointementID;
            
        //}
        // Appointment info


        private clsTestApointment(int AppointmentID, int Application, int TestType, DateTime Date, decimal PaidFee, bool Looked)
        {

            this.AppointmentID  =AppointmentID                        ;
            this.Application    =Application                          ;
            this.TestType       =TestType                             ;
            this.Date           =Date                                 ;
            this.PaidFee        =PaidFee                              ;
           
            this.Looked         = Looked;
            Mode=enMode.UpdateMode ;

                //int      AppointmentID
                //int      Application 
                //int      TestType 
                //DateTime Date 
                //decimal  PaidFee 
                //short    Score 
                //bool     ResultIsPassed
                //bool     Looked 

        }
        private bool _Add(ref int AppointmentID)
        {
            //int MainAppoi = FirstAppointment(this.Application);

            //if (MainAppoi ==-1)
            //{
                
               return clsTestsAppointments.Insert( ref AppointmentID,this.Application, this.TestType, this.Date, this.PaidFee,this.Looked/*,this.MainAppointementID*/);

            //}
            //else
            //{
            //    this.Application = -1;
            //    this.TestType = -1;
            //    return clsTestsAppointmentsDataAccess.Insert(ref AppointmentID, this.Application, this.TestType, this.Date, this.PaidFee, this.Looked/*, this.MainAppointementID*/);
            //}
        }
        private bool _Add()
        {
            //int MainAppoi = FirstAppointment(this.Application);

            //if (MainAppoi == -1)
                return clsTestsAppointments.Insert( this.Application, this.TestType, this.Date, this.PaidFee, this.Looked/*,this.MainAppointementID*/);
            //else
            //{
            //    this.Application = -1;
            //    this.TestType = -1;
            //    return clsTestsAppointmentsDataAccess.Insert(this.Application, this.TestType, this.Date, this.PaidFee, this.Looked/*,this.MainAppointementID*/);

            //}
        }
        private bool _Update()
        {
            return clsTestsAppointments.Update(this.AppointmentID, this.Application, this.TestType, this.Date, this.PaidFee,this.Looked);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewMode:
                    if (_Add())
                    {
                        Mode = enMode.UpdateMode;
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
        public bool Save(ref int AppointmentID)
        {
            switch (Mode) 
            { case enMode.AddNewMode:
                    if (_Add(ref AppointmentID))
                    {
                        Mode= enMode.UpdateMode;
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

        static public DataTable List(int AppID, int TestType)
        {
            return clsTestsAppointments.List(AppID, TestType);
        }

        static public int ActiveAppointment(int AppID)
        {
            return clsTestsAppointments.ActiveAppointment(AppID);
        }

        static public int FirstAppointment(int AppID, int TestType)
        {
            return clsTestsAppointments.FirstAppointment(AppID, TestType);
        }

        public  int FirstAppointment()
        {
            return clsTestsAppointments.FirstAppointment(this.Application,this.TestType);
        }

        public bool IsTheFirst()
        {
            int firstAppoi = this.FirstAppointment();
            if (firstAppoi !=-1)
            {
                return this.AppointmentID == firstAppoi;
            }
            else
            {
                return true;
            }
        }

        static public clsTestApointment Place(int AppID)
        {

            int ActAppoi = ActiveAppointment(AppID);
            if (ActAppoi==-1) 
            {
                //int MainAppoiID = MainAppointment(AppID);
                //if (MainAppoiID != -1)
                //{
                //    return new clsTestApointment(MainAppoiID);
                //}
                //else
                //{
                //    clsTestApointment testApointment= new clsTestApointment();
                //    testApointment.Application = AppID;
                //    return testApointment;
                //}
                int TestType = clsLocalLicenseApplecation.FindByMainApp(AppID).PassedTests+1;
                return new clsTestApointment(AppID,TestType);
            }
            else
            {
                return null;
            }
           
            
        }

        static public clsTestApointment Find(int AppointmentID)
        {
            //int AppointmentID
            int Application = -1;
            int TestType = -1;
            DateTime Date= DateTime.Now;
            decimal PaidFee = 0;
           
            
            bool Looked=false;

            if (clsTestsAppointments.GetRecordData (AppointmentID,ref Application,ref TestType,ref Date, ref PaidFee, ref Looked))
            {

                return new clsTestApointment(AppointmentID, Application, TestType, Date, PaidFee, Looked);


            }
            else
            {
                return null;
            }
        }
        static public bool LookedAppointment(int AppointmentID)
        {
            clsTestApointment apointment = clsTestApointment.Find(AppointmentID);
            apointment.Looked= true;
            return apointment.Save();
        }

        static public int LocalLicenseAppID(int AppointmentID)
        {
            return clsTestsAppointments.GetDLLAppID(AppointmentID);
        }



    }
}