using System;
using System.IO;

namespace school_management
{
    internal class Logger
    {
        public static void LogException(Exception ex)
        {   
            //create folder name
            string folder = "Logs";

            //checks if folder exist if not it creates
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //Create the file path
            string path = Path.Combine(folder, "ErrorLog.txt");

            //Open the file
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("=======================================");

                //Write the date
                writer.WriteLine("Date : " + DateTime.Now);

                //Write the exception message
                writer.WriteLine("Message : " + ex.Message);

                //Write the source
                writer.WriteLine("Source : " + ex.Source);

                //Write heading
                writer.WriteLine("Stack Trace :");
                //Write stack trace(shows where exception has occured)
                writer.WriteLine(ex.StackTrace);
                writer.WriteLine("=======================================");
                writer.WriteLine();
            }
        }
    }
}