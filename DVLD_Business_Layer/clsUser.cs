using DVLD_Data_Acces_Layer;
using System;
using System.Data;

namespace DVLD_Buisnes_Layer
{
    public class clsUser
    {
        public enum enUserMode
        {
            AddNewMode, UpdateMode
        }
        //Field AND Properties
       public int    UserID   { get; private set; }
       public int    PersonID { get; set; }
       public string Username { get; set; }
       public string Password { get; set; }
       public bool   IsActive { get; set; }

       public clsPerson person { get; set; }

        public enUserMode Mode { get; set; }

        public clsUser() 
        {
            person = new clsPerson();
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = string.Empty;
            this.Password = string.Empty;
        }

        //Private Constructor 1
        private clsUser(int PersonID, int UserID, string Username, string Password, bool IsActive)
        {
            this.UserID   = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.person   = clsPerson.Find(PersonID);
            this.Mode     = enUserMode.UpdateMode;
        }
        //Private Constructor 2
        private clsUser(clsPerson person , int UserID, string Username, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = person.PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.person = person;
            this.Mode = enUserMode.UpdateMode;
        }
        //Public Constructor 3
        private clsUser(clsPerson PersonID)
        {
            this.PersonID = person.PersonID;
            this.UserID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;
            this.person = person;
            this.Mode = enUserMode.AddNewMode;
        }



        //Create A user 
        static public clsUser CreateUser(clsPerson person)
        {
            if (clsUser.Exists(person.PersonID))
            {
                return new clsUser(person);
            }
            else
            {
                return null;
            }
        }



        //Add New User Method
        private bool _Add()
        {
            this.UserID = clsUsers.InsertUserAndReturnID(this.PersonID, this.Username, this.Password, this.IsActive);
            if (this.UserID != -1)
            {
                this.Mode = enUserMode.UpdateMode;
                return true;
            }
            else
            {
                return false;
            }
           
        }

        
        
        
        //Find User Method By UserID
        static public clsUser Find(int UserID)
        {

            int PersonID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = false;
            if (clsUsers.GetUserInfoByUserID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(PersonID, UserID, Username, Password, IsActive);
            }
            else
            {
                return null;
            }
        }



        //Find User Method By USERNAME
        static public clsUser FindByUsername(string Username)
        {
            int UserID = -1;
            int PersonID = -1;
            // string Username = "";
            string Password = "";
            bool IsActive = false;
            if (clsUsers.GetUserInfoByUsername(ref UserID, ref PersonID, Username, ref Password, ref IsActive))
            {

                return new clsUser(PersonID, UserID, Username, Password, IsActive);

            }
            else
            {
                return null;
            }


        }



        //Find User Method By Person
        static public clsUser Find(clsPerson person)
        {

            int UserID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = false;
            if (clsUsers.GetUserInfoByPersonID(ref UserID, person.PersonID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(person, UserID, Username, Password, IsActive);
            }
            else
            {
                return null;
            }
        }



        private bool _Update()
        {
             return clsUsers.UpdateUserinfo(this.UserID, this.PersonID, this.Username, this.Password, this.IsActive);
        }



        //Save By Mode 
        public bool Save()
        {
            switch (this.Mode)
            {
                case enUserMode.AddNewMode:
                   
                        return _Add();
                  
                case enUserMode.UpdateMode:
                    return _Update();
                    default:
                    return false;
            }
        
        }


        static public bool Exists(string NationaID)
        {

            if (clsPeople.IsPersonExists(NationaID))
            {
                return clsUsers.Exists(clsPerson.Find(NationaID).PersonID);
            }
            else
            {
                return false;
            }

        }



        static public bool Exists(int PersonID)
        {

            if (clsPeople.IsPersonExists(PersonID))
            {
                return clsUsers.Exists(PersonID);
            }
            else
            {
                return false;
            }

        }


        public bool Exists()
        {
            return clsUsers.Exists(this.PersonID);
           
        }


        static bool ExistsByUserName(string username)
        {
            return clsUsers.Exists(username);
        }

      

        static public bool Delete(int UserID)
        {
            return clsUsers.Delete(UserID);
        }
        //LogIn 
        static public bool Login(string username, string password,ref int UserID)
        {
            UserID= clsUsers.GetUserIDByUsernameAndPassword(username,password);
            return UserID != -1;
        }

        //Get All People info
        static public DataTable GetAllUsersListe()
        {
            return clsUsers.GetAllUsersList();
        }
        
        
      


    }
}
