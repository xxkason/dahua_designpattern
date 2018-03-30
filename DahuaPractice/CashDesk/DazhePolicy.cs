namespace CashDesk
{
    class DazhePolicy : IPolicy
    {
        private double discountRate;
        public DazhePolicy(double rate)
        {
            discountRate = rate;
        }

        public double AcceptedCash(double money)
        {
            return money * discountRate;
        }
    }
}
