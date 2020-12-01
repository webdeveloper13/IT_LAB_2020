using System;

namespace ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation you want to perform \n");
            Console.WriteLine("Enter 1 for Addition \n");
            Console.WriteLine("Enter 2 for Subtraction \n");
            Console.WriteLine("Enter 3 for Multiplication \n");
            Console.WriteLine("Enter 4 for Division \n");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (op)
            {
                case 1:
                    {
                        result = a + b;
                        break;
                    }
                case 2:
                    {
                        result = a - b;
                        break;

                    }
                case 3:
                    {
                        result = a * b;
                        break;
                    }
                case 4:
                    {
                        result = a / b;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please Input a valid operation!!!");
                        break;
                    }


            }
            Console.WriteLine("The answer is {0}", result);
            Console.Read();
        }
    }
}

