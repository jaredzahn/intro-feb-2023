namespace Banking.UnitTests;

public class MakingDeposits
{

    [Fact]
    public void DepositingMoneyIncreasesTheBalance()
    {
        //Arrange
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        //Act:
        account.Deposit(amountToDeposit);
        //Assert:
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }

}
