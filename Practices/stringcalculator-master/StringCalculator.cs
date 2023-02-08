
namespace StringCalculator;

public class StringCalculator
{
    private int result = 0;

public int Add(string numbers)
    {
        
        if (numbers == "")
        {
            //empty string:
            result = 0;
        }
        else if (numbers.Length == 1)
        {
            //single digit:
            result = int.Parse(numbers);

        }
        else if (numbers.Substring(0,2) == "//")
        {
            //custom delimiter:
            Char cd = numbers.ToCharArray().ElementAt(2);
            string onlyNumbers = numbers.Substring(4);
            result = onlyNumbers.Split(new Char[] { ',', '\n', cd }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(x => int.Parse(x)).Sum();
        }
        else
        {
            //no custom delimiter:
            result = numbers.Split(new Char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(x => int.Parse(x)).Sum();
        }

        return result;
    }
}
