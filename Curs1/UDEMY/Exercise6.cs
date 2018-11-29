using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class Program
    {
        enum DaysOffWeek
        {
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNNESDAY,
            THURSDAY
            FRIDAY,
            SATURDAY
        }

        //Lecture 9: Declaring Constants
        static void Main(string[] args)
        {
         const int myConstInt = 5;
         Console.WriteLine(Math.PI)

         DaysOffWeek today = DaysOffWeek.FRIDAY;
         Console.WriteLine(today);
         int numberOfToday = (int)today;
         Console.WriteLine(numberOfToday);
        }
    }
}