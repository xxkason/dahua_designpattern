using System;

namespace calculator
{
    public class Operation
    {
        private double _numA = 0;
        private double _numB = 0;

        public double NumA
        {
            get { return _numA; }
            set { _numA = value; }
        }

        public virtual double NumB
        {
            get { return _numB; }
            set { _numB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
        // public virtual double GetResult(double Num1, double Num2, string opt)
        // {
        //     switch (opt)
        //     {
        //         case "+":
        //             return Num1 + Num2;
        //         case "-":
        //             return Num1 - Num2;
        //         case "*":
        //             return Num1 * Num2;
        //         case "/":
        //             return Num1 / Num2;
        //         default:
        //             throw new Exception("Unsupported operation");
        //     }
        // }
    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumA + NumB;
        }
    }

    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumA - NumB;
        }
    }

    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumA * NumB;
        }
    }

    public class OperationDiv : Operation
    {
        private double _numB = 0;
        public override double NumB
        {
            get { return _numB; }
            set
            {
                if (value == 0.0)
                {
                    throw new Exception("invalid parameter");
                }
                else
                {
                    _numB = value;
                }
            }
        }
        public override double GetResult()
        {
            return NumA / NumB;
        }
    }

    public class OperationFactory
    {
        public static Operation CreateOperation(string opt)
        {
            Operation oper = null;
            switch (opt)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    throw new Exception("Unsupported operation");
            }
            return oper;
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
            try
            {
                Operation oper = OperationFactory.CreateOperation(opt);
                oper.NumA = Convert.ToDouble(firstNumber);
                oper.NumB = Convert.ToDouble(secondNumber);
                double result = oper.GetResult();
                // result = Operation.GetResult(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber), opt);
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
