namespace Banking.UnitTests;

public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveTheCorrectOpeningBalance()
    {
        var account = new BankAccount(new DummyBonusCalculator());

        decimal openingBalance = account.GetBalance();

        Assert.Equal(5000M, openingBalance);
    }
}
