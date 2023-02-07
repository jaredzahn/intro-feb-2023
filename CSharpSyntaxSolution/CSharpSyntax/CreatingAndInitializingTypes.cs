
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

    [Fact]
    public void MoreAboutStrings()
    {
        var name = "Bob";
        var age = 33;
        var message = "The name is " + name + " and the age is " + age + ".";
        var message2 = string.Format("The name is {0} and the age is {1} (again, name: {0})", name, age);
        var pay = 120_000.00M;
        var m3 = $"{name} makes {pay:c} a year";
    }

    [Fact]
    public void DoingconversionsOnTypes()
    {
        string myPay = "10000.83";

        if (decimal.TryParse(myPay, out decimal payAsNumber))
        {
            Assert.Equal(10_000.83M, payAsNumber);
        } else
        {
            Assert.True(false); //it should error here.
        }

        var birthdate = DateTime.Parse("04/20/1969");
        Assert.Equal(4, birthdate.Month);
        Assert.Equal(20, birthdate.Day);
        Assert.Equal(1969, birthdate.Year);

    }

}

public class Taco { }