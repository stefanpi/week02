using System;

namespace ConsoleApplication
{
  public class Program
  {
     public static void Main()
    {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(a);
    Console.WriteLine(b);
        if ( a == 0 ) 
        {
        Console.WriteLine ( "Message cannot display because its eqaul to 0");
        }
                   if (a > b) {
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine(b);
            }
    }
  }

}