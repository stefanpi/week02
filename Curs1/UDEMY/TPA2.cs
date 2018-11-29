using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class Program
    {
        //Exercise Homework 2
        // Write a program that asks the user the length and width of their room. Define a constant that represents the price of carpeting per square foot
        // compute and display the cost of caprting the room.
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of your room?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of your room?");
            double width = double.Parse(Console.ReadLine());  

            const double price = 5.50;
            double result = (length * width) * price;

            Console.WriteLine("The total prices of carpeting the room is: {0} ",result);

            // Console.WriteLine("The total price will be {0}", result);

      
         

        }
    }
}   