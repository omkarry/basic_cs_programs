using System;

namespace IBasic
{
    class DataTypes
    {
        static void Main(string[] args)
        {   
            byte a = 121;//Value Type 1 byte

            //short num = 10; Value Type 2 byte
            int num = 15;  //Value Type 4 byte 
            //long num = 200; Value Type 8 byte

            char c = 'A';//Value Type 2 byte
            //string = "Hi" Reference Type 

            //single pi = 3.14;  Value Type 4 byte
            double pi = 3.14; //Value type 8 byte 
            //decimal pi = 3.14; Value Type 16byte
            
            bool isCorrect = true;//Value Type 1 byte
            
            Console.WriteLine($"{a}: {sizeof(byte)} bytes");
            Console.WriteLine($"{num}: {sizeof(int)} bytes");
            if (isCorrect){
                Console.WriteLine($"Character is {c}: {sizeof(char)} bytes");
                Console.WriteLine($"{pi} is a floating point: {sizeof(double)} bytes");
            }

            //int* ptr = &num; Pointer Type
        
        }
    }
} 