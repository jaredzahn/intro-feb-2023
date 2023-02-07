
using System.Text;

namespace CSharpSyntax;

public class CreatingAndInitializingTypes
{
    string thingy = "Birds";

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

        Assert.Equal(100, myLevel);
        Assert.IsType<Taco>(favoriteFood);
    }

    [Fact]
    public void CurlyBracescreateScopes()
    {
        Assert.Equal("Birds", thingy);

        var message = "";
        var age = 22;

        if (age >= 21) {
            message = "Old Enough";
        }

        Assert.Equal("Old Enough", message);
    }

    [Fact]
    public void MutableStringWithStringBuilders()
    {
        var message = new StringBuilder();

        foreach(var num in Enumerable.Range(1, 10000))
        {
            message.Append(num.ToString() + ", ");
        }
        Assert.True(message.ToString().StartsWith("1, 2, 3, 4"));
    }

}

public class Taco { }