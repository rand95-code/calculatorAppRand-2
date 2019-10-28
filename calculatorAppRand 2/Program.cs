using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int operation = 0;
                int input_1 = 0;
                int input_2 = 0;
                Console.WriteLine("Choose your math operation:");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division \n");
                operation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First operand");
                input_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Secend operand");
                input_2 = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                if (operation == 1)
                //call Addition with NUM 1

                {
                    result = AddMethod(input_1, input_2);
                }
                else if (operation == 2)
                // call Subtraction with NUM 2

                {
                    result = input_1 - input_2;
                }
                else if (operation == 3)
                // call Multiplication with NUM 3

                {
                    result = input_1 * input_2;
                }
                else if (operation == 4)
                // call Divisio with NUM 4 

                {
                    result = input_1 / input_2;
                }
                else
                {
                    Console.WriteLine("Wrong choice. Try again.");
                }
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        private static int AddMethod(int input_1, int input_2)
        {
            return input_1 + input_2;
        }
    }
}