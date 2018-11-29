using System;

namespace ConsoleApplication
{
    public class MathFunctions
    {
        public static void Main()
        {
            string temp1 = Console.ReadLine();
            string temp2 = Console.ReadLine();

            int number1 = Convert.ToInt32(temp1);
            int number2 = Convert.ToInt32(temp2);
            
            int subs = Substraction(number1, number2);
            Console.WriteLine("The sum is " + subs);

        }
        
        public static int Substraction(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}