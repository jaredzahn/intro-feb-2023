
//Variables:
DateTime startBreak = DateTime.Now;
DateTime endBreak;
TimeSpan breakLeft;
TimeSpan songCountdown;
var songFlag = false;
var initialColor = Console.BackgroundColor;

//User IO:
Console.WriteLine("Hello user, how many minutes will your break be?");
var breakDuration = int.Parse(Console.ReadLine());

Console.WriteLine("How long is the song you have chosen? (min:sec) ");
var songDuration = Console.ReadLine();
string[] song = songDuration.Split(":");
var songMin = int.Parse(song[0]);
var songSec = int.Parse(song[1]);

//Data Organization:
endBreak = startBreak + TimeSpan.FromMinutes(breakDuration);
var songStartTime = endBreak - TimeSpan.FromMinutes(songMin) - TimeSpan.FromSeconds(songSec);



//Iteration #1:
Console.WriteLine("");
Console.WriteLine("Iteration 1:");
Console.Write("Your break ends: ");
Console.WriteLine(endBreak.ToString());
Console.Write("Suggested start time for chosen song: ");
Console.WriteLine(songStartTime.ToString());
Console.Write("Press enter to move on...");
Console.ReadLine();
Console.Clear();

//Iteration #2:
while (DateTime.Now < endBreak)
{
    Console.Clear();
    Console.WriteLine("Iteration 2 & 3:");
    Console.WriteLine("");

    if (songFlag == true)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
    }

    breakLeft = endBreak - DateTime.Now;
    songCountdown = songStartTime - DateTime.Now;

    if (endBreak.CompareTo(DateTime.Now) > 0)
    {
        Console.WriteLine($"Time remaining in break:  {breakLeft.Minutes}:{breakLeft.Seconds}");
    }
    else
    {
        Console.WriteLine($"Break is over, get back to work!");
    }

    Console.WriteLine("");

    if (songStartTime.CompareTo(DateTime.Now) > 0)
    {
        Console.WriteLine($"Song should be started in: {songCountdown.Minutes}:{songCountdown.Seconds}");
    }else
    {
        Console.WriteLine($"Song should have already started by now!");
        songFlag = true;
    }
    Thread.Sleep(1000);
}

Console.BackgroundColor = initialColor;
Console.Clear();
Console.WriteLine("Iteration 4:");
Console.WriteLine("");
Console.WriteLine($"Break is over, get back to work!");

