using System;

namespace Calculator
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("0 can't be divided");
            }
            return NumberA / NumberB;
        }
    }
}
