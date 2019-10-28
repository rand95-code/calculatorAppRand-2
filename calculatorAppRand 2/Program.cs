using System;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = 0;
            int input_1 = 0;
            int input_2 = 0;
            int result = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Choose your math operation:");
                    Console.WriteLine("Press 1 for Addition");
                    Console.WriteLine("Press 2 for Subtraction");
                    Console.WriteLine("Press 3 for Multiplication");
                    Console.WriteLine("Press 4 for Division \n");
                    operation = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 1st operand");
                    input_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd operand");
                    input_2 = Convert.ToInt32(Console.ReadLine());
                    if (operation == 1)
                    //call Additon with NUM 1
                    {
                        result = addMethod(input_1, input_2);
                    }
                    else if (operation == 2)
                    {
                        result = subtractMethod(input_1, input_2);
                    }
                    else if (operation == 3)

                    {
                        result = multiplyMethod(input_1, input_2); ;
                    }
                    else if (operation == 4)
                    {
                        result = divideMethod(input_1, input_2);
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice. Try again.");
                    }
                    Console.WriteLine("The result is: " + result);
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Wrong choice. Try again.");
                }
            }
        }
        static int addMethod(int x, int y)
        {
            int z = x + y;
            return z;
        }
        static int subtractMethod(int x, int y)
        {
            int z = x - y;
            return z;
        }
        static int multiplyMethod(int x, int y)
        {
            int z = x * y;
            return z;
        }
        static int divideMethod(int x, int y)
        {
            int z;
            try
            {
                z = x / y;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                z = 0;
            }
            return z;
        }


    }
}