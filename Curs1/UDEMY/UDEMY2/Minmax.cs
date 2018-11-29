using System;

namespace ConsoleApplication
{
  public class Program
  {
     public static void Main()
    {
        Console.WriteLine("First number :");
        Console.WriteLine("Second number :");
        string temp1 = Console.ReadLine();
        string temp2 = Console.ReadLine();

        int number1 = Convert.ToInt32(temp1);
        int number2 = Convert.ToInt32(temp2);

        Console.WriteLine("Maximum number: " + Math.Max(number1, number2));

    }

    public static int Max(int number1, int number2)
    {
        return Math.Max(number1, number2);
    }
  }
}