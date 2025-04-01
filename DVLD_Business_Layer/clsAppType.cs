using DVLD_Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisnes_Laye
{
    public class clsAppType
    {
        public int    TypeID    { get; private set; } 
        public string TypeTitel { get; set; }
        public Decimal  Fee       { get; set; }

        public enum enTypeMode
        {
            AddNewMode, UpdateMode,
        }

        public enTypeMode Mode { get; set; }
        private clsAppType(int ID,string Titel, Decimal fee) 
        {
            this.TypeID = ID;
            this.TypeTitel = Titel;
            this.Fee= fee;
            this.Mode = enTypeMode.UpdateMode;


        }

        public clsAppType()
        {
            this.TypeID= -1;
            this.TypeTitel = "";
            this.Fee = 0;
            this.Mode= enTypeMode.AddNewMode;

        }
        //Find Application Typ Object  by TypeID static method
        static public clsAppType Find(int TypeID)
        {
            
            string TypeTitel = "";
            Decimal Fee = 0;
            if (clsApplicationTypes .SelectToWhereAppID(TypeID, ref TypeTitel,ref Fee))
            {
                return new clsAppType(TypeID, TypeTitel, Fee);
            }
            else
            {
                return null;
            }
        }

        private bool _Add()
        {
            this.TypeID =clsApplicationTypes.InsertTo(this.TypeTitel, this.Fee);
            if (this.TypeID!= -1)
            {
                this.Mode = enTypeMode.UpdateMode;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enTypeMode.UpdateMode:
                    return _Update();
                case enTypeMode.AddNewMode:
                    return _Add();
                default:
                    return false;
            }
        }

        private bool _Update()
        {
            return clsApplicationTypes.Updat(this.TypeID, this.TypeTitel, this.Fee);
        }
        static public DataTable GetApplicationsTypeList()
        {
            return clsApplicationTypes.SelectAll();
        }


    }
}
