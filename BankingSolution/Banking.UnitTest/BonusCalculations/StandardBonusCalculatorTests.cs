
namespace Banking.UnitTests.BonusCalculations;

public class StandardBonusCalculatorTests
{
    //1. Deposits under teh cutoff amount get no bonus. (5000)
    [Fact]
    public void UnderCutoffGetNoBonus()
    {
        ICanCalculateAccountBonuses calculator = new StandardBonusCalculator();

        var bonus = calculator.GetDepositBonusFor(4999.99M, 100);

        Assert.Equal(0, bonus);
    }

    //2. Deposits with 5000+ during Business Hours get a bonus.

    //3. Deposits with 5000+ outside of Buisiness Hours get no bonus.


}
