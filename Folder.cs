using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Folder
    {
        public static void Create()
        {
            Console.WriteLine("Enter the name of your project?");
            string folderName = Console.ReadLine();
            string rootPath = $@"C:\new\{folderName}";
            Directory.CreateDirectory(rootPath);
        }

        public static void Delete()
        {
            Console.WriteLine("Enter the correct project name to delete?");
            string folderName = Console.ReadLine();
            string rootPath = $@"C:\new\{folderName}";
            if (Directory.Exists(rootPath))
            {
                Directory.Delete(rootPath);
                Console.WriteLine($@"You have successfully deleted '{folderName}' project!");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($@"Project '{folderName}' does not exist. Please try again");
                Console.WriteLine("-------------------------");
            }
        }

        public static void Rename()
        {
            Console.WriteLine("The name of the projects you want to rename?");
            string folderName = Console.ReadLine();
            string rootPathFolderName = $@"C:\new\{folderName}";
            if (Directory.Exists(rootPathFolderName))
            {
                Console.WriteLine("Enter a new name?");
                string newFolderName = Console.ReadLine();
                string newRootPathFolderName = $@"C:\new\{newFolderName}";
                try
                {
                    Directory.Move(rootPathFolderName, newRootPathFolderName);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(" ");
                Console.WriteLine($@"Your new project name is '{newFolderName}'");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($@"Project '{folderName}' does not exist. Please try again?");
            }
        }
    }
}
