using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Acces_Layer
{
    public class clsTests
    {
        static public int Insert( int AppointmentID, short Score, bool IsPassed)
        {
            

 
            int insertedID=-1;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"INSERT INTO [dbo].[Tests]
                                        (
                                         [Appointment ID]
                                        ,[Score]
                                        ,[Is Passed])
                                  VALUES
                                        ( @AppointmentID
                                         ,@Score
                                         ,@IsPassed);
                            SELECT SCOPE_IDENTITY() AS InsertedID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            if (Score ==-1)
            {
                command.Parameters.AddWithValue("@Score", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Score", Score);
            }
            command.Parameters.AddWithValue("@IsPassed", IsPassed);
          
            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();
              if (result != null )
                { 
                    insertedID = Convert.ToInt32(result);
                }
              else 
                {
                    insertedID = -1; 
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                insertedID = -1;
            }
            finally
            {
                connection.Close();
            }
            return insertedID;

        }
        //static public int Insert(int AppointmentID, bool IsPassed)
        //{



        //    int insertedID = -1;
        //    SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
        //    string query = @"INSERT INTO [dbo].[Tests]
        //                                (
        //                                 [Appointment ID]
        //                                ,[Is Passed])
        //                          VALUES
        //                                ( @AppointmentID
        //                                 ,@IsPassed);
        //                    SELECT SCOPE_IDENTITY() AS InsertedID;";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
        //    command.Parameters.AddWithValue("@IsPassed", IsPassed);

        //    try
        //    {
        //        connection.Open();

        //        Object result = command.ExecuteScalar();
        //        if (result != null) 
        //        {

        //            insertedID = Convert.ToInt32(result);



        //        }
        //        else 
        //        { 

        //            insertedID = -1;

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        insertedID = -1;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return insertedID;

        //}
    }
}
