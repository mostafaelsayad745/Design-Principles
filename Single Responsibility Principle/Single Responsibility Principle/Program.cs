using System;
using System.Diagnostics.Metrics;

namespace SOLID.SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP(); 
            TestWithSRP();
            Console.ReadKey();
        }


        private static void TestWithoutSRP()
        {
            var account =
                new Before.Account("Reem", "reem@example.com", 10000m);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }

        private static void TestWithSRP()
        {
            var account =
                new Single_Responsibility_Principle.After.Account("Reem", "reem@example.com", 10000m);

            var accountService = new Single_Responsibility_Principle.After.AccountService();
            accountService.Deposit(account, 500);
            accountService.WithDraw(account, 11000);
        }


    }
}