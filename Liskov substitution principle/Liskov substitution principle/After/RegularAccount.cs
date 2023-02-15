
namespace Liskov_substitution_principle.After
{
    abstract class RegularAccount : Account
    {
        protected RegularAccount(string name, decimal balance) :base(name, balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; set; }
        public decimal Balance { get; set; }

        public abstract void Withdraw(decimal amount);
    }
}
