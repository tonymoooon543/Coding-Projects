using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Infi loop
            while (true)
            {
                // This program will type 'Hello' into the console title
                string title1 = "H";
                string title2 = "He";
                string title3 = "Hel";
                string title4 = "Hell";
                string title5 = "Hello";

                Console.BackgroundColor = ConsoleColor.Blue;

                Console.Title = title1;
                Thread.Sleep(500);
                Console.Title = title2;
                Thread.Sleep(500);
                Console.Title = title3;
                Thread.Sleep(500);
                Console.Title = title4;
                Thread.Sleep(500);
                Console.Title = title5;
                Thread.Sleep(1000);
            }
        }
    }
}
