using System;

namespace ConsoleApplication
{
    public class EvenOdd
    {
        public static void Main()
        {   // odd or even
           int number = Convert.ToInt32(Console.ReadLine());

           if(number % 2 == 0)
           {
               Console.WriteLine("Number is even!");
           }
            else
            {
                Console.WriteLine("Number is odd!");
            }
           
           
        }
    }
}