using System;
namespace IBasic
{
    internal class Variables
    {
        const int num1 = 100;
        static int num2 = 200; 
        int num3 = 300;
        readonly int num4 = 400;

        static void Main(string[] args)
        {
            
            Console.WriteLine($"Static Variable: {num1}");
            Console.WriteLine($"Constant Variable: {num2}"); //Constants Cannot be changed 

            Program obj1 = new Program();
            Console.WriteLine($"Non-static Variable: {obj1.num3}");
            Console.WriteLine($"Readonly Variable: {obj1.num4}");//Readonly variables cannot be changed
            Console.Read();

            //Member 'Variable.num1' cannot be accessed with an instance reference
        }
    }
}