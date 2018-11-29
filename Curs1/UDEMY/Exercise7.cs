using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class Program
    {
        enum DayOfWeek
        {
            SUNDAY ,
            MONDAY ,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }

        //Lecture 9: Declaring Constants
        static void Main(string[] args)
        {
         int x = 5;
         double y = x;

         double myDouble = 5.5;
         // Forcing the decimal on becoming an integer
         int myInt = (int)myDouble;

         Console.WriteLine(myInt);

        }
    }
}