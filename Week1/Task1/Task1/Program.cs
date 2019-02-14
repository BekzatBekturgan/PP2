using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Program
    {
        static bool IsPrime(int x) // to create a function to find the prime numbers 
        {
            if (x == 1) return false; // 1 is not a prime number,
            for (int i = x - 1; i > 1; i--) // 
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // create variable int, then to add elements to int, convert string to int
            int[] a = new int[n]; // new array with size n
            string s = Console.ReadLine(); // write the numbers to the string
            string[] parts = s.Split(); // to the new array parts write string s, and remove space with spilit
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(parts[i]); // in the array parts converts string to int array 
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(a[i]) == true) ans++; // use function to check number to the prime, and the quantity of prime numbers write to the ans
                else a[i] = -1; // else to the element of array write -1, 
            }
            Console.WriteLine(ans); // output the quantity of primes number in array
            for (int i = 0; i < n; i++)
            {
                if (a[i] != -1) // if element in array is equal to -1, then this elements is not prime, because of that program output the primes numbers
                    Console.Write(a[i] + " ");
            }
        }
    }
}