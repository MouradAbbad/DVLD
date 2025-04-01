using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Acces_Layer
{
    public class clsDrivers
    {
        static public bool Insert(ref int DriverID, int Person, int License)
        {

            bool inserted = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"INSERT INTO [dbo].[Drivers]
                                        ([Person]
                                        ,[License])
                                  VALUES
                                        (@Person
                                        ,@License);
                                  SELECT SCOPE_IDENTITY() AS [Driver ID];";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Person", Person);
            command.Parameters.AddWithValue("@License", License);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result != null)
                {
                    inserted = true;
                    DriverID = Convert.ToInt32(result);

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

        static public bool GetInfo(ref int DriverID, ref int Person, int License)
        {

            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [Driver ID]
                                   ,[Person]
                               FROM [dbo].[Drivers]
                               WHERE [License] = @License;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@License", License);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   
                    DriverID= (int)reader["Driver ID"];
                    Person = (int)reader["Person"];
                    found = true;
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
            return found;
        }

        static public DataTable List()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT * FROM [dbo].[View_Drivers Details];";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);

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
            return dt;
        }

        static public DataTable List(string column_name, string value)
        {
            DataTable dt = new DataTable();
            
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = $@"SELECT * FROM [dbo].[View_Drivers Details]
                               WHERE [{column_name}] LIKE '{value}%';";
           
            SqlCommand command = new SqlCommand(query, connection);
            
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                   
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
            return dt;
        }

    }


}
