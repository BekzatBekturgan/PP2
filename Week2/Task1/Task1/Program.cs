using System;
using System.Collections.Generic;
using System.IO; // library to work with files and directories
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\c#\input.txt"); // create the new streamreader to read information in file

            string s = sr.ReadToEnd(); // that text which read in the file write to the string with ReadToEnd()(from beginning to end)
            //Console.WriteLine(s); // it's my check the string


            bool ok = true; // create a bool to check that the string is polindrome
            for (int i = 0, j = s.Length - 1; i < j; i++, j--) // loop for check: i)from beginning to the j; j) from the end to i 
            {
                if (s[i] != s[j]) // if one char is not equal, then ok is false, then close the loop
                {
                    ok = false;
                    break;
                }
            }
            if (ok == true) Console.WriteLine("YES"); // output
            else Console.WriteLine("NO");

            sr.Close(); // close the streamreader, because the opened streamreader occupy the memory 
            


        }
    }
}