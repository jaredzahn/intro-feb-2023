namespace Banking.Domain;


public enum LoyaltyLevel { Standard, Gold };


public class BankAccount
{
    //Class Variables:
    private decimal _balance;
    public LoyaltyLevel level;


    //Constructor:
    public BankAccount()
    {
        _balance = 500M;
    }


    //Helper Methods:
    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amountToDeposit)
    {
        decimal bonus = 0;
        if (level == LoyaltyLevel.Gold)
        {
            bonus = amountToDeposit * .10M;
        }
        _balance += amountToDeposit + bonus;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
       if (NotOverdraft(amountToWithdraw))
        {
            _balance -= amountToWithdraw;
        }
    }

    public bool NotOverdraft(decimal amountToWithdraw)
    {
        return (_balance >= amountToWithdraw);
    }

}
