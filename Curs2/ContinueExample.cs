using System;

namespace Curs2
{
    public class ContinueExample
    {
        public static void Main()
        {
            int i = 100;
            while (i > 0)
            {   
                i--;
                if (i % 7 == 0)
                {
                    throw new Exception("It's over");
                }
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("Done!");
        }   
    }
}