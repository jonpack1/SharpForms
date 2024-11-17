

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    /// <summary>
    /// A savings account with interest rate
    /// </summary>
    public class SavingsAccount : Account
    {
        /// <summary>
        /// The interest rate for the account
        /// </summary>
        private decimal interestRate;

        /// <summary>
        /// Constructs a new Savings account with an initial balance and interest rate
        /// </summary>
        /// <param name="initialBalance">The initial balance of the savings account</param>
        /// <param name="initialInterest">The interest rate for the account</param>
        /// <exception cref="ArgumentException">Thrown if interest rate is negative</exception>
        public SavingsAccount(decimal initialBalance, decimal initialInterest) : base(initialBalance)
        {
            if (initialInterest < 0.0m)
            {
                throw new ArgumentException("Interest rate cannot be negative.");
            }
            interestRate = initialInterest;
        } 
        /// <summary>
        /// Calculates the interest earned based on the balance and interest rate
        /// </summary>
        /// <returns>The calculated interest</returns>
        public decimal CalculateInterest()
        {
            return Balance * interestRate;
        }
    }
}
