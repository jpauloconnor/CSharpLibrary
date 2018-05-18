using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._32_FileReading
{
    public class CustomFileReading
    {

        //Create File

        //Check if File exists
        //Delete a file if it exists.

        public static bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(fileName);
        }

        public static void CreateFile(string path)
        {
            if (FileExists(path))
            {
                File.Delete(path);
            }

            using(FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("Hello Hello again.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        
        //    try
        //    {

        //        // Delete the file if it exists.
        //if (File.Exists(path)){

        //}
        //        {
        //            // Note that no lock is put on the
        //            // file and the possibility exists
        //            // that another process could do
        //            // something with it between
        //            // the calls to Exists and Delete.
        //            File.Delete(path);
        //        }

        //        // Create the file.
        //        using (FileStream fs = File.Create(path))
        //        {
        //            Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
        //// Add some information to the file.
        //fs.Write(info, 0, info.Length);
        //        }

        // Open the stream and read it back.
        //    using (StreamReader sr = File.OpenText(path))
        //    {
        //        string s = "";
        //        while ((s = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine(s);
        //        }
        //    }
        //}

        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.ToString());
        //}
    }
}
