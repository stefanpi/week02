using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class Program
    {
        //Lecture 17: Compound Expressions(EXPRESII COMPUSE) in IF Statements
        // && = and OPERATOR
        // || = or  OPERATOR

           //And is only true when both sides are true
            // T && T = T
            // F && T = F
            // F && F = F
            // T && F = F
            // OR is only false when both sides are false
            // T || T = T
            // F || T = T
            // T || F = T
            // F || F = F


        static void Main(string[] args)
        {
           Console.WriteLine("Enter your age");
           int age = int.Parse(Console.ReadLine());
           Console.WriteLine("What is the movie rating?");
           char rating = char.Parse(Console.ReadLine());
           if ((age <= 12 || age >= 65) && rating == 'G')
           {
               Console.WriteLine("Discounts applies!");
           }
           else
           {
               Console.WriteLine("Sorry, You wont get any discounts.");
           }

        }
    }
}   