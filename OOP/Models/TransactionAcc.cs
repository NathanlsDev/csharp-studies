using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class TransactionAcc : Account
    {
        public override void Credit(decimal value)
        {
            Balance += value;
        }
    }
}