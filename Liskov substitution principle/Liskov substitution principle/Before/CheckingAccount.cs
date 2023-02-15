﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution_principle.Before
{
    internal class CheckingAccount : Account
    {
        public CheckingAccount(string name , decimal balance) : base(name,balance)
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
