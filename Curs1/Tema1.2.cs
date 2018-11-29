using System;

namespace ConsoleApplication
{
  public class Program
  {
     public static void Main()
    {
       Console.WriteLine("Please add the first number: ");
       string temp1 = Console.ReadLine();

       Console.WriteLine("Please add the second number: ");
       string temp2 = Console.ReadLine();

       int number1 = Convert.ToInt32(temp1);
       int number2 = Convert.ToInt32(temp2);

       int sum = Sum(number1, number2);
       Console.WriteLine("The sum is " + sum);

       int difference = Substraction(number1, number2);
       Console.WriteLine("The difference is :" + difference);
    }
         public static int Sum(int number1, int number2)
        {
            return number1 * number2;
        }

        public static int division(int number1. int number)
        {
            return number1 / number2;
        }
    }
  }
}