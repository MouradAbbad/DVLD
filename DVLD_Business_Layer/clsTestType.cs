using DVLD_Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisnes_Layer
{
  
    public class clsTestType
    {
        public enum enTypeID
        {
            Vision= 1, Written = 2, Street = 3,
        }

        public enum enMode
        {
            AddNew , Update,
        }

        public enMode mode;
        public enTypeID ID { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        private clsTestType(enTypeID enTypeID, string titel, string description, decimal fees)
        {
            ID = enTypeID;
            Titel = titel;
            Description = description;
            Fees = fees;
            mode = enMode.Update;
        }

        static public clsTestType Find(enTypeID enTypeID)
        {
            string title = "";
            string description = "";
            decimal fees = 0;
            if (clsTestTypes.GetTypeInfo((int)enTypeID,ref title,ref description,ref fees))
            {
                return new clsTestType(enTypeID, title,description,fees);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetTestTypesList() 
        {
            return clsTestTypes.GetAllTestTypesList();
        }

        public bool Save()
        {
            return _Update();
        }

        private bool _Update()
        {
            return clsTestTypes.UpdateTestType((int)this.ID,this.Titel,this.Description,this.Fees);
        }
    }
}
