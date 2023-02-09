
namespace Banking.UnitTests;

public class GoldCustomersGetBonusOnDeposits
{
    [Fact]
    public void BonusAppliedToDeposit()
    {
        //Arrange:
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        //Act:
        account.Deposit(amountToDeposit);

        //Assert:
        Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());
    }

}
