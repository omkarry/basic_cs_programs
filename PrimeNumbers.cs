using System;

namespace IBasic
{
    public class PrimeNumbers
    {
        public static void Main(string[] args)
        {
            int number, flag=0;

            Console.Write("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i=2 ; i<=number/2 ; i++)
            {
                if (number%i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine($"{number} is Not Prime");
            else
                Console.WriteLine($"{number} is Prime");
        }
    }
}