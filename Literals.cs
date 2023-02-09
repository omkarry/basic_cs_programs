using System;

namespace IBasic
{
    class Literals
    {
        static void Main(string[] args)
        {
            //Hexa-deciamal
            int hexaNumber = 0x1d2;
            Console.WriteLine(hexaNumber);

            //Binary
            int binaryNumber = 0b1010;
            Console.WriteLine(binaryNumber);

            //Integers
            long longNumber = 234L;
            //int num = 2314;
            //uint num = 3746U;
            //ulong num = 482UL;
            Console.WriteLine(longNumber);

            //Floating Points
            float value = 0.123F;
            //double value = 0.123D;
            //decimal value = 0.123M;
            //float f = 0.123 will cause the compile time error
            Console.WriteLine(value);

            //Character literal is single quote
            char c = 'B';
            Console.WriteLine(c);
            
            //Another character literals'\n' & '\t' and many more
            Console.WriteLine("Hello\tEveryone\nWelcome to INcubXperts");

        }
    }
} 