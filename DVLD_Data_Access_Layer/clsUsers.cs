

using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace DVLD_Data_Acces_Layer
{
    //UserID, PersonID, Username, Password, IsActive
    public class clsUsers
    {
        
        //Add new User  static method
        static public int InsertUserAndReturnID( int PersonID, string Username, string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
             string query = @"INSERT INTO [dbo].[Users]
                                         ([Person]
                                         ,[Username]
                                         ,[Password]
                                         ,[Is Active])
                                          OUTPUT INSERTED.[User ID]
                                   VALUES
                                         (@PersonID
                                         ,@Username
                                         ,@Password
                                         ,@IsActive
                                         );";

             SqlCommand command = new SqlCommand(query, connection);

             command.Parameters.AddWithValue("@PersonID", PersonID);
             command.Parameters.AddWithValue("@Username", Username);
             command.Parameters.AddWithValue("@Password", Password);
             command.Parameters.AddWithValue("@IsActive", IsActive);
             try
             {
                  connection.Open();
                 object result = command.ExecuteScalar();   
                 if (result != null)
                 {
                    UserID=(int)result;
                 }
                 else
                 {

                    UserID= - 1;
                 }
             }
             catch (Exception ex)
             {
                // Console.WriteLine(ex.Message);
                UserID= - 1;
                
             }
             finally
             {
                 connection.Close();
             }
            return UserID;


        }

        //Get By Person ID User info static method
        static public bool GetUserInfoByPersonID(ref int UserID, int PersonID, ref string Username, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Users] WHERE [Person] = @PersonID;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["User ID"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];

                    //IsActive = reader.GetBoolean(4);
                    //IsActive = reader.GetBoolean((  reader.GetOrdinal("Is Active")));
                    IsActive = (bool)reader["Is Active"];
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

        //Get By User ID User info static method
        static public bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string Username, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Users] WHERE [User ID] = @UserID;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["Person"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];

                    //IsActive = reader.GetBoolean(4);
                    //IsActive = reader.GetBoolean((  reader.GetOrdinal("Is Active")));
                    IsActive = (bool)reader["Is Active"];
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

        //Get By Username ID User info static method
        static public bool GetUserInfoByUsername(ref int UserID, ref int PersonID, string Username
            , ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Users] WHERE [Username] = @Username;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["User ID"];
                    PersonID = (int)reader["Person"];
                    //Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["Is Active"];
                   
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
        //Get B UserID  BY Username and Password static method
        static public int GetUserIDByUsernameAndPassword(string Username, string Password)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT [User ID] FROM [dbo].[Users] WHERE [Username]= @Username and [Password]= @Password and [Is Active] = 1;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    UserID = (int)result;
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

            return UserID;
        }


         //Updae User info static Method
         static public bool UpdateUserinfo(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            bool Updated = false;
            if (Exists(PersonID))
            {
                SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
                string query = @"
                                 UPDATE [dbo].[Users]
                                          SET 
                                              [Username]  = @Username
                                             ,[Password]  = @Password
                                             ,[Is Active] = @IsActive
                                        WHERE [Person] = @PersonID;";

                SqlCommand command = new SqlCommand(query, connection);

               // command.Parameters.AddWithValue("@UserID"  , UserID);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                
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

            }

            return Updated;

        }

       

        //Get Users list
        static public DataTable GetAllUsersList()
        {
            DataTable tbUsers = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT * FROM [dbo].[View_Users_Details_1]  ORDER BY [User ID] DESC;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                tbUsers.Load(reader);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return tbUsers;
        }
        static public bool Delete(int UserID)
        {
            bool Deleted = false;
            
            
                SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
                string query = @"DELETE FROM [dbo].[Users] WHERE [dbo].[Users].[User ID] =@UserID;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Deleted = true;
                    }
               
                }
                catch (Exception ex)
                {
                   // Console.WriteLine(ex.Message);
                    Deleted = false;
                }
                finally
                {
                    connection.Close();
                }
            
            return Deleted;
        }
      


        //Check By Person ID if User exists
        static public bool Exists(int PersonID)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT [User ID] FROM [dbo].[Users] WHERE [Person]= @PersonID";
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

        //Check By Username if User exists
        static public bool Exists(string Username)
        {
            bool isExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT [User ID] FROM [dbo].[Users] WHERE [Username]= @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
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

      

       
        
        


    }
}
