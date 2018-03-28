namespace CashDesk
{
    abstract class DiscountPolicy
    {
        public abstract decimal AcceptedCash(decimal money);
    }
}
