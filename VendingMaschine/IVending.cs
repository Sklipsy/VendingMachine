using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using VendingMaschineSite;
using static System.Runtime.InteropServices.JavaScript.JSType;
//for loop krinput
namespace VendingMaschine
{
    public interface IVending
    {
    //    void AddMoney();
    }

    // 1 int string obj
    // 2 new list typ skapar minne add()
    public class VendingMachineService
    {
        //funktioner. + all logik här
        // readonly int[] krinput = {1,5,10,20,50,100,500,1000};
        private List<Product> productInfo = new List<Product>();  //{ water, coffee, soda, chips, dildo }; for loop på readonly 
        private List<int> krinput;
        private int Am;
        private int Mp = +0;// MoneyPool
         public int[] Um = {1, 5, 10, 20, 50, 100, 500, 1000};
        public VendingMachineService()
        {
            //Produkter ifrån basklassen
            krinput = new List<int>(); 
            krinput.Add(1);
            krinput.Add(5);
            krinput.Add(10);
            krinput.Add(20);
            krinput.Add(50);
            krinput.Add(100);
            krinput.Add(500);
            krinput.Add(1000);          
        }
        public void AddMoney(int money) 
        {
          
            if (krinput.Contains(money)) 
            { Am += money; }//+
            else 
            {
                Console.WriteLine("det gick ej att lägga pengar på giltlig valuta 1,5,10,20,50,100,500,1000");
            }          
        }
        public void ShowAll() 
        {
            //list -> nya variabler på klasserna
            List<Product> products = new List<Product>();
            var water = new Water();
            var coffee = new Coffee();
            var soda = new Soda();
            var chips = new Chips();
            var dildo = new Dildo();
            products.Add(water);
            products.Add(coffee);  
            products.Add(soda); 
            products.Add(chips);
            products.Add(dildo);
            foreach (Product product in products) 
            {
               //Examine();
                product.Examine();
            } 
        }
        /*
        public void User() 
        {
            Um = 10000;
            Console.WriteLine($"{Um} SEK :-");
        }
        */
        public void Purchase (Product product)
        {
            productInfo.Add(product);            
        } 
        public void MoneyLeft() 
        {
            Console.WriteLine($"du har {Am} pengar kvar ");

        }
        public void EndTransaction() 
         {
            var totalPrise = productInfo.Sum(x => x.Kostnad);
            if (totalPrise > Am)
            { 
                throw new Exception("not e,60 " + "nough mUUUNEY "); 
            }
            Console.WriteLine("succesfully purchase.");
            Am -= totalPrise;
            Console.WriteLine($"du har {Am} pengar kvar "); 
        }
    }
}