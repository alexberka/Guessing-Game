Console.Clear();
string secretNumber = "42";
Console.Write("Guess the secret number: ");
string userGuess = Console.ReadLine() ?? "";
if (userGuess == secretNumber)
{
    Console.WriteLine("You got it!");
}
else
{
    Console.WriteLine("Boo");
}