using System;

namespace IBasic
{
    class Selection
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            //Selection Type Statements 
            switch(num)
            {
                case 1: Console.WriteLine("One");
                break;

                case 2: Console.WriteLine("Two");
                break;

                case 3: Console.WriteLine("Three");
                break;

                case 4: Console.WriteLine("Four");
                break;

                case 5: Console.WriteLine("Five");
                break;

                default: Console.WriteLine("Enter Number between 1 To 5");
                break;
            }


            // Same Using If-else is very Complex
            if(num ==1)
                Console.WriteLine("One");
            else if(num == 2)
                Console.WriteLine("Two");
            else if(num == 3)
                Console.WriteLine("Three");
            else if(num == 4)
                Console.WriteLine("Four");
            else if(num == 5)
                Console.WriteLine("Five");
            else
                Console.WriteLine("Enter Number Between 1 to 5");
            
        }
    }
} 