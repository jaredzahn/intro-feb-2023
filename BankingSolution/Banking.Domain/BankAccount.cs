namespace Banking.Domain;

public class BankAccount
{
    //Class Variables:
    private decimal _balance;
    private ICanCalculateAccountBonuses _bonusCalculator;

    //Constructor:
    public BankAccount(ICanCalculateAccountBonuses bonusCalc)
    {
        _balance = 500M;
        _bonusCalculator = bonusCalc;
    }

    //Helper Methods:
    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amountToDeposit)
    {
        //  Write the code you wish you had:
        decimal bonus = _bonusCalculator.GetDepositBonusFor(_balance, amountToDeposit);
        _balance += amountToDeposit;
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
