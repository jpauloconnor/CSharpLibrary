using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._32_FileReading_Contracts
{
    public interface IFileAlterable
    {
        bool FileExists(string fileName);
        string CreateFile(string path);
        void DeleteFile(string path);
        void ReadFile(string path);
        void CopyFile(string path);
        string CopyDirectory(string path, string destination);

    }
}
