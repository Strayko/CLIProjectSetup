using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            StartProgram();
            
        }

        public static void StartProgram()
        {
            string input;
            input = Console.ReadLine();
            input = input.First().ToString().ToUpper() + input.Substring(1);
            if (input == "--help" || input == "-h")
            {
                Help();
                StartProgram();
            }
            else
            {
                SortingContext sortingContext = new SortingContext();
                string result = sortingContext.GetSortedData(input, @"C:\new\");
            }
            
        }

        private static void Help()
        {
            string text = File.ReadAllText(@"C:\new\Menu.txt");
            Console.WriteLine("{0}", text);
        }
    }
}
