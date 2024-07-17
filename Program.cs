Console.Clear();
Random secret = new();
int secretNumber = secret.Next(1, 101);
Console.WriteLine(@"Select a difficulty level:
(C)heater - Unlimited guesses
(E)asy - 8 guesses
(M)edium - 6 guesses
(H)ard - 4 guesses");
string difficulty = Console.ReadLine()?.ToUpper() ?? "C";
int guesses = 0;
if (difficulty == "E")
{
    guesses = 8;
}
else if (difficulty == "M")
{
    guesses = 6;
}
else if (difficulty == "H")
{
    guesses = 4;
};
int i = 0;
while (guesses - i > 0 || guesses == 0)
{
    Console.Write($"Guess the secret number {(guesses > 0 ? $"({guesses - i} {(guesses - i == 1 ? "guess" : "guesses")} remaining)" : "(unlimited guesses)")}: ");
    string userGuess = Console.ReadLine() ?? "";
    if (userGuess == secretNumber.ToString())
    {
        Console.WriteLine("You got it!");
        break;
    }
    else
    {
        i++;
        if (guesses - i == 0)
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