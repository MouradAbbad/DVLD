using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Acces_Layer
{
   public class clsLicenseClasses
    {
        static public DataTable GetLicensesClassList()
        {
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [Class Name],[Class Description]FROM [dbo].[License Classes];";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
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
            return table;
        }

        //GetLicenseClassIDByClassName
        static public short GetLicenseClassID(string ClassName)
        {

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [License Class ID]
                                 FROM [dbo].[License Classes]
                                 where [Class Name] = @ClassName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            short ID = -1;
           
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID= (short)reader["License Class ID"];
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
            return ID;

        }

        //Get License Class DESCRIPTION By ID
        static public string GetClassDescription(int ID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [Class Name]+'-'+[Class Description] AS Description 
                                 FROM [dbo].[License Classes] 
                                 WHERE [License Class ID] = @ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            string description = "NON";
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    description = (string)reader["Description"];
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
            return description;

        }
        
        //Get License Class DESCRIPTION By ID
        static public bool GetLicenseClass(ref int LicenseClassID, ref string ClassName, ref string ClassDescription, ref short MinimumAllowedAge
            , ref short ValidityLength, ref decimal ClassFee)
        {

            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [License Class ID]
                                   ,[Class Name]
                                   ,[Class Description]
                                   ,[Minimum Allowed Age]
                                   ,[Validity Length]
                                   ,[Class Fee]
                               FROM [dbo].[License Classes]
                               WHERE [License Class ID] = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            bool isfind = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfind = true;
                    ClassName         = (string)reader["Class Name"];
                    ClassDescription  = (string)reader["Class Description"];
                    MinimumAllowedAge = (short)reader["Minimum Allowed Age"];
                    ValidityLength    = (short)reader["Validity Length"];
                    ClassFee          = (decimal)reader["Class Fee"];


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
            return isfind;

        }
    }
}
