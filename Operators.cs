using System;

namespace IBasic
{
    class BasicStructure
    {
        static void Main(string[] args)
        {
            int choice, num1, num2, result;
            char selectEXit;
            do
            {
                //Binary Operators require two operands
                //Unary Oprators require only one operand
                Console.WriteLine("-----------Menu-----------");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.remainder");
                Console.WriteLine("6.AND");
                Console.WriteLine("7.OR");
                Console.WriteLine("8.Negation");
                Console.WriteLine("9.Increment");
                Console.WriteLine("10.Decrement");
                console.WriteLine("11.Maximum between two");

                Console.WriteLine("---------------------------");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: num1 = Convert.ToInt32(Console.ReadLine());
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 + num2;
                            Console.WriteLine(result);
                    break;

                    case 2: num1 = Convert.ToInt32(Console.ReadLine());
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 - num2;
                            Console.WriteLine(result);
                    break;

                    case 3: num1 = Convert.ToInt32(Console.ReadLine());
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 * num2;
                            Console.WriteLine(result);
                    break;

                    case 4: num1 = Convert.ToInt32(Console.ReadLine());
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 / num2;
                            Console.WriteLine(result);
                    break;

                    case 5: num1 = Convert.ToInt32(Console.ReadLine());
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 % num2;
                            Console.WriteLine(result);
                    break;

                    case 6: num1 = Convert.ToBoolean(Console.ReadLine());
                            num2 = Convert.ToBoolean(Console.ReadLine());
                            result = num1 && num2;
                            Console.WriteLine(result);
                    break;

                    case 7: num1 = Convert.ToBoolean(Console.ReadLine());
                            num2 = Convert.ToBoolean(Console.ReadLine());
                            result = num1 || num2;
                            Console.WriteLine(result);
                    break;

                    case 8: num1 = Convert.ToInt32(Console.ReadLine());
                            result = !num1;
                            Console.WriteLine(result);
                    break;

                    case 9: num1 = Convert.ToInt32(Console.ReadLine());
                            num2 = Convert.ToInt32(Console.ReadLine());
                            num1 = num1++;
                            num2 = ++num2;
                            Console.WriteLine($"{num1} {num2}");
                    break;

                    case 10: num1 = Convert.ToInt32(Console.ReadLine());
                            num2 = Convert.ToInt32(Console.ReadLine());
                            num1 = num1--;
                            num2 = --num2;
                            Console.WriteLine($"{num1} {num2}");
                    break;

                    case 11: num1 = Convert.ToInt32(Console.ReadLine());
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = (num1 > num2)?num1:num2;
                            Console.WriteLine(result);
                    break;
        
                    default: Console.WriteLine("Enter Number between 1 To 11");
                    break;
                }
                Console.WriteLine("To exit enter 'Y'");
                selectEXit = Convert.ToChar(Console.ReadLine);
                
            }while(Char.ToUpper(selectEXit)=='Y');
        }
    }
} 