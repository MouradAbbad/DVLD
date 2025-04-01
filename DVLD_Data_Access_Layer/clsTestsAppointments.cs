using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Acces_Layer
{
    public class clsTestsAppointments
    {
        static public bool Insert(ref int AppointmentID,int Application, int TestType,DateTime Date,decimal PaidFee,bool Looked/*,int MainAppointementID*/)
        {
           
            bool hasActivAppointment = clsTestsAppointments.ActiveAppointment(Application) != -1;

            if (hasActivAppointment)
            {
                return false; 
            }
            bool inserted = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"INSERT INTO [dbo].[Tests Appointments]
                                        ([Application]
                                        ,[Test Type]
                                        ,[Date]
                                        ,[Paid Fee]
                                        ,[Looked]
                                        ,[Main Appointement ID])

                                  VALUES
                                        (@Application
                                        ,@TestType
                                        ,@Date
                                        ,@PaidFee
                                        ,@Looked);
                                        ,@MainAppointementID)
                                  SELECT SCOPE_IDENTITY() AS InsertedID;";
            SqlCommand command = new SqlCommand(query, connection);
            
            if (Application == -1)
            {
                command.Parameters.AddWithValue("@Application", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Application", Application);

            }
            
            if (TestType == -1)
            {
                command.Parameters.AddWithValue("@TestType", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@TestType", TestType);

            }
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@PaidFee", PaidFee);
            command.Parameters.AddWithValue("@Looked", Looked);

            //if (MainAppointementID == -1)
            //{
            //    command.Parameters.AddWithValue("@MainAppointementID", DBNull.Value);
            //}
            //else
            //{
            //    command.Parameters.AddWithValue("@MainAppointementID", TestType);

            //}

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result != null)
                {
                    AppointmentID = Convert.ToInt32(result);
                    inserted = true;
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
            return inserted;
        }


        static public bool Insert(int Application, int TestType, DateTime Date, decimal PaidFee, bool Looked/*,int MainAppointementID*/)
        {

            bool hasActivAppointment = clsTestsAppointments.ActiveAppointment(Application) != -1;

            if (hasActivAppointment)
            {
                return false;
            }
            bool inserted = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"INSERT INTO [dbo].[Tests Appointments]
                                        ([Application]
                                        ,[Test Type]
                                        ,[Date]
                                        ,[Paid Fee]
                                        ,[Looked]
                                        )

                                  VALUES
                                        (@Application
                                        ,@TestType
                                        ,@Date
                                        ,@PaidFee
                                        ,@Looked
                                        );
                                                                   ";
            SqlCommand command = new SqlCommand(query, connection);

            //if (Application == -1)
            //{
            //    command.Parameters.AddWithValue("@Application", DBNull.Value);
            //}
            //else
            //{
                command.Parameters.AddWithValue("@Application", Application);

            //}

            //if (TestType == -1)
            //{
            //    command.Parameters.AddWithValue("@TestType", DBNull.Value);
            //}
            //else
            //{
                command.Parameters.AddWithValue("@TestType", TestType);

            //}
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@PaidFee", PaidFee);
            command.Parameters.AddWithValue("@Looked", Looked);

            //if (MainAppointementID == -1)
            //{
            //    command.Parameters.AddWithValue("@MainAppointementID", DBNull.Value);
            //}
            //else
            //{
            //    command.Parameters.AddWithValue("@MainAppointementID", MainAppointementID);

            //}
            try
            {
                connection.Open();
                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected>0 )
                {
                   
                    inserted = true;
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
            return inserted;
        }



        static public bool Update(int AppointmentID,int Application, int TestType, DateTime Date,decimal PaidFee,bool Looked)
        {
            bool inserted = false;


            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"UPDATE [dbo].[Tests Appointments]
                                      SET [Application]      = @Application
                                         ,[Test Type]        = @TestType
                                         ,[Date]             = @Date
                                         ,[Paid Fee]         = @PaidFee
                                         ,[Looked]           = @Looked
                                    WHERE [Appointment ID]   = @AppointmentID; ";
          
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Application", Application);
            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@PaidFee", PaidFee);
            //command.Parameters.AddWithValue("@Score", Score)
           // command.Parameters.AddWithValue("@ResultIsPassed", ResultIsPassed);
            command.Parameters.AddWithValue("@Looked", Looked);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);




            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    inserted = true;
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



            return inserted;
        }

       



        static public DataTable List(int Application, int TestType)
        {
            DataTable tbPeople = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = $@"SELECT [Appointment ID]
                                    ,[Date]
                                    ,[Paid Fee]
                                    ,[Looked]
                                FROM [dbo].[Tests Appointments]
                                WHERE [Application] = @Application AND [Test Type] = @TestType
                                ORDER BY [Appointment ID] DESC;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Application", Application);
            command.Parameters.AddWithValue("@TestType", TestType);


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

        static public int ActiveAppointment(int AppID)
        {
           int AppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = $@"SELECT [Appointment ID]
                                FROM [dbo].[Tests Appointments]
                                WHERE [Application]= @Application AND [Looked] = 0;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Application", AppID);
         


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    AppointmentID=(int)reader["Appointment ID"];
                    reader.Close();
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AppointmentID = -1;
            }
            finally
            {
                connection.Close();
            }
            return AppointmentID;
        }

        static public int FirstAppointment(int AppID, int TestType)
        {
            int firstAppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = $@"SELECT  TOP (1) [Appointment ID]
                                FROM [dbo].[Tests Appointments]
                                WHERE [Application]= @Application AND [Test Type]= @TestType;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Application", AppID);
            command.Parameters.AddWithValue("@TestType", TestType);




            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    firstAppointmentID = (int)reader["Appointment ID"];
                    reader.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                firstAppointmentID = -1;
            }
            finally
            {
                connection.Close();
            }
            return firstAppointmentID;
        }

        static public bool GetRecordData(int AppointmentID, ref int Application, ref int TestType, ref DateTime Date, ref decimal PaidFee, ref bool Looked)
        {
            bool find=false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = $@"SELECT * FROM [dbo].[Tests Appointments] WHERE [Appointment ID] = @AppointmentID ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Application = (int)reader["Application"];
                    TestType = (int)reader["Test Type"];
                    Date = (DateTime)reader["Date"];
                    PaidFee = (decimal)reader["Paid Fee"];
                    Looked = (bool)reader["Looked"];
                    
                    find = true;
                    reader.Close();
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
            return find;

        }


        static public int GetDLLAppID(int AppointmentID)
        {
            int DLLAppID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = $@"SELECT [New License Application ID]
                                FROM [dbo].[View_TestAppointmentDetails]
                                WHERE [Appointment ID] = @AppointmentID;";




            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    DLLAppID = (int)reader["New License Application ID"];
                    reader.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DLLAppID = -1;
            }
            finally
            {
                connection.Close();
            }
            return DLLAppID;
        }
























    }
}
