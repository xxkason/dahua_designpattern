namespace CashDesk
{
    class DiscountPolicyFactory
    {
        public static DiscountPolicy CreateDiscountPolicy(string policy)
        {
            DiscountPolicy activity = null;
            switch (policy)
            {
                case "无优惠":
                    activity =  new DiscountPolicyNormal();
                    break;
                case "8折":
                    activity = new DiscountPolicyDazhe(0.8);
                    break;
                case "6折":
                    activity = new DiscountPolicyDazhe(0.6);
                    break;
                case "满300返100":
                    activity = new DiscountPolicyManfan(300.0, 100.0);
                    break;
            }
            return activity;
        }
    }
}
