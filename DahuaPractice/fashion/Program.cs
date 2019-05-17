using System;

namespace fashion
{
    public class Person
    {
        private string name;

        public string Name {get{return this.name;}}
        
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("A fashion {0}", this.name);
        }
    }

    public class Finery : Person
    {
        protected Person component;

        public Finery(string name) : base(name){}

        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (this.component != null)
            {
                this.component.Show();
            }
        }
    }

    public class Wearing : Finery
    {
        public Wearing(string name) : base(name){}

        public override void Show()
        {
            Console.Write("{0} ", this.Name);
            base.Show();
        }
    }

    // public class OversizeTShirts : Finery
    // {
    //     public override void Show()
    //     {
    //         Console.Write("Oversize T-Shirt ");
    //         base.Show();
    //     }
    // }
    // public class BigPants : Finery
    // {
    //     public override void Show()
    //     {
    //         Console.Write("Big Pants ");
    //         base.Show();
    //     }
    // }
    // public class Sneaker : Finery
    // {
    //     public override void Show()
    //     {
    //         Console.Write("Sneaker ");
    //         base.Show();
    //     }
    // }
    // public class Suite : Finery
    // {
    //     public override void Show()
    //     {
    //         Console.Write("Suite ");
    //         base.Show();
    //     }
    // }
    // public class Tie : Finery
    // {
    //     public override void Show()
    //     {
    //         Console.Write("Tie ");
    //         base.Show();
    //     }
    // }
    // public class LeatherShoes : Finery
    // {
    //     public override void Show()
    //     {
    //         Console.Write("Leather Shoes ");
    //         base.Show();
    //     }
    // }

    class Program
    {
        static void Main(string[] args)
        {
            Person kk = new Person("kk");
            Console.WriteLine("HipHop Stype:");
            Wearing s = new Wearing("Sneaker");
            s.Decorate(kk);
            Wearing p = new Wearing("Big Pants");
            p.Decorate(s);
            Wearing t = new Wearing("Oversize T-Shirts");
            t.Decorate(p);
            t.Show();
            // Console.WriteLine("Professional Style:");
            // Suite suite = new Suite();
            // suite.Decorate(kk);
            // Tie tie = new Tie();
            // tie.Decorate(suite);
            // LeatherShoes shoe = new LeatherShoes();
            // shoe.Decorate(tie);
            // shoe.Show();
        }
    }
}
