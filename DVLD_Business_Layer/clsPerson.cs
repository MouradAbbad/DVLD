using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DVLD_Data_Acces_Layer;

namespace DVLD_Buisnes_Layer
{
    public class clsPerson
    {
        public enum enPersonMode
        {
            AddNewMode, UpdateMode
        }
        //Field AND Properties
        public int      PersonID { get; private set; }
        public string   NationalID { get; set; }
        public string   FirstName { get; set; }
        public string   SecondName { get; set; }
        public string   ThirdName { get; set; }
        public string   LastName { get; set; }
        public bool     gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string   Address { get; set; }
        public string   PhoneNumber { get; set; }
        public string   Email { get; set; }
        public int      Nationality { get; set; }
        public string   PersonalPhoto { get; set; }
        public enPersonMode Mode { get; private set; }

        public clsCountry Country { get; private set; }

       
 
        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalID = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.gender = true;
            this.DateofBirth = DateTime.Now;
            this.Address = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.Nationality = -1;
            this.PersonalPhoto = "";
            this.Mode = enPersonMode.AddNewMode;
            this.Country=null;
        }


        private clsPerson(int PersonID, string NationalID, string FirstName, string SecondName, string ThirdName
            , string LastName, bool gender, DateTime DateofBirth, string Address, string PhoneNumber, string Email
            , int Nationality, string PersonalPhoto)
        {
            this.PersonID = PersonID;
            this.NationalID = NationalID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.gender = gender;
            this.DateofBirth = DateofBirth;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Nationality = Nationality;
            this.PersonalPhoto = PersonalPhoto;
            this.Mode = enPersonMode.UpdateMode;
            this.Country = clsCountry.Find(Nationality);

        }


        private bool _Add()
        {
             this.PersonID = clsPeople.InsertPersonAndGetID(this.NationalID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.gender, this.DateofBirth
                  , this.Address, this.PhoneNumber, this.Email, this.Nationality, this.PersonalPhoto);
             if (this.PersonID != -1)
             {
                 this.Country= clsCountry.Find(this.Nationality);
                 this.Mode |= enPersonMode.UpdateMode;
                return true;
             }
             else
             {
                 return false;
             }
        }
        //Update Person info Method
        private bool _Update()
        {


            return clsPeople.UpdatePersonInfo(this.PersonID, this.NationalID, this.FirstName
                , this.SecondName, this.ThirdName, this.LastName, this.gender, this.DateofBirth, this.Address
                , this.PhoneNumber, this.PersonalPhoto, this.Email, this.Nationality);


        }

        //Find Person Method By National ID
        static public clsPerson Find(string NationalID)
        {
            int PersonID           = -1;    
            
            string   FirstName     ="";
            string   SecondName    ="";
            string   ThirdName     ="";
            string   LastName      ="";
            bool     gender        = true;
            DateTime DateofBirth   =DateTime.Now;
            string   Address       ="";
            string   PhoneNumber   ="";
            string   Email         ="";
            int      Nationality   =-1;
            string   PersonalPhoto   = "";

            if (clsPeople.GetPersonInfoByNationalID(ref PersonID, NationalID, ref FirstName, ref SecondName
                , ref ThirdName, ref LastName,ref gender, ref DateofBirth, ref Address, ref PhoneNumber, ref Email, ref Nationality
                , ref PersonalPhoto))
            {
                return new clsPerson(PersonID, NationalID, FirstName, SecondName, ThirdName, LastName,gender, DateofBirth
                    , Address, PhoneNumber, Email, Nationality, PersonalPhoto);
            }
            else
            {
                return null;
            }
        }

        //Find Person Method overload By Person ID
        static public clsPerson Find(int PersonID)
        {
            string NationalID = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            bool gender = true;
            DateTime DateofBirth = DateTime.Now;
            string Address = "";
            string PhoneNumber = "";
            string Email = "";
            int Nationality = -1;
            string PersonalPhoto = "";

            if (clsPeople.GetPersonInfoByID( PersonID, ref NationalID, ref FirstName, ref SecondName
                , ref ThirdName, ref LastName, ref gender, ref DateofBirth, ref Address, ref PhoneNumber, ref Email, ref Nationality
                , ref PersonalPhoto))
            {
                return new clsPerson(PersonID, NationalID, FirstName, SecondName, ThirdName, LastName, gender, DateofBirth
                    , Address, PhoneNumber, Email, Nationality, PersonalPhoto);
            }
            else
            {
                return null;
            }
        }

      


        //Save By Mode 
        public bool Save()
        {
            switch (this.Mode)
            {
                    case enPersonMode.AddNewMode:
                    return _Add(); ;

                    case enPersonMode.UpdateMode:
                    return _Update();

                    default:
                    return false;
            }
            
        }

        //Get All People info
        static public DataTable GetPeopleListe()
        {
            return clsPeople.GetAllPeopleInfo();
        }

        //Is Person Exists method 
        static public bool IsExists(string nationalID)
        {
            return clsPeople.IsPersonExists(nationalID);
        }
        static public bool IsExists(int PersonID)
        {
            return clsPeople.IsPersonExists(PersonID);
        }
        //public bool IsExists()
        //{
        //    return IsExists(this.NationalID);
        //}
        
        //Delet Person  Method
        //static public bool Delete(string NationalID)
        //{
        //    if (IsExists(NationalID))
        //    {
        //        return clsPeople.Delete(NationalID);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool Delete()
        {
            return clsPeople.Delete(this.PersonID);
        }
       
        //Get All People info with filtter
        
        
        public string FullName()
        {
            string fullname = "";
            fullname = this.FirstName + " ";
            fullname += String.IsNullOrWhiteSpace(this.SecondName)? string.Empty: this.SecondName+ " ";
            fullname += String.IsNullOrWhiteSpace(this.ThirdName) ? string.Empty : this.ThirdName + " ";
            fullname += this.LastName;

            return fullname;

        }
    }
}
