using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // to create a new variable int, then input string, then convert string to the int
            string q = "[*]";
            string[,] s = new string[n, n]; // new 2-array with size n*n
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i) s[i, j] = q; // write to the elements string q by the if
                    else s[i, j] = ""; // else write nothing to place of elements in the array
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(s[i, j]); // output elements of 2 array
                }
                Console.WriteLine(); // the cursor to the new line
            }
        }
    }
}