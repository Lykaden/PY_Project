using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace MyProgram
{
    public static class MyAssistant
    {
        //Create a Dictionary name MIMETypesDictionary to recognize the content of the input file.


        // Create an Introduction Menu to prompt for user input on the menu options
        public static void getoption()
        {

            Console.Write("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.Write("\n");
            Console.WriteLine("%%%%% " + "Please select an option." + " %%%%%%");
            Console.Write("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.Write("\n");
            Console.WriteLine("1.View all files in Image Folder");
            Console.WriteLine("2.View all files in Text Folder");
            Console.WriteLine("3.View ALL file");
            Console.WriteLine("4.Perform sorting of files to image and text folders");
            Console.WriteLine("5.Perform Check on abnormal content in Text file");

            string readoption = Console.ReadLine();
            option = System.Convert.ToInt32(readoption);
            if (readoption == "1")
            {
                List<string> Imagefile = MyAssistant.ViewImageFiles();
                MyAssistant.output(Imagefile, null);

            }
            if (readoption == "2")
            {
                List<string> Textfile = MyAssistant.ViewTextFiles();

                MyAssistant.output(Textfile, null);

            }

            if (readoption == "3")
            {
                var Allfiles = MyAssistant.ViewTextFiles().Concat(MyAssistant.ViewImageFiles());

                MyAssistant.output(Allfiles.ToList(), null);

            }
            if (readoption == "4")
            {
                PerformSorting();

            }
            if (readoption == "5")
            {
                PerformAbnormalCheck(@"..\..\..\..\text");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }



        // Create an Image Folder Display to display ALL the files in the image folder

        public static List<string> ViewImageFiles()
        {

            List<string> ImageFiles = new List<string>();
            
            return ImageFiles;

        }

        public static void ViewTextFiles()
        {

        }


        public static void ViewAllFiles()
        {

        }

        // Classify ALL files according to their respective folder(image or text) as stated in Option 4
        public static void PerformSorting()
        {

        }

        // Perform a check on abnormal content and display
        public static void PerformAbnormalCheck()
        {

        }


        //Perform multiple deletion of files



        // After the user select to delete (Y) or not delete (N) file, the program MUST return to Introduction menu


    }
   
    class Program
    {
        static void Main(string[] args)
        {

            MyAssistant.getoption();

        }

    }
}
  
                      