using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Acces_Layer
{
    public class clsLocalLicenseApplecationDataAccess
    {

        

        //Get Active New License Applecation By PersonID and License Class
        static public int GetActiveApplecationID(int PersonID, short LicenseClassID)
        {
            int AppID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string Query = @"SELECT [New License Application ID]
                               FROM [dbo].[View_LDLApp]
                               WHERE   [Person ID] = @PersonID 
                               AND     [license Class] = @licenseClass 
                               AND NOT [Application statu] LIKE 'Cancelled';";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@licenseClass", LicenseClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    AppID = (int)reader[0];
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return AppID;
        }

        static public bool Insert(int Application, int licenseClass, short PassedTests=0)
        {
            bool IsAdd = false;

           
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"INSERT INTO [dbo].[New License Applications]
                                        ([Application]
                                        ,[license Class]
                                        ,[Passed Tests])
                                  VALUES
                                        (@Application
                                        ,@licenseClass
                                        ,@PassedTests);";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Application", Application);
            command.Parameters.AddWithValue("@licenseClass",licenseClass);
            command.Parameters.AddWithValue("@PassedTests", PassedTests);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    IsAdd = true;
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



            return IsAdd;
        }

        static public bool Update(int NewLicenseApplicationID,int Application, short licenseClass, short PassedTests)
        {

            bool IsUpdated = false;

            
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"UPDATE [dbo].[New License Applications]
                                SET [Application]   = @Application  
                                   ,[license Class] = @licenseClass
                                   ,[Passed Tests]  = @PassedTests 
                              WHERE [New License Application ID] = @NewLicenseApplicationID;";
                             
                             
                             
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Application", Application);
            command.Parameters.AddWithValue("@licenseClass", licenseClass);
            command.Parameters.AddWithValue("@PassedTests", PassedTests);
            command.Parameters.AddWithValue("@NewLicenseApplicationID", NewLicenseApplicationID);


            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    IsUpdated = true;
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



            return IsUpdated;
        }

        //Get all Local Licenses Applecations Details List

        static public DataTable DetailsList()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT * FROM [dbo].[View_LDLAppDetails] ORDER BY [New License Application ID] DESC;";
            SqlCommand command = new SqlCommand(query, connection);
            try 
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return dt;
        }
        //Get filtred Local Licenses Applecations  Details List  

        static public DataTable DetailsListFilterd(string FilterBy, string ValuOfFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = $"SELECT * FROM [dbo].[View_LDLAppDetails] WHERE [{FilterBy}] LIKE '{ValuOfFilter}%' ORDER BY [New License Application ID] DESC;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return dt;
        }

        //Get lOCAL driving license Application detail
        static public bool GetDetail(ref int newLicenseApplicationID, ref int application, ref short licenseClass,ref short PassedTests)
        {
            bool isFind=false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT * FROM [dbo].[New License Applications] WHERE [New License Application ID]= @NewLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewLicenseApplicationID",newLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFind = true;
                    application  = (int)reader["Application"];
                    licenseClass = (short)reader["license Class"];
                    PassedTests = (short)reader["Passed Tests"];

                    reader.Close();
                }
            }
            catch (Exception ex) {
                isFind=false;
                Console.WriteLine(ex.Message); 
            }
            finally { connection.Close(); }

            return isFind;
           
        }
        static public bool GetDetailByMainApp(ref int newLicenseApplicationID, ref int application, ref short licenseClass, ref short PassedTests)
        {
            bool isFind = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT * FROM [dbo].[New License Applications] WHERE [Application]= @application";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@application", application);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFind = true;
                    newLicenseApplicationID = (int)reader["New License Application ID"];
                    licenseClass = (short)reader["license Class"];
                    PassedTests = (short)reader["Passed Tests"];

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                isFind = false;
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

            return isFind;

        }

        //Get License Class Description

        static public string ClassDescription(int LDLAppID)
        {
            
            string classDescription="";
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT [Class] FROM [dbo].[View_LDLAppDetails] WHERE [New License Application ID]= @NewLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewLicenseApplicationID", LDLAppID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    classDescription = (string)reader["Class"];
                   

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }

         



            return classDescription;
        }

        //Get Applicant Full Name
        static public string ApplicantFullName(int LDLAppID)
        {
            string name = "";
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT [Full Name] FROM [dbo].[View_LDLAppDetails] WHERE [New License Application ID]= @NewLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewLicenseApplicationID", LDLAppID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    name = (string)reader["Full Name"];


                    reader.Close();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
            return name;
        }

        static public int ApplicantID(int LDLAppID)
        {
            int AplicantID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [Person ID]
                               FROM [dbo].[View_LDLApp]
                              WHERE [New License Application ID] = @NewLicenseApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewLicenseApplicationID", LDLAppID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar() ;
                if (result != null)
                {

                    AplicantID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
            return AplicantID;
        }

        static public bool Delete(int LDLAppID) 
        {
            bool deleted = false;


            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);

            string query = @"DELETE FROM [dbo].[New License Applications]
                                   WHERE [New License Application ID] = @NewLicenseApplicationID ; ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@NewLicenseApplicationID", LDLAppID);
           
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    deleted = true;
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



            return deleted;
        }
    }
}
