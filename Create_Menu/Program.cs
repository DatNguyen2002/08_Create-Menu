using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Choice = -1;

            while (Choice != 0) 
            {
                Console.WriteLine("**************MENU***************");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("Exit");
                Console.WriteLine("*********************************");
                Console.Write("Enter your choice: ");
                Choice = Int32.Parse(Console.ReadLine());


                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("***********");
                        Console.WriteLine("*********");
                        Console.WriteLine("*******");
                        Console.WriteLine("*****");
                        Console.WriteLine("***");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No Choice");
                        break;
                }
            }
            
        }
    }
}
