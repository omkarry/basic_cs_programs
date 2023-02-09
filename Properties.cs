using System;

namespace IBasic
{
    class Properties
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Changing Console Properties";
            Console.Beep();
            Console.WriteLine("Welcome to IncubXperts");
            int a = int.Parse(Console.ReadLine());
            Console.Write(a);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
} 