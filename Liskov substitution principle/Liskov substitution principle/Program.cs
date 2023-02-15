namespace Liskov_substitution_principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Before
            /*var account = new Before.FixedDepositeAccount("Mostafa", 100000);
            account.Withdraw(1000); // will give me an exception
            Console.ReadKey();*/

            // After
            //var account = new After.FixedDepositeAccount("Mostafa", 10000);
            //account.Withdraw(1000); // not allowed

            var account = new After.CheckingAccount("Mostafa", 10000);
            account.Withdraw(1000); // allowed

        }
    }
}