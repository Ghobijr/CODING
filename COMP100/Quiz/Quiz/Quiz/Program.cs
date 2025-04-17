internal class Program
{
    private static void Main(string[] args)
    {
        string[] words = { "spiderman", "thor", "hulk"};
        Random random = new Random();
        string selectedWord = words[random.Next(words.Length)];
      
        DisplayIntro();

        StartGame(selectedWord);
    }

    private static void DisplayIntro()
    {
        Console.WriteLine("Welcome to the Word Guessing Game!");
    }

    private static void StartGame(string word)
    {
        int maxAttempts = 6;
        int currentAttempts = 0;
        bool isGuessCorrect = false;
        char[] guessedLetters = new char[0];
        decimal score = 0;

        while (currentAttempts > 0 && !isGuessCorrect)
        {
            DisplayWord(word, guessedLetters);
            Console.WriteLine($"\nPlease guess a letter! {currentAttempts}/{maxAttempts} lives remaining.");
            Console.Write("Your guess: ");
            char guess = Convert.ToChar(Console.ReadLine().ToLower());

            if (ProcessGuess(word, guessedLetters, guess))
            {
                Console.WriteLine("Correct!");
                score += 1.5m;
            }
            else
            {
                Console.WriteLine("Incorrect!");
                currentAttempts--;
            }

            isGuessCorrect = CheckIfWordComplete(word, guessedLetters);
        }

        GameResults(isGuessCorrect, score);
    }

    private static void DisplayWord(string word, List<char> guessedLetters)
    {
        foreach (char c in word)
        {
            if (guessedLetters.Contains(c))
                Console.Write($"{c} ");
            else
                Console.Write("_ ");
        }
        Console.WriteLine();
    }

    private static bool ProcessGuess(string word, List<char> guessedLetters, char guess)
    {
        if (!guessedLetters.Contains(guess))
            guessedLetters.Add(guess);

        return word.Contains(guess);
    }

    private static bool CheckIfWordComplete(string word, List<char> guessedLetters)
    {
        foreach (char c in word)
        {
            if (!guessedLetters.Contains(c))
                return false;
        }
        return true;
    }

    private static void GameResults(bool isGuessCorrect, decimal score)
    {
        if (isGuessCorrect)
        {
            Console.WriteLine("Congratulations, you win!");
        }
        else
        {
            Console.WriteLine("You lose...");
        }
    }
}


