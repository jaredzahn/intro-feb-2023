namespace StringCalculator; 

public class StringCalculator
{

    private ILogger 

    public int Add(string numbers)
    {
        int answer = 0;
        if (numbers == "")
        {
            answer = 0;
        }
        else
        {
            answer = numbers.Split(',', '\n')
            .Select(int.Parse)
            .Sum();
        }
        // WTCYWYH
        _logger.Write(answer.ToString());
        return answer;
    }
}
