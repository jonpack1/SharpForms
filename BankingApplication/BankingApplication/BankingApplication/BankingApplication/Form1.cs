

namespace BankingApplication
{
    public partial class Form1 : Form
    {
        private Account basicAccount;
        private SavingsAccount savingsAccount;
        private CheckingAccount checkingAccount;
        public Form1()
        {
            InitializeComponent();
            InitializeAccounts();
        }
        private void InitializeAccounts()
        {
            
            basicAccount = new Account(100.0m); 
            savingsAccount = new SavingsAccount(500.0m, 0.05m); 
            checkingAccount = new CheckingAccount(1000.0m, 2.0m); 

            UpdateBalances();
        }
        private void UpdateBalances()
        {
            lblBasicBalance.Text = $"Balance: {basicAccount.Balance:C}";
            lblSavingsBalance.Text = $"Balance: {savingsAccount.Balance:C}";
            lblCheckingBalance.Text = $"Balance: {checkingAccount.Balance:C}";
        }

        private void btnCreditBasic_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtCreditBasic.Text, out amount))
            {
                basicAccount.Credit(amount);
                UpdateBalances();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void btnDebitBasic_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtDebitBasic.Text, out amount))
            {
                if (basicAccount.Debit(amount))
                {
                    UpdateBalances();
                }
                else
                {
                    MessageBox.Show("Debit amount exceeded the account balance.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void btnCreditSavings_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtCreditSavings.Text, out amount))
            {
                savingsAccount.Credit(amount);
                UpdateBalances();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            decimal interest = savingsAccount.CalculateInterest();
            savingsAccount.Credit(interest);
            UpdateBalances();
        }

        private void btnCreditChecking_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtCreditChecking.Text, out amount))
            {
                checkingAccount.Credit(amount);
                UpdateBalances();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void btnDebitChecking_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtDebitChecking.Text, out amount))
            {
                if (checkingAccount.Debit(amount))
                {
                    UpdateBalances();
                }
                else
                {
                    MessageBox.Show("Debit amount exceeded the account balance.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        
    }
}
