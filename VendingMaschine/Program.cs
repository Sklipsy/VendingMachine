// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.IO;
using System.Text;
using System.Threading;
using VendingMaschine;
using System.Reflection.Metadata;
using System.Globalization;
/*
DERRIVED = man skapar Tex child klass efter BAS klassen.
INHERIT = typ kopierar vidare värden ifrån BAS klassen till en TEX child klass
TO INHERIT = BAS klassen får värderna ifrån child klassen precis som att värderna ligger i (den tomma BAS klassen)
VIRTUAL = accepterar metoden/saker ifrån BAS klassen, för att bli överskriven i en child klass.
OVERRIDE = behövs om man kör virtual. Override på child klasserna. Virtual i BAS klassen.
INTERFACE = kontrakt. lite kort. interfacen kan innehålla tyå halvfärdiga värden. Man kan länka många child klasser till INTERFACEN innehåller ingen egen inplementering
interface: eftersom den är ett kontrakt är den auto public. Så ha ej public på resterande kod. Alltså på värdet och på void. Alla värderna den har kommer med klassen somär 

BAS klass kan bara ta emot en annan klass. Bas klassen kan ha en tom kropp.
ABSTRACT simulär till interfacen. Innehåller ingen inplementering alltså typ halvfärdiga värden. Kan bara länka ABSTRACT till tex childklass 1 gång.
POLYMORPHISM. Man typ bara ändrar om innehållet för att anpassa så att det ska fungera i andra klasser.
CHILD CLASS. Man kan sända runt data till många child klasser. Child klasser är typ funktioner utan parametrar. 
An abstract class can inherit from one base class.
An abstract class can implement multiple interfaces.
An abstract class can inherit from one base class.

callar ifrån abstract klassen eller interfacen då datan går ut ifrån void. andvänd base. keyword om man callar ifrån abstract om overiden krånglar.

constructor och base call = ingen override. annat kodningssätt. Alla värden i klasssen

https://www.bytehide.com/blog/abstract-class-vs-interface-csharp#How_to_Implement_Abstract_Classes_in_C

Ja, om du vill att det den funktionen gör ska göras istället för funktionen i basklassen kan du köra override på den bar
Annars om du vill att den funktionen ska göra samma sak för alla produkter behöver du inte ha den i denna klassen alls. Bara i basklassen

base.Examine(); callen = när man har grejjer ifrån bas klassen som man vill få över ifrån underklasserna till basklassen.

Andvänder mig av .base motoden ifrån med constructorn.
*/

namespace VendingMaschineSite
{
    public abstract class Product
    {
        public Product() //tom constructor.
        {
        }
        public int Kostnad { get; set; } 
        public int ProductID { get; set; } 
        public string Name { get; set; }
        public abstract void Use();
        public abstract void Examine();
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "Vending Maschine";
            //call
            var vendingMachineService = new VendingMachineService();
          //var product = new Product();
          //skapar ny lista på klasserna för att få tillgång i main
            var water = new Water();
            var coffee = new Coffee();
            var soda = new Soda();
            var chips = new Chips();
            var dildo = new Dildo();
             
            int response = 0;
            while (response != 6)
            {
                Console.WriteLine("Welcome to the vending machine ");
                Console.WriteLine("*Press 1 to see the snacks and drinks.(1) ");
                Console.WriteLine("Hit 2 to enter money into the Vending Machine(2) ");
                Console.WriteLine("Hit 3 to buy Goodies. (3) ");
                Console.WriteLine("Hit 4 to see how much money there is in the Vending-Machine. (4) ");
                Console.WriteLine("Hit 5 för att avsluta köp(5)");

                var alt = Console.ReadLine();
                int.TryParse(alt, out response);
                if (response == 1)
                {
                  
                    Console.WriteLine("TRYCK ENTER FÖR ATT SE RESULTAT AV SNACKS OCH DRYCKER ");
                    Console.ReadLine();
                    //Console.WriteLine($"{water.ProductID} {water.Name} {water.Kostnad} SEK");
                    //Console.WriteLine($"{coffee.ProductID} {coffee.Name} {coffee.Kostnad} SEK");
                    //Console.WriteLine($"{soda.ProductID} {soda.Name} {soda.Kostnad} SEK");
                    //Console.WriteLine($"{chips.ProductID} {chips.Name} {chips.Kostnad} SEK");
                    //Console.WriteLine($"{dildo.ProductID} {dildo.Name} {dildo.Kostnad} SEK");
                    vendingMachineService.ShowAll();
                }
                else if (response == 2)
                {                                        
                    Console.WriteLine("PLEASE SET THE AMOUNT YOU WANNA PUT IN MACHINE.");
                    var amount =  Console.ReadLine();
                    int x = int.Parse(amount); // konventera om string;;
                    //int.TryParse(amount, out);
                    vendingMachineService.AddMoney(x);                                                                       
                }
                else if (response == 3) 
                {
                    Console.WriteLine("skriv siffra för produkt mellan 1-5");
                    var res = Console.ReadLine();
                    int x =int.Parse(res);
                    if (x==1)
                    {
                        vendingMachineService.Purchase(new Water());
                    }
                    if (x == 2)
                    {
                        vendingMachineService.Purchase(new Coffee());
                    }
                    if(x==3)
                    {
                        vendingMachineService.Purchase(new Soda());
                    }
                    if(x==4)
                    {
                        vendingMachineService.Purchase(new Chips());
                    }
                    if(x==5)
                    {
                        vendingMachineService.Purchase(new Dildo());
                    }                    
                }
                else if (response ==4) 
                {
                    Console.WriteLine("ENTER FÖR ATT SE RESULTAT AV PENGAR KVAR");
                    Console.ReadLine();
                    vendingMachineService.MoneyLeft();

                }
                else if (response == 5)
                {
                    Console.WriteLine("Avsluta transaktionen");
                    Console.ReadLine();
                    vendingMachineService.EndTransaction();

                }
                else 
                {
                    Console.WriteLine("FEL VAL FÖRSÖK IGEN MELLAN ALTERNATIVERNA 1 - 4");
                }
                Console.ReadLine();
            }
        }
    }
}


