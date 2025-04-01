using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Acces_Layer
{
    public class clsApplicationTypes
    {
        //Get Applications Type Lists static method
        static public DataTable SelectAll()
        {
            DataTable tbApplicationsType = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Applications Type];";
            SqlCommand command = new SqlCommand(QueryText, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tbApplicationsType.Load(reader);
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

            return tbApplicationsType;

        }

        //Get Application Type info by Type ID static method
        static public bool SelectToWhereAppID(int TypeID,  ref string TypeTitel, ref Decimal Fee)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = "SELECT * FROM [dbo].[Applications Type] WHERE [Type ID] = @TypeID;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@TypeID", TypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    TypeTitel = (string)reader["Type Titel"];
                    Fee = (Decimal)reader["Fee"];
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
        //Update App Type Info By Type ID
        static public bool Updat(int TypeID,string TypeTitel, Decimal Fee)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"UPDATE [dbo].[Applications Type]
                            SET [Type Titel] = @TypeTitel
                               ,[Fee] = @Fee
                          WHERE [Type ID] = @TypeID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TypeTitel", TypeTitel);
            command.Parameters.AddWithValue("@Fee", Fee);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            try
            {
                connection.Open();
                int affectedrows = command.ExecuteNonQuery();
                if (affectedrows > 0) 
                {
                    IsUpdated = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                IsUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return IsUpdated;

        }

        static public int InsertTo(string TypeTitel, Decimal Fee)
        {
            int AppID = -1;
           
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"INSERT INTO [dbo].[Applications Type]
                                        ([Type Titel]
                                        ,[Fee])
                                  OUTPUT INSERTED.[Type ID]
                                  VALUES
                                        (@TypeTitel
                                        ,@Fee)";



            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TypeTitel", TypeTitel);
            command.Parameters.AddWithValue("@Fee", Fee);
           
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    AppID = (int)result;
                }
                else
                {

                    AppID = -1;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                AppID =- 1;
            }
            finally
            {
                connection.Close();
            }

            return AppID;

        }
    }
}
