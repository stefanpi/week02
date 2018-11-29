using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class Program
    {
        //Lecture 18 Switch Statements


        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            // if (year == 1)
            // {
            //     Console.WriteLine("Boboc");
            // }
            // else if (year == 2)
            // {
            //     Console.WriteLine("Nu esti boboc");
            
            // }
            // else if (year == 3)
            // {
            //     Console.WriteLine("Esti in anul 3");
            // }
            // else if(year == 4)
            // {
            //     Console.WriteLine("Esti la master !");
            // }
            

            switch(year)
            {
                case 1:
                {
                    Console.WriteLine("Boboc");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Nu esti boboc");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Esti in anul 3");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Esti la master !");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid year!");
                    break;
                }
            }

            



        }
    }
}   