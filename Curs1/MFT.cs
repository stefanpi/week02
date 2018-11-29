using System;

namespace ConsoleApplication
{
    public class MathFunctions
    {
        public static void Main()
        {
            string temp1 = Console.ReadLine();
            string temp2 = Console.ReadLine();

            int number1 = Convert.ToINt32(temp1);
            int number2 = Convert.ToINt32(temp2);
            
            int sum = number1 + number2;
            Console.WriteLine("The sum is" + sum);
        }
    } 
}