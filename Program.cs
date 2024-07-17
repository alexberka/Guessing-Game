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
        if (i == 3)
        {
            Console.WriteLine($"The number was {secretNumber}");
        }
        else if (int.TryParse(userGuess, out int guessCompare))
        {
            if (guessCompare > secretNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Too low!");
            }
        }
        else
        {
            Console.WriteLine("Boo");
        }
    }
}