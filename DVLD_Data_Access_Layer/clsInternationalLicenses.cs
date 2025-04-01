using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_Data_Acces_Layer
{
    public class clsInternationalLicenses
    {
        //    int internationalID
        //   ,int localLicense
        //   ,DateTime issuanceDate
        //   ,DateTime expiryDate
        //   ,bool isActive
        static public bool Insert(ref int InternationalID, int License, DateTime IssuanceDate, DateTime ExpiryDate)
        {
          
            bool IsAdded = false;
           
            
                SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
                string query = @"INSERT INTO [dbo].[International Licenses]
                                            ([License]
                                            ,[Issuance Date]
                                            ,[Expiry Date])
                                      VALUES
                                            (@License
                                            ,@IssuanceDate
                                            ,@ExpiryDate)
                                      SELECT SCOPE_IDENTITY() AS InsertedID;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@License", License);
                command.Parameters.AddWithValue("@IssuanceDate", IssuanceDate);
                command.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
                try
                {
                    connection.Open();
                     object result = command.ExecuteScalar();

                    
                    if (result != null)
                    {
                        InternationalID= Convert.ToInt32(result);
                        IsAdded = true;
                    }
                    else
                    {
                        IsAdded = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    IsAdded = false;
                }
                finally
                {
                    connection.Close();
                }

            

            return IsAdded;
        }
        static public bool GetDetailsInfo(int InternationalID,ref  int License,ref  int DriverID,ref  DateTime IssuanceDate,ref  DateTime ExpiryDate
            ,ref  bool isActive,ref  string NationalID,ref  string Name,ref  DateTime DateofBirth, ref bool Gender, ref string PersonalPhoto)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [International ID]
                                   ,[License]
                                   ,[Driver ID]
                                   ,[Issuance Date]
                                   ,[Expiry Date]
                                   ,[is Active]
                                   ,[National ID]
                                   ,[Name]
                                   ,[Date of Birth]
                                   ,[Gender]
                                   ,[Personal Photo]
                               FROM [dbo].[View_International Licenses Details]
                               WHERE [International ID] = @InternationalID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalID", InternationalID);
            try
            {
                connection.Open();
               SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    InternationalID       = (int)      reader["International ID"];
                    License               = (int)      reader["License"];
                    DriverID              = (int)      reader["Driver ID"];
                    IssuanceDate          = (DateTime) reader["Issuance Date"];
                    ExpiryDate            = (DateTime) reader["Expiry Date"];
                    isActive              = (bool)     reader["is Active"];
                    NationalID            = (string)   reader["National ID"];
                    Name                  = (string)   reader["Name"];
                    DateofBirth           = (DateTime) reader["Date of Birth"];
                    Gender                = (bool)     reader["Gender"];
                    PersonalPhoto         = (string)   reader["Personal Photo"];
                    found = true;
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                found = false;
            }
            finally
            {
                connection.Close();
            }

            return found;
        }

        //get active international license by local licenseID
        static public bool SelectToWhere(ref int internationalID,int localLicense,ref DateTime issuanceDate,ref DateTime expiryDate,ref bool isActive )
        {
            bool isFind = false;
            SqlConnection connection = new SqlConnection(clsDataAccesSetting.ConnectionString);
            string query = @"SELECT [International ID]
                                   ,[Local_License]
                                   ,[Issuance Date]
                                   ,[Expiry Date]
                                   ,[Is Active]
                               FROM [dbo].[International Licenses]
                               WHERE Local_License = @Local_License AND [Is Active] = 1;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Local_License", localLicense);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    internationalID = (int)reader["International ID"];
                    issuanceDate = (DateTime)reader["Issuance Date"];
                    expiryDate = (DateTime)reader["Expiry Date"];
                    isActive = (bool)reader["Is Active"];
                    isFind = true;
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                isFind = false;
            }
            finally
            {
                connection.Close();
            }

            return isFind;
        }

    }
}
