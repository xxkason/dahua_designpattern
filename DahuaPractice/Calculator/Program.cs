using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the operator:");
            string operate = Console.ReadLine();
            Operation oper;
            oper = OperationFactory.CreateOperation(operate);
            oper.NumberA = numberA;
            Console.WriteLine("Input the second number:");
            double numberB = double.Parse(Console.ReadLine());
            oper.NumberB = numberB;
            double result = oper.GetResult();
            Console.WriteLine(result);
        }
    }
}
