using System;

namespace ConsoleApplication
{
    class Program
    {   

        public static int FindIndex(int[] array, int value)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == value)
                {
                    return i;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] = arr = new[]  (10, 20, 15, 70);
            int suma = 0;

            for (int i = 0; i <= arr.Length -1; i++);
            {
                suma = suma + arr [i];

            }

            double media = suma / arr.Length;

            Console.WriteLine(media);
            Console.ReadLine();

        }
    }
}