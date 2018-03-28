using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    class DiscountPolicyDazhe : DiscountPolicy
    {
        public override decimal AcceptedCash(decimal money, decimal discount)
        {
            return money * discount;
        }
    }
}
