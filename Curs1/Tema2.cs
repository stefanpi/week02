using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
         int a, far;
        a = int.Parse(Console.ReadLine());
        far = a * 9 / 5 + 32;
        Console.WriteLine(far);
        int b, cel;
        b = int.Parse(Console.ReadLine());
        cel = (b - 32) * 5/9;
        Console.WriteLine(cel);
        }
    }
}