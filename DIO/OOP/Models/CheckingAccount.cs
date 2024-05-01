using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class CheckingAccount
    {
        public CheckingAccount(int account, decimal balance)
        {
            Account = account;
            Balance = balance;
        }

        public int Account { get; set; }
        private decimal Balance { get; set; }

        public void Withdraw (decimal value)
        {
            if (Balance < value)
            {
                Console.WriteLine($"Insufficient balance");
                return;
            }            
            Balance -= value;
            Console.WriteLine($"Withdraw with successful");            
        }

        public void CheckBalance ()
        {
            Console.WriteLine($"Your available balance is: {Balance}");
        }
    }
}