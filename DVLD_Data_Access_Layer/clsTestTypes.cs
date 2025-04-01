using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_Data_Acces_Layer
{
    public class clsTestTypes
    {
        static public  bool GetTypeInfo(int ID,ref string Titel, ref string Description, ref decimal Fees)
        {
            bool IsFind=false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Test Type]
                                          WHERE [Type ID] =@ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind=true;
                    Titel       =(string)reader["Type Titel"]; 
                    Description =(string)reader["Description"];
                    Fees        =(decimal)reader["Fee"];
                }

            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
                return false;
            }
            finally 
            { 
                connection.Close();
            }
            return IsFind;
        }
        static public DataTable GetAllTestTypesList()
        {
            DataTable dtTestTypesList=new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QUERY = "SELECT * FROM [dbo].[Test Type];";
            SqlCommand command = new SqlCommand(QUERY, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    dtTestTypesList.Load(reader);
                }
            }
            catch (Exception ex)
            {
                connection.Close();
            }
            finally
            {
                connection.Close();
            }
            return dtTestTypesList;
        }
        static public bool UpdateTestType(int ID, string Titel, string Description, decimal Fees)
        {
            bool updated=false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"UPDATE [dbo].[Test Type]
                                 SET [Type Titel] = @Titel
                                   ,[Description] = @Description
                                   ,[Fee]         = @Fee
                               WHERE [Type ID] =    @ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Titel", Titel);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fee",Fees);
            command.Parameters.AddWithValue("@ID",ID);
            try
            {
                connection.Open();
                int rusalt = command.ExecuteNonQuery();
                if (rusalt > 0) 
                { 
                    updated = true;
                }
            }
            catch (Exception ex)
            { 
                connection.Close();
                Console.WriteLine(ex.Message);
            }
             
            finally
            {
                connection.Close() ;
            }
            return updated;
        }
    }
}
