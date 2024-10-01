using VendingMaschine;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new VendingMachineService();
            var water = new Water();
            var coffee = new Coffee();
            var soda = new Soda();
            var chips = new Chips();
            var dildo = new Dildo();
            test.Purchase(coffee);
            test.Purchase(soda);
            test.Purchase(chips);
            test.Purchase(dildo);
            test.Purchase(water);
        }
        [TestMethod]
        public void AddMoney()
        {
            var test = new VendingMachineService();
            try 
            {
                test.AddMoney(-6); //test
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.ToString);
            }
        }
        [TestMethod]
        public void EndTransaction()
        {
            var test = new VendingMachineService();
            
           // var totalPrise = new totalPrise();
           //var 
        }
    }
}