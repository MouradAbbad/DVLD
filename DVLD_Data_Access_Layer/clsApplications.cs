using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Acces_Layer
{
    public class clsApplications
    {

       
        static public bool GetApplicationInfoByApplicationID(ref int ApplicationID, ref DateTime ApplicationDate, ref int PersonID
            , ref int ApplicationType, ref DateTime StatuDate, ref string Applicationstatu, ref Decimal ApplicationPaidFees,ref int UserCreator)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Applications] WHERE [Application ID] = @ApplicationID;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationDate = (DateTime)reader["Application Date"];
                    PersonID = (int)reader["Person ID"];
                    ApplicationType =     (int)reader["Application Type"];
                    StatuDate = (DateTime)reader["Statu Date"];
                    Applicationstatu =    (string)reader["Application statu"];
                    ApplicationPaidFees = (decimal)reader["Application Paid Fees"];
                    UserCreator = (int)reader["User Creator"];
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

        //Get Applications Lists  by Person ID static method
        static public DataTable GetApplicationsList( int PersonID)
        {
            DataTable tbApplications = new DataTable();
          
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Applications] WHERE [Person ID] = @PersonID ;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                   tbApplications.Load(reader);
                }
               
                reader.Close();
            }
            catch (Exception ex)
            {

              
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return tbApplications;

        }

        //Get Applications Lists   static method
        static public DataTable GetApplicationsList()
        {
            DataTable tbApplications = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Applications];";
            SqlCommand command = new SqlCommand(QueryText, connection);
            

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tbApplications.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return tbApplications;

        }
    
        //Filter requests by status.
        //Get Applications Lists  by Person ID static method
        static public DataTable GetApplicationsList(string Applicationstatu)
        {
            DataTable tbApplications = new DataTable();
        
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Applications] WHERE [Application statu] = @Applicationstatu;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@Applicationstatu", Applicationstatu);
        
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tbApplications.Load(reader);
                }
        
                reader.Close();
            }
            catch (Exception ex)
            {
        
        
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        
            return tbApplications;
        }

       

        //Add New Applecation
        static public int Insert(DateTime ApplicationDate, int PersonID, int ApplicationType,DateTime StatuDate, string Applicationstatu
            , decimal ApplicationPaidFees,int UserCreator)
        {
            int AppID = -1;
            
            
                SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
                string query = @"INSERT INTO [dbo].[Applications]
                                            ([Application Date]
                                            ,[Person ID]
                                            ,[Application Type]
                                            ,[Statu Date]
                                            ,[Application statu]
                                            ,[Application Paid Fees]
                                            ,[User Creator])
                                            OUTPUT INSERTED.[Application ID]
                                      VALUES
                                            (@ApplicationDate
                                            ,@PersonID
                                            ,@ApplicationType
                                            ,@StatuDate
                                            ,@Applicationstatu
                                            ,@ApplicationPaidFees
                                            ,@UserCreator); ";
                SqlCommand command = new SqlCommand(query, connection);
           

                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@ApplicationType", ApplicationType);
                command.Parameters.AddWithValue("@StatuDate", StatuDate);
                command.Parameters.AddWithValue("@Applicationstatu", Applicationstatu);
                command.Parameters.AddWithValue("@ApplicationPaidFees", ApplicationPaidFees);
                command.Parameters.AddWithValue("@UserCreator", UserCreator);
          


            try
            {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        AppID = (int)result;
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

            

            return AppID;
        }
        //Get Active New License Applecation By PersonID and License Class
        static public int GetActiveNewLicenseApplecationID(int PersonID, short LicenseClassID)
        {
            return clsLocalLicenseApplecationDataAccess.GetActiveApplecationID(PersonID, LicenseClassID);
        }

        //Add New New_License Applecation

        static public int Insert(DateTime ApplicationDate, int PersonID, int ApplicationType, DateTime StatuDate, string Applicationstatu
            , decimal ApplicationPaidFees,int UserCreator, short ClassID)
        {

            if (clsLocalLicenseApplecationDataAccess.GetActiveApplecationID(PersonID,ClassID)==-1)
            {
                int AppID = Insert(ApplicationDate, PersonID, ApplicationType, StatuDate, Applicationstatu, ApplicationPaidFees,UserCreator);
                if (AppID!=-1)
                {
                    clsLocalLicenseApplecationDataAccess.Insert(AppID, ClassID);
                }
                return AppID;
            }
            else
            {
                 return -1;
            }
        }

        static public bool Update(int ApplicationID,  DateTime StatuDate, string Applicationstatu, decimal ApplicationPaidFees)
        {
            bool Updated = false;


            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"UPDATE [dbo].[Applications]
                                SET [Statu Date] = @StatuDate                    
                                   ,[Application statu] = @Applicationstatu
                                   ,[Application Paid Fees] = @ApplicationPaidFees 
                              WHERE [Application ID] = @ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@StatuDate", StatuDate);
            command.Parameters.AddWithValue("@Applicationstatu", Applicationstatu);
            command.Parameters.AddWithValue("@ApplicationPaidFees", ApplicationPaidFees);



            try
            {
                connection.Open();
                int effactedrows = command.ExecuteNonQuery();
                if (effactedrows>0)
                {
                    Updated = true;
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



            return Updated;

        }

        static public bool Delete(int AppID)
        {
            bool deleted = false;


            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);

            string query = @"DELETE FROM [dbo].[Applications]
                                   WHERE [Application ID] = @ApplicationID ; ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationID", AppID);

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
