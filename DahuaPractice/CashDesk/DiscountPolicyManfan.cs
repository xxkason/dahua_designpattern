using System;

namespace CashDesk
{
    class DiscountPolicyManfan : DiscountPolicy
    {
        double moneyCondition = 0.0;
        double moneyReturn = 0.0;
        public DiscountPolicyManfan(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double AcceptedCash(double money)
        {
            if (money >= moneyCondition)
            {
                money -= Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return money;
        }
    }
}
