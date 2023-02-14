
namespace CSharpSyntax;

public class ClassesAndRecords
{

    [Fact]
    public void MutatingStuffIsBadSometimes()
    {
        // fake code getting from a database
        var me = GetCustomer();

        Assert.Equal("Jared", me.Name);
    }

    private Customer GetCustomer()
    {
        return new Customer
        {
            Name = "Jared",
            AvailableCredit = 3000
        };
    }
}

public record Customer
{
    public string Name { get; set; } = "";

    public decimal AvailableCredit { get; set; } = 3000;
}
