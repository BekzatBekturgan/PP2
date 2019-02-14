using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void f(int n, int[] number_1, int[] number_2) // a method to write from one array to second array
        {
            for(int i = 0; i < n; i++)
            {
               number_2[2 * i] = number_1[i]; // double i element in first array to the second array
               number_2[(2 * i) + 1] = number_1[i];
            }
            for (int i = 0; i < number_2.Length; i++)
            {
                Console.Write(number_2[i] + " "); // output the second array 
            }
        } 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // input integer
            string s = Console.ReadLine(); // input the variables to array
            string[] parts = s.Split(); // delete the spaces and put to the string array
            int[] number_1 = new int[n]; // new array with size n
            int[] number_2 = new int[2*n]; // second array with size 2*n
            for(int i = 0; i < n; i++)
            {
                number_1[i] = int.Parse(parts[i]); // write variables from string array to the integer array
                
            }
            f(n, number_1, number_2); // call the method

        }
    }
}
