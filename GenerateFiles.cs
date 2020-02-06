using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GenerateFiles
    {
        public void GenerateFile(string someText, FileStream fs)
        {
            Byte[] title = new UTF8Encoding(true).GetBytes(someText);
            fs.Write(title, 0, title.Length);
        }
    }
}
