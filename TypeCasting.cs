using System;

namespace IBasic
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            //char and bool are not compatible 

            //Implicit Type Casting
            int num = 100;
            double doubleNumber = num;
            Console.WriteLine(doubleNumber);

            //Explicit Type Casting
            /*
            double num = 32.832;
            int i = num;
            This will cause an error
            */
            
            double doubleNum2 = 32.832;
            int num2 = (int)doubleNum2;
            Console.WriteLine(num2);

            //Convert Class Helper Method
            string str = "10001";
            int num3 = Convert.ToInt16(str);
            Console.WriteLine(num3);
        }
    }
} 