
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    /// <summary>
    /// A checkings account with transaction fees
    /// </summary>
    public class CheckingAccount : Account
    {
        private decimal transactionFee;

        /// <summary>
        /// Concstructs a new Checkings account with an initial balance and a transaction fee
        /// </summary>
        /// <param name="initialBalance">initial balance of checkings account</param>
        /// <param name="fee">The fee to be charged for the transaction which must be positive</param>
        /// <exception cref="ArgumentException">Thrown when the fee is negative</exception>
        public CheckingAccount(decimal initialBalance, decimal fee) : base(initialBalance)
        {
            if(fee < 0.0m)
            {
                throw new ArgumentException("Transaction fee cannot be negative.");
            }
            transactionFee = fee;
        }
        /// <summary>
        /// Credits the account with an amount and deducts the transaction fee.
        /// </summary>
        /// <param name="amount">The amount to be credited to the account which must be positive</param>
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            base.Debit(transactionFee);
        }
        /// <summary>
        /// Withdraws money from the account and if successful deducts the transaction fee
        /// </summary>
        /// <param name="amount">The amount to be debited from the account which must be posititve</param>
        /// <returns>true if the debit is successful else false</returns>
        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                base.Debit(transactionFee);
                return true;
            }
            return false;

        }
    }
}
