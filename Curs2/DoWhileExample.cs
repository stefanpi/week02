using System;

namespace Curs2
{
    public class WhileExample
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(number);
                number --;
            } while (number > 0);
        }
    }

}