using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class Account
    {
        private string name = "User";
        private decimal balance = 1000;

        public void ChangeName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                name = newName;
                Console.WriteLine($"Name successfully changed to: {name}");
            }
            else
            {
                Console.WriteLine("Error! Name cannot be empty!");
            }
        }

        public string GetName()
        {
            return name;
        }


        public bool Withdrawal(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Success! Remaining balance: {balance}");
                return true;
            }
            else
            {
                Console.WriteLine("Error! Insufficient funds!");
                return false;
            }
        }


        public bool Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Success! Remaining balance: {balance}");
            return true;
        }
    }
}
