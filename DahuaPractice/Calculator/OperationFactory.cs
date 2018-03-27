namespace Calculator
{
    class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation opera = null;
            switch (operate)
            {
                case "+":
                    opera = new OperationAdd();
                    break;
                case "-":
                    opera = new OperationSub();
                    break;
                case "*":
                    opera = new OperationMul();
                    break;
                case "/":
                    opera = new OperationDiv();
                    break;
            }
            return opera;
        }
    }
}
