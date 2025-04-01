using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Acces_Layer
{
    public class clsLocalLicenses
    {
        static public bool Insert(ref int LicenseID, int LicenseClass, DateTime IssuanceDate, DateTime ExpiryDate
            , string Conditions, string Statu)
        {

            bool inserted = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"INSERT INTO [dbo].[Driving Licenses]
                                        (
                                         [License Class]
                                        ,[Issuance Date]
                                        ,[Expiry Date]
                                        ,[Conditions]
                                        ,[Statu])
                                  VALUES
                                        (
                                         @LicenseClass
                                        ,@IssuanceDate
                                        ,@ExpiryDate
                                        ,@Conditions
                                        ,@Statu        );
                                  SELECT SCOPE_IDENTITY() AS [License ID];";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssuanceDate", IssuanceDate);
            command.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
            if (string.IsNullOrEmpty(Conditions))
            {
                command.Parameters.AddWithValue("@Conditions", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Conditions", Conditions);
            }

            command.Parameters.AddWithValue("@Statu", Statu);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result != null)
                {
                    inserted = true;
                    LicenseID = Convert.ToInt32(result);

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

        static public bool GetInfo( int Person, short LicenseClass, ref int License
            , ref DateTime IssuanceDate, ref DateTime ExpiryDate, ref string Conditions, ref string Statu,ref bool isActiv, ref int driverID)

        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @" SELECT [Driver ID]
                                    ,[License]
                                    ,[License Class]
                                    ,[Issuance Date]
                                    ,[Expiry Date]
                                    ,[Conditions]
                                    ,[Statu]
                                    ,[is Active]                          
                                FROM [dbo].[Driving Licenses Details]                          
                               WHERE [Person] = @Person AND [License Class]= @LicenseClass;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@Person", Person);
            

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    driverID= (int) reader["Driver ID"];
                    License = (int)reader["License"];
                    IssuanceDate = (DateTime)reader["Issuance Date"];
                    ExpiryDate =   (DateTime)reader["Expiry Date"];
                    if (reader["Conditions"]==DBNull.Value)
                    {
                        Conditions = "";
                    }
                    else
                    {
                        Conditions = (string)reader["Conditions"];
                    }
                   
                    Statu = (string)reader["Statu"];
                    isActiv = (bool)reader["is Active"];
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

        static public bool GetInfo(int License,ref int driverID,ref int PersonID, ref short LicenseClass, ref DateTime IssuanceDate, ref DateTime ExpiryDate, ref string Conditions, ref string Statu, ref bool isActiv)

        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [Driver ID]
                                   ,[Person]
                                   ,[License Class]
                                   ,[Issuance Date]
                                   ,[Expiry Date]
                                   ,[Conditions]
                                   ,[Statu]                            
                                   ,[is Active]                            
                               FROM [dbo].[Driving Licenses Details]                            
                               WHERE [License] = @License ;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@License", License);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    driverID = (int)reader["Driver ID"];
                    PersonID = (int)reader["Person"];
                    LicenseClass = (short)reader["License Class"];
                    IssuanceDate = (DateTime)reader["Issuance Date"];
                    ExpiryDate = (DateTime)reader["Expiry Date"];
                    if (reader["Conditions"] == DBNull.Value)
                    {
                        Conditions = "";
                    }
                    else
                    {
                        Conditions = (string)reader["Conditions"];
                    }

                    Statu = (string)reader["Statu"];
                    isActiv = (bool)reader["is Active"];
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

        static public DataTable LDLicensesList(int PersonID)
        {
            DataTable LDLicensesList = new DataTable();

            
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [License]
                                   ,[Application]
                                   ,[Class Name]
                                   ,[Issuance Date]
                                   ,[Expiry Date]
                                   ,[is Active]
                               FROM [dbo].[View_People License History]
                               WHERE [Person] = @Person; ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Person", PersonID);
            

           

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                
                if (reader.HasRows)
                {
                    LDLicensesList.Load(reader);
               
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

            return LDLicensesList;
        }
    }
}
