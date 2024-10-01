using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VendingMaschineSite;

namespace VendingMaschine
{
    public class Water : Product //nr 1
    {
        public Water() //constructor + hela värden.
        {
            base.ProductID = 1;
            base.Kostnad = 5;
            base.Name = "water";
        }
        public override void Examine()
        {
           // Kostnad = 1; ProductID = 0; Name = "Water";
            Console.WriteLine($"{base.ProductID} {base.Name} {base.Kostnad}");
        }
        public override void Use()
        {
           // base.Examine(); innehålelr kod då andvänder man.
            Console.WriteLine($"{Name} has been bought. Have a Good taste :)");
        }
    }
    public class Coffee : Product //nr 2
    {
        public Coffee() 
        {
            base.ProductID=2;base.Kostnad=15;base.Name = "Coffee";    
        }
        public override void Examine()
        {
            Console.WriteLine($"{base.ProductID} {base.Name} {base.Kostnad}");
        }
        public override void Use()
        {
         //   base.Examine();
            Console.WriteLine($"{Name} has been bought. Have a Good taste :)");
        }
    }
    public class Soda : Product //nr 3
    {
        public Soda() 
        {
            base.ProductID = 3;base.Kostnad=24;base.Name = "Soda";
        }
        public override void Examine()
        {
            Console.WriteLine($"{base.ProductID} {base.Name} {base.Kostnad}");
        }
        public override void Use()
        {
           // base.Examine();
            Console.WriteLine($"{Name} has been bought. Have a Good taste :)");
        }
    }
    public class Chips : Product //nr4
    {
        public Chips()
        {
            base.ProductID = 4;base.Kostnad = 35;base.Name = "Chips";
        }
        public override void Examine()
        {
            Console.WriteLine($"{base.ProductID} {base.Name} {base.Kostnad}");
        }
        public override void Use()
        {
            Console.WriteLine($"{Name} has been bought. Have a Good taste :)");
        }
    }
    public class Dildo : Product//nr 5
    {
        public Dildo()
        {
            base.ProductID = 5; base.Kostnad = 250;base.Name = "Dildo";
        }
        public override void Examine()
        {
            Console.WriteLine($"{base.ProductID} {base.Name} {base.Kostnad}");
        }
        public override void Use()
        {
            Console.WriteLine($"{Name} has been bought. HAVE FUN! (^_^) :)");
        }
    }
}
