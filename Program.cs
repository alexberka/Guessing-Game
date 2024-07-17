Console.Clear();
Random secret = new();
int secretNumber = secret.Next(1, 101);
for (int i = 0; i < 4; i++)
{
    Console.Write($"Guess the secret number ({4 - i} {(i == 3 ? "guess" : "guesses")} remaining): ");
    string userGuess = Console.ReadLine() ?? "";
    if (userGuess == secretNumber.ToString())
    {
        Console.WriteLine("You got it!");
        break;
    }
    else
    {
        Console.WriteLine("Boo");
        if (i == 3) { Console.WriteLine($"The number was {secretNumber}"); }
    }
}