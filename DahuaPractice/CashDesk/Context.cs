namespace CashDesk
{
    class Context
    {
        IPolicy policy;
        public Context(string policyType)
        {
            switch (policyType)
            {
                case "无优惠":
                    policy = new DazhePolicy(1.0);
                    break;
                case "8折":
                    policy = new DazhePolicy(0.8);
                    break;
                case "6折":
                    policy = new DazhePolicy(0.6);
                    break;
                case "满300返100":
                    policy = new RebatePolicy(300.0, 100.0);
                    break;
            }
        }
        public double GetResult(double money)
        {
            return policy.AcceptedCash(money);
        }
    }
}
