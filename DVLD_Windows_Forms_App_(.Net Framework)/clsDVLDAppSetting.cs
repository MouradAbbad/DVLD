using DVLD_Buisnes_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Driving_License_Management
{
    internal class clsDVLDAppSetting
    {
        //static public string targetFolder = @"C:\Users\Mourad\Desktop\DVLD People Photos"; // Define your folder path here
        
        static public string PeoplepPhotosFolder = @"C:\Users\Administrator\Desktop\DVLD People Photos"; // Define your folder path here
        //static public int CurrentUserID =-1;
        static public clsUser currentuser;

        
        static public string txtFileName = @"PharmPcRemember.txt"; // Path to store username and password
                                                                   // static public string txtFileName = @"ToshibaRemember.txt"; // Path to store username and password

        static public bool Cardinality(ref string username, ref string password)
        {
            if (File.Exists(clsDVLDAppSetting.txtFileName))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(clsDVLDAppSetting.txtFileName))
                    {
                        username = sr.ReadLine(); // Read username
                        password = sr.ReadLine(); // Read password
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading credentials: {ex.Message}");
                    return false;
                }
            }
            return false;
            ////this will get the stored username and password and will return true if found and false if not found.
            //try
            //{
            //    //gets the current project's directory
            //    string currentDirectory = System.IO.Directory.GetCurrentDirectory();

            //    // Path for the file that contains the credential.
            //    string filePath = currentDirectory + "\\data.txt";

            //    // Check if the file exists before attempting to read it
            //    if (File.Exists(filePath))
            //    {
            //        // Create a StreamReader to read from the file
            //        using (StreamReader reader = new StreamReader(filePath))
            //        {
            //            // Read data line by line until the end of the file
            //            string line;
            //            while ((line = reader.ReadLine()) != null)
            //            {
            //                Console.WriteLine(line); // Output each line of data to the console
            //                string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

            //                Username = result[0];
            //                Password = result[1];
            //            }
            //            return true;
            //        }
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}");
            //    return false;
            //}
        }
        static public void SaveCredentials(string username, string password)
        {

            try
            {
                // Save username and password in the text file
                using (StreamWriter sw = new StreamWriter(clsDVLDAppSetting.txtFileName))
                {
                    sw.WriteLine(username);
                    sw.WriteLine(password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving credentials: {ex.Message}");
            }
        }

        static public void ClearCredentials()
        {
            try
            {
                if (File.Exists(clsDVLDAppSetting.txtFileName))
                {
                    File.Delete(clsDVLDAppSetting.txtFileName); // Delete the stored credentials file
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing credentials: {ex.Message}");
            }
        }

        static public bool IsValidLogin(string username, string password)
        {
            clsDVLDAppSetting.currentuser = clsUser.FindByUsername(username);
            if (clsDVLDAppSetting.currentuser != null)
            {
                return clsDVLDAppSetting.currentuser.Password == password;
            }
            else
            {
                return false;
            }

        }

    }
}
