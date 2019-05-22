using System;

namespace chasing
{

    interface IGiveGift
    {
        void GiveGift(string gift);
    }
    class Pursuit : IGiveGift
    {
        private Girl mm;
        private string name;

        public string Name
        { get { return name; } }
        public Pursuit(string name, Girl mm)
        {
            this.name = name;
            this.mm = mm;
        }

        public void GiveGift(string gift)
        {
            Console.WriteLine("{0}, this is {1} for you", mm.Name, gift);
        }
    }

    class Proxy : IGiveGift
    {
        Pursuit customer;
        public Proxy(Pursuit customer)
        {
            this.customer = customer;
        }

        public void GiveGift(string gift)
        {
            customer.GiveGift(gift);
            Console.WriteLine("This {0} is from {1}", gift, customer.Name);
        }
    }

    class Girl
    {
        private string name;

        public string Name
        {
            get { return name; }
        }
        public Girl(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Girl jiaojiao = new Girl("jiaojiao");
            Pursuit jiayi = new Pursuit("jiayi", jiaojiao);
            Proxy daili = new Proxy(jiayi);
            daili.GiveGift("dolls");
            daili.GiveGift("flowers");
            daili.GiveGift("chocolate");
        }
    }
}
