namespace CashDesk
{
    abstract class DiscountPolicy
    {
        public abstract double AcceptedCash(double money);
    }
}
