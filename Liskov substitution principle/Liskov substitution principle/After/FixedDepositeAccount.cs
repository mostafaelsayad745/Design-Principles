
namespace Liskov_substitution_principle.After
{
    internal class FixedDepositeAccount : Account
    {
        public FixedDepositeAccount(string name , decimal balance) :base(name , balance)
        {

        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
