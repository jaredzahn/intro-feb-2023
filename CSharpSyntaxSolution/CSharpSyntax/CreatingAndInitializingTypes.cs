
namespace CSharpSyntax;

public class CreatingAndInitializingTypes
{
    [Fact]
    public void UsingLiteralsToCreateInstancesOfTypes()
    {
        //Initialize:
        string myName = "Jared";
        int myAge = 22;
        bool isLegalAgeToDrink = myAge >= 21;
        bool isVendor = true;

        //Act:
        Taco food = new Taco();

        //Assert:
        Assert.Equal("Jared", myName);
        Assert.Equal(22, myAge);
        Assert.True(isLegalAgeToDrink);
    }

    [Fact]
    public void ImplicitlyTypedLocalVariables()
    {
        // var can be used for local variables, and you must initialize the variable.
        var myLevel = 100;

        var myName = "Jared";

        var favoriteFood = new Taco();

        var myPay = 25.23M;

        //option in c# 6, pretty obscure:
        Taco lunch = new();
    }
}

public class Taco { }