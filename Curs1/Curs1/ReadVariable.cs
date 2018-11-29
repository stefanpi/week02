using System;

namespace ConsoleApplication

{
    public class ReadVariable
    {
        public static void Main()
        {
            string temp = Console.ReadLine();
            int number = Convert.ToInt32(temp);
            if (number > 100)
            {
                Console.WriteLine("Number is bigger than 100");
            } 
            else {
                Console.WriteLine("Number is smaller or equal than 100");
            }
        }
    }
}