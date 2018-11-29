using System;

namespace Curs2
{
    public class While
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            while(number > 0)
            {
                Console.Write(number + "\t");
                number --;
            }
        }
    }

}