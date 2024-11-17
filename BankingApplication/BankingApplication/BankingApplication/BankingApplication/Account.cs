

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    /// <summary>
    /// A general bank account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The current balance in the account
        /// </summary>
        private decimal balance;

        /// <summary>
        /// Constructs a new instance of Accont class with an initial balance
        /// </summary>
        /// <param name="initialBalance">The initial balance of the account which has to be 0 or greater</param>
        /// <exception cref="ArgumentException">Thrown when initial balanace is less than 0.</exception>
        public Account(decimal initialBalance) {
            if (initialBalance < 0.0m)
            {
                throw new ArgumentException("Initial balance must be positive.");
            }
            balance = initialBalance;
        }
        /// <summary>
        /// Gets the current balance of account
        /// </summary>
        public decimal Balance
        {
            get { return balance; }
        }
        /// <summary>
        /// Adds money to the account balance
        /// </summary>
        /// <param name="amount">The amount being added which must be positive</param>
        /// <exception cref="ArgumentException">Thrown when amount is negative</exception>
        public virtual void Credit(decimal amount)
        {
            if (amount < 0.0m)
            {
                throw new ArgumentException("Credit cannot be negative.");
            }
            balance += amount;
        }

        /// <summary>
        /// Withdraws money from the account balance if the sufficent funds are available
        /// </summary>
        /// <param name="amount">The amount to be withdrawn</param>
        /// <returns>True if the withdrawal was successful otherwise false</returns>
        /// <exception cref="ArgumentException">Thrown when debit amount is negative</exception>
        public virtual bool Debit(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Debit amount exceeded the account balance.");
                return false;
            }
            else if (amount < 0.0m) {
                throw new ArgumentException("Debit cannot be negative.");
            }
            else
            {
                balance -= amount;
                return true;
            }

        }
    }
}
