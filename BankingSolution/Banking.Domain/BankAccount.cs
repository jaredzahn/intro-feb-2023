namespace Banking.Domain;

public class BankAccount
{
    //Class Variables:
    private decimal _balance;


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
