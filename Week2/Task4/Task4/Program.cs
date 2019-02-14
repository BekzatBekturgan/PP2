using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt"; // the name of the file, that i will create
            string path1 = @"C:\Users\bbekt\Desktop\PP2 2019 spring"; // the path of created file
            string path2 = @"C:\Users\bbekt\Desktop\PP2 2019 spring\lab2"; // the path of created and copied file
            string sourcefile = Path.Combine(path1, file); // with path.combine a file to the path1, it is like to the file give a place in pc
            string sourcefile2 = Path.Combine(path2, file); // file to the path2
            FileStream fs = File.Create(sourcefile); // create a sourcefile that file in path1
            fs.Close(); // close the filestream, because of that the program doesn't work
            File.Copy(sourcefile, sourcefile2, true); // then with class File use copy file, soursefile copy to courcefile2, then true is mean that confirm the operation
            File.Delete(sourcefile); // then delete the first file, sourcefile with operation delete
        }
    }
}
