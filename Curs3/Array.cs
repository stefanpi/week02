using System;

namespace Curs3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var a = 0;
            var b = 1;
            int c = a +b;

            do
            {
            
                Console.WriteLine(c + " , ");
                c = a + b;
                a = b;
                b = c;

            } while (c < 50);

            Console.ReadLine();

        }
    }
}


