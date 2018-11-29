using System;

    namespace ConsoleApplication
    {
        public class Program
        {
            public static void Main()
            {
                Decimal a, Days, Weeks, Months, Years;
                a = Decimal.Parse(Console.ReadLine());
                Years = a / 365;
                Console.WriteLine(Years);
                Months = a / 12;
                Console.WriteLine(Months);
                Weeks = a / 7;
                Console.WriteLine(Weeks);
                Days = a;
                Console.WriteLine(a);
                
            }
        }
    }
