
namespace Banking.UnitTests;

public class StubbedBonusCalculator : ICanCalculateAccountBonuses
{
    public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
    {
        if (balance == 500M && amountToDeposit == 118.32M)
        {
            return 42.18M;
        }
        else
        {
            return 0;
        }
    }
}
