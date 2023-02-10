using Banking.Domain;
using Banking.UnitTests;

namespace BankingKiosk
{
    public partial class Form1 : Form
    {
        private BankAccount _account;

        public Form1()
        {
            InitializeComponent();
            _account = new BankAccount(new StandardBonusCalculator(new StandardBusinessClock(new SystemTime())));
            UpdateBalanceDisplay();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DoTransaction(_account.Deposit);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            DoTransaction(_account.Withdraw);
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Anonymous Function (a method with no name) we call these "Lambdas" in C#, Arrow Function in JavaScript, etc.
            DoTransaction((amount) => MessageBox.Show("You clicked a button, blah" + amount.ToString()));
        }

        private void DoTransaction(Action<decimal> op)
        {
            try
            {
                var amount = decimal.Parse(amountInput.Text);
                op(amount);
                UpdateBalanceDisplay();
            }
            catch (FormatException)
            {
                var message = "Enter a #.";
                MessageBox.Show(message, "Error on Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AccountOverdraftException)
            {
                var message = "You don't have enough funds to withdraw requested amount.";
                MessageBox.Show(message, "Error in Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NoNegativeNumbersException)
            {
                var message = "No Negative Numbers Allowed.";
                MessageBox.Show(message, "Error in Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                amountInput.SelectAll();
                amountInput.Focus();
            }
        }

        private void UpdateBalanceDisplay()
        {
            this.Text = $"You have a balance of {_account.GetBalance():c} Currently";
        }

    }
}