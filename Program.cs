Console.Clear();
Console.Write("Guess the secret number: ");
string userGuess = Console.ReadLine() ?? "";
Console.WriteLine($"You guessed {userGuess}");