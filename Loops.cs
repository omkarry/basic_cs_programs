using System;

namespace IBasic
{
    class Loops
    {
        static void Main(string[] args)
        {
            int j=0,number;
            int[] numArray = {10,20,30,40,50};
            //For and While works same
            for(int i=0 ; i<5 ; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------------");
            while(j<5)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("---------------------------");

            foreach(int num in numArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------------------");

            number = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Hello");
            }while(number<5);
        }
    }
} 