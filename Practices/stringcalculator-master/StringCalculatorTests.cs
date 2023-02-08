
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void SingleDigit()
    {
        var calculator = new StringCalculator();

        var singleDigit = "5";

        var result = calculator.Add(singleDigit);

        Assert.Equal(int.Parse(singleDigit), result);
    }

    // commas only :

    [Fact]
    public void TwoSingleDigitsWithOnlyCommas()
    {
        var calculator = new StringCalculator();

        var twoSingleDigit = "1,2";

        var result = calculator.Add(twoSingleDigit);

        Assert.Equal(3, result);
    }

    [Fact]
    public void TwoDoubleDigitsWithOnlyCommas()
    {
        var calculator = new StringCalculator();

        var twoDoubleDigit = "15,25";

        var result = calculator.Add(twoDoubleDigit);

        Assert.Equal(40, result);
    }

    [Fact]
    public void FiveVaryingDigitsWithOnlyCommas()
    {
        var calculator = new StringCalculator();

        var fiveVaryingDigit = "15,25,3,8,20";

        var result = calculator.Add(fiveVaryingDigit);

        Assert.Equal(71, result);
    }

    // new lines only :

    [Fact]
    public void TwoSingleDigitsWithOnlyNewLines()
    {
        var calculator = new StringCalculator();

        var twoSingleDigit = "1\n2";

        var result = calculator.Add(twoSingleDigit);

        Assert.Equal(3, result);
    }

    [Fact]
    public void TwoDoubleDigitsWithOnlyNewLines()
    {
        var calculator = new StringCalculator();

        var twoDoubleDigit = "15\n25";

        var result = calculator.Add(twoDoubleDigit);

        Assert.Equal(40, result);
    }

    [Fact]
    public void FiveVaryingDigitsWithOnlyNewLines()
    {
        var calculator = new StringCalculator();

        var fiveVaryingDigit = "15\n25\n3\n8\n20";

        var result = calculator.Add(fiveVaryingDigit);

        Assert.Equal(71, result);
    }

    //new lines or commas:

    [Fact]
    public void FiveVaryingDigitsWithCommasAndNewLines()
    {
        var calculator = new StringCalculator();

        var fiveVaryingDigit = "15\n25,3\n8,20";

        var result = calculator.Add(fiveVaryingDigit);

        Assert.Equal(71, result);
    }

    [Fact]
    public void easyCustomDelimiter()
    {
        var calculator = new StringCalculator();

        var customDelimiter = "//+\n15,25+3\n5";

        var result = calculator.Add(customDelimiter);

        Assert.Equal(48, result);
    }
}
