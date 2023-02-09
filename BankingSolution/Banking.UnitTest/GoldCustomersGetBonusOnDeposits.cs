
namespace Banking.UnitTests;

public class GoldCustomersGetBonusOnDeposit
{
    [Fact]
    public void BonusAppliedToDeposit()
    {
        //Arrange
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        //Act:
        account.level = LoyaltyLevel.Gold;
        account.Deposit(amountToDeposit);
        //Assert:
        Assert.Equal(openingBalance + amountToDeposit + (amountToDeposit*.10M), account.GetBalance());
    }

}
