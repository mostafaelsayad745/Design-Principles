using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Before
{
    internal class FixedDepositeAccount : Account
    {
        public FixedDepositeAccount(string name , decimal amount) :base(name, amount)
        {

        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            throw new NotSupportedException($"You can not withdraw from Fixed Deposit Account!!!");
        }
    }
}
