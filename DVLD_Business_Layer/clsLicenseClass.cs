using DVLD_Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisnes_Layer
{
    public class clsLicenseClass
    {
        public int LicenseClassID                {  get;  }
        public string ClassName                  {  get;  }
        public string ClassDescription           {  get;  }
        public short MinimumAllowedAge             {  get;  }
        public short ValidityLength                {  get;  }
        public decimal ClassFee                  { get;  }
       
        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, short MinimumAllowedAge, short ValidityLength, decimal ClassFee) 
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.ValidityLength = ValidityLength;
            this.ClassFee = ClassFee;
        }
        static public DataTable LicenseClassList()

        { return clsLicenseClasses.GetLicensesClassList(); }

        static public short GetLicenseClassID(string ClassName)
        {
            return clsLicenseClasses.GetLicenseClassID(ClassName);
        }

        static public string GetClassDescription(int ID)
        {
            return clsLicenseClasses.GetClassDescription(ID);
        }

        static public clsLicenseClass Find(int classID)
        {
            //int LicenseClassID
            string ClassName = "";
            string ClassDescription = "";
            short MinimumAllowedAge = 0;
            short ValidityLength = 0;
            decimal ClassFee = 0;
            if (clsLicenseClasses.GetLicenseClass(ref classID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref ValidityLength, ref ClassFee))
            {
                return new clsLicenseClass(classID, ClassName, ClassDescription, MinimumAllowedAge, ValidityLength, ClassFee);
            }
            else
            {
                return null;
            }
        }


    }
}
