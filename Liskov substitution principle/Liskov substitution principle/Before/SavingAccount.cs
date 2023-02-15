namespace Liskov_substitution_principle.Before
{
    internal class SavingAccount : Account
    {
        public SavingAccount(string name , decimal amount): base(name, amount)
        {

        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
