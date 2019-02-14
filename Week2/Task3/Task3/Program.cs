using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void recursion(int j) // a method to shift the file in the folder
        {
            for (int i = 0; i < j; i++)
            {
                Console.Write("    ");
            }
        }
        static void All(DirectoryInfo dir, int j) // a method to show the all files in one folder
        {
            FileSystemInfo[] x = dir.GetFileSystemInfos(); // from folder to the array
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].GetType() == typeof(DirectoryInfo)) // if we found directory, we must check the folder, because in the folder may be have the files
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    recursion(j); // call the method // to the shift files in the folder
                    Console.WriteLine(x[i]); // show the name of the directory
                    DirectoryInfo dir2 = x[i] as DirectoryInfo; // if in one directory have directory, so we must go to the another directory, because of that we must change the directory

                    All(dir2, j + 1); //if in folder have another folder, so change the folder and shift the files
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    recursion(j); // call the method // to the shift files
                    Console.WriteLine(x[i]); // show the files in directory
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"E:exx"); // path to the directory
            All(directory, 0); // call the method and give value
        }
    }
}
