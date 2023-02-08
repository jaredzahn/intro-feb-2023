namespace Banking.UnitTests;

public class MakingWithdrawals                                                        
{

    [Fact]
    public void MakingAWithdrawalDecreasesBalance()
    {
        //Arrange:
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdrawal = 100M;
        //Act:
        account.Withdraw(amountToWithdrawal);
        //Assert:
        Assert.Equal(openingBalance - amountToWithdrawal, account.GetBalance());
    }

    [Fact]
    public void OverdraftNotAllowed()
    {
        //Arrange:
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;
        //Act:
        account.Withdraw(amountToWithdraw);
        //Assert:
        Assert.Equal(openingBalance, account.GetBalance());
    }

}
