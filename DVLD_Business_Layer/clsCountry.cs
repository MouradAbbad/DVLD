using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Acces_Layer;

namespace DVLD_Buisnes_Layer
{
    public class clsCountry
    {
       public int CountryID { get;  }
       public string CountryName { get; set; }

        private clsCountry(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }

        static public DataTable CountriesList()
        {
            return clsCountries.GetCountriesList();
        }
        static public clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            if (clsCountries.GeteCountryInfoByCountryName(ref CountryID,ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }

        }
        static public clsCountry Find(int CountryID)
        {
            string CountryName = "";
            if (clsCountries.GeteCountryInfoByCountryID(ref CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }

        }
    }
}
