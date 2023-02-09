using System;

namespace IBasic
{
    class BasicStructure
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=0 ; i<=10; i++)
            {
                if(num == 3 && i==3)
                    continue;   //Skips the iteration
                else if(num == i)
                    break;      //Exits from the loop
                else if(num == 5)
                    goto printThis; //jumps to label printThis
                Console.Write($"{i} ");
            }

            printThis:
            Console.WriteLine("End");
        }
    }
}
 