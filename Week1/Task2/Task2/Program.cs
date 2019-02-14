using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Student // new class name of the class
    {
        string name; // variables in the class student
        string id;
        int year;

        public Student(string Name, string ID, int Year) // constructor 
        {
            name = Name; // variables in constructor write to the class 
            id = ID;
            year = Year;
        }

        public void print() // a method to the output 
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Year:" + year);
        }

    }
    class Program
    {
        static int increament(int year) // a function to increase a year of the study
        {
            return year + 1; // add +1 to the year of study
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // input the name
            string i = Console.ReadLine(); // input the id
            int y = int.Parse(Console.ReadLine()); // input the year of the study, then convert to the int
            y = increament(y); // use a function increament
            Student A = new Student(s, i, y); // create a new object in the class student, and add variables 
            A.print(); // use method to the object A
            Console.WriteLine();
            string s1 = Console.ReadLine(); // input the second name
            string i1 = Console.ReadLine(); // input the second id
            int y1 = int.Parse(Console.ReadLine()); // input the second year of the study, then converts to the int
            y1 = increament(y1); // use a fuction
            Student B = new Student(s1, i1, y1); // create a new student B
            B.print(); // output the dates of student B
        }
    }
}
