namespace CashDesk
{
    class DiscountPolicyNormal : DiscountPolicy
    {
        public override double AcceptedCash(double money) => money;
    }
}
