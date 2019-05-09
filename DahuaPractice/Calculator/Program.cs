using System;

namespace calculator
{
    class Operation
    {
        public static double GetResult(double Num1, double Num2, string opt)
        {
            switch (opt)
            {
                case "+":
                    return Num1 + Num2;
                case "-":
                    return Num1 - Num2;
                case "*":
                    return Num1 * Num2;
                case "/":
                    return Num1 / Num2;
                default:
                    throw new Exception("Unsupported operation");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the first number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Please input the operator: ");
            string opt = Console.ReadLine();
            Console.Write("Please input the second number: ");
            string secondNumber = Console.ReadLine();
            double result;
            try
            {
                result = Operation.GetResult(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber), opt);
                // switch (opt)
                // {
                //     case "+":
                //         result = Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber);
                //         break;
                //     case "-":
                //         result = Convert.ToDouble(firstNumber) - Convert.ToDouble(secondNumber);
                //         break;
                //     case "*":
                //         result = Convert.ToDouble(firstNumber) * Convert.ToDouble(secondNumber);
                //         break;
                //     case "/":
                //         result = Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber);
                //         break;
                //     default:
                //         Console.WriteLine("Unsupported operator.");
                //         return;
                // }
                Console.WriteLine(String.Format("The result is {0:F}", result));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 

        }
    }
}
