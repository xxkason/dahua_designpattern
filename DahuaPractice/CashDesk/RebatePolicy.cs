using System;
namespace CashDesk
{
    class RebatePolicy : IPolicy
    {
        private double moneyCondition;
        private double moneyReturn;
        public RebatePolicy(double moneyCondition, double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        public double AcceptedCash(double money)
        {
            if (money >= moneyCondition)
            {
                double moneyRebate = Math.Floor(money / moneyCondition) * moneyReturn;
                money = money - moneyRebate;
            }
            return money;
        }
    }
}
