using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(1000);
            ba.Withdraw(500);
            Console.WriteLine($"{ba.AccountNumber}: {ba.Balance}");
        }
    }

    class BankAccount
    {
        private double _balance;
        private static readonly Random rnd = new Random();
        public static int TotalAccounts = 0;
        public readonly int AccountNumber;
       public double Balance
        {
            private set { _balance = value; }
            get { return _balance; }
        }
        public BankAccount(double balance)
        {
            Balance = balance;
            AccountNumber = rnd.Next(1000, 10000);
            TotalAccounts++;
        }
        public void Deposit(decimal amount) => Balance += Convert.ToDouble(amount);
        public void Withdraw (decimal amount)
        {
            double _amount = Convert.ToDouble(amount);
             if (_amount > Balance)
            {
                throw new ArgumentException("На счету не хвватает средств");
            }
            else { Balance -= _amount; }
            
            
        }

    }
}
