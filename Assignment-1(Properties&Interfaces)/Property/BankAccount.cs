using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Property
{

    internal class BankAccount
    {
        public BankAccount(int accountNumber, string accountHolderName, decimal balance = 0)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }
        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balanace shouldn't be below Zero");
                }
                balance = value;
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount>0)
            {
                this.Balance += amount;
                Console.WriteLine($"Deposit Done!\nCurrent balance : {Balance} EGP.");
            }
            else
                Console.WriteLine("Deposit amount must be positive");
        }
        public void Withdrawal(decimal amount)
        {
            
            if (amount > 0)
            {
                if (Balance > amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawal Done!\nCurrent balance : {Balance} EGP.");
                }
                else
                    Console.WriteLine($"Insufficient balanace for this withdrawal {amount} EGP.\nCurrent balance : {Balance} EGP.");
            }
            else
                Console.WriteLine("Withdrwal amount must be positive");
        }
    }
}
