using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IWriteIntoFile
    {
        void SaveFile();
        void GenerateFile (string someText, FileStream fs);

    }
}
