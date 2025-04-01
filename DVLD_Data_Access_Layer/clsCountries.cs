using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Acces_Layer
{
    public class clsCountries
    {
        static public DataTable GetCountriesList()
        {
            DataTable dtCountries = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = "SELECT * FROM [dbo].[Countries];";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtCountries.Load(reader);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCountries;
        }
        static public bool GeteCountryInfoByCountryID(ref int CountryID, ref string CountryName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = @"SELECT [CountryName] 
                                   FROM [dbo].[Countries]
                                   WHERE [CountryID] = @CountryID;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result!=null)
                {
                    IsFound = true;
                    CountryName = (string)result;
                }
                else
                {
                    IsFound = false;
                }
              
            }
            catch (Exception ex)
            {

                IsFound = false;
                
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        static public bool GeteCountryInfoByCountryName(ref int CountryID, ref string CountryName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string QueryText = @"SELECT [CountryID] 
                                   FROM [dbo].[Countries]
                                   WHERE [CountryName] = @CountryName;";
            SqlCommand command = new SqlCommand(QueryText, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    IsFound = true;
                    CountryID = (int)result;
                }
                else
                {
                    IsFound = false;
                }

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


    }
}
