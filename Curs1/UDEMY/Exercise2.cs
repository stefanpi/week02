using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayingVariables
{
    class Program
    {
        //Lecture 3: Displaying Variables in the Console
        static void Main(string[] args)
        {
            int myInt = 5;
            double myDouble = 5.5;
           // string myString = "Hello World!";
           // bool myBool = true;
           // char myChar = 'A';


            Console.WriteLine("The value of myInt is {0,-5} and the value of myDouble is {1,5}",myInt,myDouble);

            Console.WriteLine("The value of myInt is " + myInt + " and the value of myDouble is " +myDouble);
         
            



        }
    }
}
