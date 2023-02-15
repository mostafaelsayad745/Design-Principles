
namespace Liskov_substitution_principle.After
{
    internal class CheckingAccount : RegularAccount
    {
        public CheckingAccount(string name , decimal balance) : base(name, balance) 
        {

        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine("you can't withdraw more than 1000");
                return;
            }
            Balance -= amount;
        }
    }
}
