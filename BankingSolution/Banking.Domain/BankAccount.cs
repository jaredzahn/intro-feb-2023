namespace Banking.Domain;

public class BankAccount
{
    //Class Variables:
    private decimal _balance;
    private ICanCalculateAccountBonuses _bonusCalculator;

    //Constructor:
    public BankAccount(ICanCalculateAccountBonuses bonusCalc)
    {
        _balance = 5000M;
        _bonusCalculator = bonusCalc;
    }

    //Helper Methods:
    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amountToDeposit)
    {
        //guard:
        GuardNoNegativeAmountsForTransactions(amountToDeposit);
        //  Write the code you wish you had:
        decimal bonus = _bonusCalculator.GetDepositBonusFor(_balance, amountToDeposit);
        _balance += amountToDeposit + bonus;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        //guards:
        GuardNoNegativeAmountsForTransactions(amountToWithdraw);
        GuardNoOverdraft(amountToWithdraw);

        _balance -= amountToWithdraw;
    }

    private void GuardNoOverdraft(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            throw new AccountOverdraftException();
        }
    }

    private static void GuardNoNegativeAmountsForTransactions(decimal amountToDeposit)
    {
        if (amountToDeposit < 0)
        {
            throw new NoNegativeNumbersException();
        }
    }

}
