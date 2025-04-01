using DVLD_Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisnes_Layer
{
    public class clsTest
    {
        public int TestID { get; }
        public int AppointmentID { get; }
        public short Score { get; set; }
        public bool IsPassed { get; set; }

        private clsTest( int appointmentID)
        {
            AppointmentID = appointmentID;
            Score = -1;
        }
        static public clsTest Take(int appointmentID)
        {
            clsTestApointment TestApointment= clsTestApointment.Find(appointmentID);
            if (TestApointment!=null && !TestApointment.Looked)
            {
                return new clsTest(appointmentID);
            }
            return null;
        }
        private int _SetTestResult()
        {
          
            int testID = clsTests.Insert(this.AppointmentID,this.Score, this.IsPassed);
            if (testID != -1)
            {
                clsTestApointment.LookedAppointment(AppointmentID);
                if (this.IsPassed)
                {

                                int DLLAppID = clsTestApointment.LocalLicenseAppID(AppointmentID);
                                clsLocalLicenseApplecation.IncreasPasedTest(DLLAppID);
                }
            }
            return  testID;
        }
        //static public int _SetTestResult(int AppointmentID, bool IsPassed)
        //{

        //    int testID = clsTestsDataAccess.Insert(AppointmentID, IsPassed);
        //    if (testID != -1)
        //    {
        //        clsTestApointment.LookedAppointment(AppointmentID);
        //        if (IsPassed)
        //        {
                  
        //            int DLLAppID = clsTestApointment.LocalLicenseAppID(AppointmentID);
        //            clsLocalLicenseApplecation.IncreasPasedTest(DLLAppID);
        //        }
        //    }
        //    return testID;
        //}

        public bool Save(ref int TestID)
        {
            TestID = _SetTestResult();
            return TestID !=-1 ;
        }
    }
}
