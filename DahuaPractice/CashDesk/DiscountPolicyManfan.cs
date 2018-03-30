using System;

namespace CashDesk
{
    class DiscountPolicyManfan : DiscountPolicy
    {
        double moneyCondition = 0.0;
        double moneyReturn = 0.0;
        public DiscountPolicyManfan(double moneyCondition, double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
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
