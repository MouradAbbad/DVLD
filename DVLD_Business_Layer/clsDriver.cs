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
    public class clsDriver
    {
        public int DriverID {  get;  }
        public int Person { get; }
        public int License { get;  }
        private clsDriver(int DriverID, int Person, int License)
        {
            this.DriverID = DriverID;
            this.Person = Person;
            this.License = License;
        }
        static public int Issue(int PersonID, int LicenseID)
        {
            int DriverID = -1;
            if (clsDrivers.Insert(ref DriverID, PersonID, LicenseID))
            {
                return DriverID;
            }
            return DriverID;
        }

        static public clsDriver Fined(int LicenseID)
        {
            int DriverID=-1;
            int Person = -1;
            if (clsDrivers.GetInfo(ref DriverID, ref Person, LicenseID))
            {
                return new clsDriver(DriverID, Person, LicenseID);
            }
            else
            {
                return null;
            }
        }
        static public DataTable List()
        {
            return clsDrivers.List();

        }

        static public DataTable List(string column_name, string Value)
        {
            return clsDrivers.List(column_name, Value);

        }
    }
}
