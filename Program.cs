Console.Clear();
string secretNumber = "42";
for (int i = 1; i <= 4; i++)
{
    Console.Write($"Guess the secret number (guess {i}/4): ");
    string userGuess = Console.ReadLine() ?? "";
    if (userGuess == secretNumber)
    {
        Console.WriteLine("You got it!");
        break;
    }
    else
    {
        Console.WriteLine("Boo");
    }
}