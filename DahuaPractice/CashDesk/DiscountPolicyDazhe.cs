using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    class DiscountPolicyDazhe : DiscountPolicy
    {
        private double discount = 1.0;

        public DiscountPolicyDazhe(string  moneyRebate)
        {
            discount = double.Parse(moneyRebate);
        }
        public override double AcceptedCash(double money) => money * discount;
    }
}
