using System;

namespace cashier
{
    public abstract class DiscountSuper
    {
        public abstract double GetDiscountResult(double total);
    }

    public class DiscountRebate : DiscountSuper
    {
        private double _discountRate = 1;
        public DiscountRebate(double discountRate)
        {
            _discountRate = discountRate;
        }

        public override double GetDiscountResult(double total)
        {
            return total * _discountRate;
        }
    }

    public class DiscountReturn : DiscountSuper
    {
        private double _base = 0;
        private double _return = 0;
        public DiscountReturn(double moneyBase, double moneyReturn)
        {
            this._base = moneyBase;
            this._return = moneyReturn;
        }

        public override double GetDiscountResult(double money)
        {
            return money - Math.Floor(money / _base) * _return;
        }
    }

    // public class DiscountFactory
    // {
    //     public static DiscountSuper DiscountActivity(int index)
    //     {
    //         switch (index)
    //         {
    //             case 1:
    //                 return new DiscountRebate(0.8);
    //             case 2:
    //                 return new DiscountReturn(100, 50);
    //             default:
    //                 return new DiscountRebate(1);
    //         }
    //     }
    // }

    public class DiscountContext
    {
        private DiscountSuper concreteActivity;
        public DiscountContext(int index)
        {
            // 怎样可以利用反射机制，讲这个switch case语句来改进？？
            switch (index)
            {
                case 0:
                    this.concreteActivity = new DiscountRebate(1);
                    break;
                case 1:
                    this.concreteActivity = new DiscountRebate(0.8);
                    break;
                case 2:
                    this.concreteActivity = new DiscountReturn(100, 50);
                    break;
            }
        }

        public double DiscountMoney(double money)
        {
            return this.concreteActivity.GetDiscountResult(money);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double dTotal = 0.0;
            int index = 0;
            while (Console.ReadLine() != "=")
            {
                index++;
                Console.Write("Please input the unit price of the good: ");
                string strUnitPrice = Console.ReadLine();
                double dUnitPrice = Convert.ToDouble(strUnitPrice);
                Console.Write("Please input the number of the good: ");
                string strAmount = Console.ReadLine();
                int iAmount = Convert.ToInt32(strAmount);
                Console.Write("Please select discount activity: 0 Normal, 1 八折, 2 满100返50: ");
                string strDiscount = Console.ReadLine();
                int iDiscount = Convert.ToInt16(strDiscount);

                // DiscountSuper activity = DiscountFactory.DiscountActivity(iDiscount);
                // 用策略模式后，就不用工厂来构造具体的打折策略，而用context来实现，
                // 但是这样，把构造的switch case语句又移到了客户端来实现
                
                // 通过策略模式和简单工厂模式的结合，在context类的构造函数中实现简单工厂
                DiscountContext activityContext = new DiscountContext(iDiscount);
                
                // double dUnitTotal = activity.GetDiscountResult(dUnitPrice * iAmount);
                double dUnitTotal = activityContext.DiscountMoney(dUnitPrice * iAmount);
                dTotal = dTotal + dUnitTotal;
                string msg = String.Format("{4}: Unit Price: ${0:F}, Number: {1}, Total: {2:F}\nCurrent Total: ${3:F}", dUnitPrice, iAmount, dUnitTotal, dTotal, index);
                Console.WriteLine(msg);
            }
            Console.WriteLine("You should pay: ${0:F}", dTotal);
        }
    }
}
