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

       int mul= Multiply(number1, number2);
       Console.WriteLine("The multiply is : " + mul);

       int div = Division(number1, number2);
        if ( div == 0)
        {
            Console.WriteLine("NOT POSSIBLE");
        }
        else
        {
            Console.WriteLine("The the division is :" + div);
        }



    }
         public static int Division(int number1, int number2)
        {
            return number1 / number2;
        }

        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

    
    {}
  }
}