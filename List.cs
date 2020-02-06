using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class List : ISortData
    {
        public string Options(string data)
        {
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(data));
            Console.WriteLine("All projects:");
            Console.WriteLine("-------------");
            foreach (var dir in dirs)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }
            Console.WriteLine("-----------");
            Console.WriteLine("{0} projects found.", dirs.Count);
            return data;
        }


    }
}
