using System.Security.Principal;
namespace CSharpSyntax;
public class Properties
{
    [Fact]
    public void WorkingWithTheAccount()
    {
        var account = new Account(); account.Name = "Bob"; // setting the name to "Bob":         Assert.Equal("Bob", account.Name); // Get the name from the object         account.Name = "Robert";         Assert.Equal(5000M, account.Balance);      //account.Balance = 100000;
        account.Deposit(1000);
        Assert.Equal(6000M, account.Balance); account.AccountNumber = 1000; Assert.Equal(1000, account.AccountNumber);
        // Properties:
        // Should not throw exceptions. 
        // Properties should return the same value every time you call them
        //  unless the user changed that value.
    }
}
public class Account
{
    // private data - "backing field"
    private string _name = ""; private decimal _balance = 5000M; public string Name // Property - they can get, set (or any other combination)
    {
        get { return _name; }
        set { _name = value; }
    }
    // This isn't really a language thing. It is a compiler directive that says:
    // Create a backing field for the account number.
    // Create the "get and set" methods to mutate and access that backing field.
    public int AccountNumber { get; set; }     // This is a bit smelly according to Jeff
    public decimal Balance
    {
        get { return _balance; }
    }
    public void Deposit(decimal amount)
    {

        AccountNumber += 1;
        _balance += amount;
    }
}