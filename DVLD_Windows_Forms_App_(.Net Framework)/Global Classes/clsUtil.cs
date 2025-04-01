using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management
{
    internal class clsUtil
    {
        static public string SelectSourceImagePath()
        {
            // Create an OpenFileDialog to allow the user to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filter to only show image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Show the dialog and check if the user has selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                return openFileDialog.FileName;
                // pbPersonalPhoto.Image = new System.Drawing.Bitmap(sourceImagePath);
            }
            return null;
        }

        static public bool IsCopyImage(string destinationFolder, string imageFileNameWithExtension, ref string imageSourcePath)
        {
            if (imageSourcePath == null || destinationFolder==null) { return false ; }
            // Ensure that the target folder exists
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            try
            {
               
               
                string targetFilePath = Path.Combine(destinationFolder, imageFileNameWithExtension);
                if (imageSourcePath != targetFilePath)
                {   // Copy the file to the target folder
                    File.Copy(imageSourcePath, targetFilePath, true); // true to overwrite if file exists
                    return true;

                    //MessageBox.Show("Image copied and loaded successfully!");


                }
                else
                {
                    return false;
                    //MessageBox.Show("The image is already in the target folder!");
                }


            }
            catch (Exception ex)
            {
                return false;
                //MessageBox.Show("An error occurred while copying the image: " + ex.Message);
            }
            
           
        }
        static public bool IsCopyImage( ref string imageSourcePath)
        {
            if (imageSourcePath == null) { return false; }
            // Ensure that the target folder exists
            string currentDirectory = Directory.GetCurrentDirectory();
            string targetFolder = Path.Combine(currentDirectory, "People' Photos");
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            try
            {

                string uniqueImageName = Guid.NewGuid().ToString() + Path.GetExtension(imageSourcePath);
                
                string targetFilePath = Path.Combine(targetFolder, uniqueImageName);
                if (imageSourcePath != targetFilePath)
                {   // Copy the file to the target folder
                    File.Copy(imageSourcePath, targetFilePath, false); // true to overwrite if file exists
                    imageSourcePath = targetFilePath;
                    return true;

                    //MessageBox.Show("Image copied and loaded successfully!");


                }
                else
                {
                    return false;
                    //MessageBox.Show("The image is already in the target folder!");
                }


            }
            catch (Exception ex)
            {
                return false;
                //MessageBox.Show("An error occurred while copying the image: " + ex.Message);
            }


        }
    }
}
