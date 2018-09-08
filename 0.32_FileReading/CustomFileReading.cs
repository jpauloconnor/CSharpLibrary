using _0._32_FileReading_Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._32_FileReading
{
    public class CustomFileReading : IFileAlterable
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(fileName);
        }
        public string CreateFile(string path)
        {
            if (FileExists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("Hello Hello again. How are you?, how are you man!");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            return path;
        }
        public void DeleteFile(string path)
        {
            throw new NotImplementedException();
        }
        public void ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void CopyFile(string path)
        {
            string sourceDir = @"c:\temp\"; ;
            string backupDir = @"c:\temp\copy";

            try
            {
                string[] txtList = Directory.GetFiles(sourceDir, "*.txt");

                foreach (string f in txtList)
                {
                    string fName = f.Substring(sourceDir.Length + 1);

                    try
                    {
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }

                    catch (IOException copyError)
                    {
                        Console.WriteLine(copyError.Message);
                    }
                }

                foreach (string f in txtList)
                {
                    File.Delete(f);
                }
            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
        }
        public string CopyDirectory(string path, string destination)
        {
            throw new NotImplementedException();
        }
    }
}
