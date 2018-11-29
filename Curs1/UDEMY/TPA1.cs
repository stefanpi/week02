using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class Program
    {
        //Exercise Homework 1
        // Build a simple calculator. Read in two integers from the use and add them together. Print the results
        //in a nice output statement.
        static void Main(string[] args)
        {
         Console.WriteLine("Enter the first number ");
         int myInt = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter the second number");
         int myInt2 = int.Parse(Console.ReadLine());

         int answer = myInt + myInt2;
         Console.WriteLine("{0} + {1} = {2}", myInt, myInt2, answer);
         

        }
    }
}   