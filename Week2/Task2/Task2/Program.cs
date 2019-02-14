using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    class Program
    {
        static bool isPrime(int x) // a method to check the number to prime
        {
            if (x == 1) return false; // 1 is not prime, exception
            for (int i = x - 1; i > 1; i--) // with loop check the x from x-1 to 2, if the x is not divide all the i, then x is prime
            {
                if (x % i == 0) return false; // if x is divided by i, then the number is not prime
            }
            return true; // else the number is prime 
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\c#\prime input.txt", FileMode.Open, FileAccess.Read); // to create a new filestream to read information in file
            StreamReader sr = new StreamReader(fs); // read information from filestream to the streamreader
            string s = sr.ReadToEnd(); // that information which read in file, write to the string with ReadtoEnd
            string path = @"D:\c#\output prime.txt"; // a path to the a new create

            FileStream fo = File.Create(path); // create a files 
            fo.Close(); // close the filestream
            FileStream fw = new FileStream(path, FileMode.Append, FileAccess.Write); // filestream to add file
            StreamWriter sw = new StreamWriter(fw); // to create a new streamwriter to write information to file
            
            
            //Console.WriteLine(s); it's check for me
            string[] parts = s.Split(); // strings s delete the spaces and write to the array by string 
            int[] a = new int[parts.Length]; // new array by integer, with size array parts
            for (int i = 0; i < parts.Length; i++)//loop for write char from one array to write another array
            {
                a[i] = int.Parse(parts[i]); // convert to the integer with int.Parse

            }
            for (int i = 0; i < a.Length; i++)
            {
                if (isPrime(a[i]) == true) // using a method isPrime to check that the number is prime or not
                    sw.Write(a[i] + " "); // if a number is prime, then write to the another file 
            }
            fs.Close();
            sr.Close(); // close the stream
            sw.Close(); // close the stream, if do not close, the information is not saved in the file
            fw.Close();
        

        }
    }
}