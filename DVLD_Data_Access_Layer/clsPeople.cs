using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_Data_Acces_Layer
{
    public class clsPeople
    {
        //Add new Person And Get His ID  static method
        static public int InsertPersonAndGetID(string NationalID, string FirstName, string SecondName, string ThirdName
            , string LastName, bool gender, DateTime DateofBirth, string Address, string PhoneNumber, string Email, int Nationality
            , string PersonalPhoto)
        {
            int personid = -1;
            
            
                SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
                string query = @"INSERT INTO [dbo].[People]
                                            ([NationalID]
                                            ,[FirstName]
                                            ,[SecondName]
                                            ,[ThirdName]
                                            ,[LastName]
                                            ,[gender]
                                            ,[DateofBirth]
                                            ,[Address]
                                            ,[PhoneNumber]
                                            ,[Email]
                                            ,[Nationality]
                                            ,[PersonalPhoto])
                                             OUTPUT INSERTED.[PersonID]
                                      VALUES
                                            (@NationalID
                                            ,@FirstName
                                            ,@SecondName
                                            ,@ThirdName
                                            ,@LastName
                                            ,@gender
                                            ,@DateofBirth
                                            ,@Address
                                            ,@PhoneNumber
                                            ,@Email
                                            ,@Nationality
                                            ,@PersonalPhoto);";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NationalID", NationalID);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                if (!string.IsNullOrWhiteSpace(SecondName))
                {
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                }
                else
                {
                    command.Parameters.AddWithValue("@SecondName", DBNull.Value);
                }
                if (!string.IsNullOrWhiteSpace(ThirdName))
                {
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                }
                else
                {
                    command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                }
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@gender", gender);

                command.Parameters.AddWithValue("@DateofBirth", DateofBirth);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Nationality", Nationality);
            if (!string.IsNullOrWhiteSpace(PersonalPhoto))
            {
                command.Parameters.AddWithValue("@PersonalPhoto", PersonalPhoto);

              
            }
            else
            {
                command.Parameters.AddWithValue("@PersonalPhoto", DBNull.Value);
            }
            if (!string.IsNullOrWhiteSpace(PhoneNumber))
                {
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                }
                else
                {
                    command.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                }
                if (!string.IsNullOrWhiteSpace(Email))
                {
                    command.Parameters.AddWithValue("@Email", Email);
                }
                else
                {
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                }
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        personid = (int)result;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    connection.Close();
                }

            

            return personid;
        }

        //Get By Person ID Person info static method
        static public bool GetPersonInfoByID(int PersonID, ref string NationalID, ref string FirstName
            , ref string SecondName, ref string ThirdName, ref string LastName, ref bool Gender, ref DateTime DateofBirth
            , ref string Address, ref string PhoneNumber, ref string Email, ref int Nationality
            , ref string PersonalPhoto)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[People] WHERE [PersonID] = @PersonID;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    //PersonID = (int)reader["Person ID"];
                    NationalID = (string)reader["NationalID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Gender = (bool)reader["Gender"];
                    DateofBirth = (DateTime)reader["DateofBirth"];
                    Address = (string)reader["Address"];
                    Nationality = (int)reader["Nationality"];

                    if (reader["PersonalPhoto"] != DBNull.Value)
                    {
                        PersonalPhoto = (string)reader["PersonalPhoto"];
                    }
                    else
                    {
                        PersonalPhoto = string.Empty;
                    }

                    if (reader["SecondName"] != DBNull.Value)
                    {
                        SecondName = (string)reader["SecondName"];
                    }
                    else
                    {
                        SecondName = string.Empty;
                    }

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = string.Empty;
                    }

                    if (reader["PhoneNumber"] != DBNull.Value)
                    {

                        PhoneNumber = (string)reader["PhoneNumber"];

                    }
                    else
                    {
                        PhoneNumber = string.Empty;
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];

                    }
                    else
                    {
                        Email = string.Empty;
                    }
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                IsFound = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }


        //Get By National ID Person info static method
        static public bool GetPersonInfoByNationalID(ref int PersonID,  string NationalID, ref string FirstName
            , ref string SecondName, ref string ThirdName, ref string LastName, ref bool gender, ref DateTime DateofBirth
            , ref string Address, ref string PhoneNumber, ref string Email , ref int Nationality
            , ref string PersonalPhoto)
        {
            bool IsFound=false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[People] WHERE [NationalID] = @NationalID;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@NationalID", NationalID);

            try 
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID        =(int) reader["PersonID"]; 
                    //NationalID      =(string) reader["[National ID]"];
                    FirstName       =(string) reader["FirstName"];
                    LastName        =(string) reader["LastName"];
                    gender          = (bool)reader["Gender"];
                    DateofBirth     = (DateTime) reader["DateofBirth"];
                    Address         =(string) reader["Address"];
                    Nationality     =(int)  reader["Nationality"];
                    if (reader["PersonalPhoto"] != DBNull.Value)
                    {
                        PersonalPhoto = (string)reader["PersonalPhoto"];
                    }
                    else
                    {
                        PersonalPhoto = string.Empty;
                    }

                    if (reader["SecondName"] != DBNull.Value)
                    {
                        SecondName      =(string) reader["SecondName"];
                    }
                    else
                    {
                        SecondName = string.Empty;
                    }

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = string.Empty;
                    }

                    if (reader["PhoneNumber"] != DBNull.Value)
                    {
                        PhoneNumber = (string)reader["PhoneNumber"];
                    }
                    else
                    {
                        PhoneNumber = string.Empty;
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = string.Empty ;
                    }
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                
                IsFound = false;
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                connection.Close(); 
            }

            return IsFound;

        }

        //Updae Person info static Method
        static public bool UpdatePersonInfo(int PersonID, string NationalID, string FirstName, string SecondName, string ThirdName
            , string LastName, bool gender, DateTime DateofBirth, string Address, string PhoneNumber,string PersonalPhoto, string Email, int Nationality)
        {
            bool Updated = false;
            
            
                SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
                string query = @"UPDATE [dbo].[People]
                                    SET [NationalID]    = @NationalID
                                       ,[FirstName]     = @FirstName
                                       ,[SecondName]    = @SecondName
                                       ,[ThirdName]     = @ThirdName
                                       ,[LastName]      = @LastName
                                       ,[gender]         = @gender
                                       ,[DateofBirth]  = @DateofBirth
                                       ,[Address]        = @Address
                                       ,[PersonalPhoto]        = @PersonalPhoto
                                       ,[PhoneNumber]   = @PhoneNumber
                                       ,[Email]          = @Email
                                       ,[Nationality]    = @Nationality
                                  WHERE [PersonID]      = @PersonID;";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);

                command.Parameters.AddWithValue("@NationalID", NationalID);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                if (SecondName != string.Empty && SecondName != null)
                {
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                }
                else
                {
                    command.Parameters.AddWithValue("@SecondName", DBNull.Value);
                }
                if (ThirdName != string.Empty && ThirdName != null)
                {
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                }
                else
                {
                    command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                }
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@gender", gender);

                command.Parameters.AddWithValue("@DateofBirth", DateofBirth);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Nationality", Nationality);
            if (!string.IsNullOrWhiteSpace(PersonalPhoto))
            {
                command.Parameters.AddWithValue("@PersonalPhoto", PersonalPhoto);


            }
            else
            {
                command.Parameters.AddWithValue("@PersonalPhoto", DBNull.Value);
            }
            if (PhoneNumber != string.Empty && PhoneNumber != null)
                {
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                }
                else
                {
                    command.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                }
                if (Email != string.Empty && Email != null)
                {
                    command.Parameters.AddWithValue("@Email", Email);
                }
                else
                {
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                }
                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Updated = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Updated = false;
                }
                finally
                {
                    connection.Close();
                }

            

            return Updated;

        }

        static public DataTable GetAllPeopleInfo()
        {
            DataTable tbPeople = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT People.[PersonID]
                                  , People.[NationalID]
                                  , People.[FirstName]
                                  , People.[LastName]
                                  , CASE 
                                           WHEN Gender = 1 THEN 'Male'
                                           WHEN Gender = 0 THEN 'Female'
                                           ELSE 'Unknown' -- In case there's a NULL or unexpected value
                                       END AS Gender
                                 
                                  , People.[DateofBirth]
                                  , Countries.[CountryName] 
                                  , People.[PhoneNumber]
                              FROM  People INNER JOIN Countries ON People.Nationality = Countries.[CountryID] ORDER BY People.[PersonID] DESC;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                tbPeople.Load(reader);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return tbPeople;
        }




        //Check By NationalID if Person exists
        static public bool IsPersonExists(string NationalID)
        {
            bool isExists=false;
            
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT [PersonID] FROM [dbo].[People] WHERE [NationalID]= @NationalID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalID", NationalID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isExists = result != null;
            } 
            catch (Exception ex)
            {

                isExists= false;
            }
            finally 
            {
                connection.Close();
            }
            return isExists;
        }

        //Check By PersonID  if Person exists
        static public bool IsPersonExists(int PersonID)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT [PersonID] FROM [dbo].[People] WHERE [PersonID]= @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isExists = result != null;
            }
            catch (Exception ex)
            {

                isExists = false;
            }
            finally
            {
                connection.Close();
            }
            return isExists;
        }

     


        //static public bool Delete(string NationalID)
        //{
        //    bool Deleted = false;
            
            
        //        SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);

        //        string query = @"DELETE FROM [dbo].[People]
        //                              WHERE [NationalID] = @NationalID;";
        //        SqlCommand command = new SqlCommand(query, connection);

        //        command.Parameters.AddWithValue("@NationalID", NationalID);
        //        try
        //        {
        //            connection.Open();
        //            int result = command.ExecuteNonQuery();
        //            if (result > 0)
        //            {
        //                Deleted = true;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            Deleted = false;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
            
        //    return Deleted;
        //}

        static public bool Delete(int PersonID)
        {
            bool isDelet = false;


            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);

            string query = @"DELETE FROM [dbo].[People]
                                      WHERE [PersonID] = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    isDelet = true;
                }
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
                isDelet = false;
            }
            finally
            {
                connection.Close();
            }

            return isDelet;
        }



    }
}
