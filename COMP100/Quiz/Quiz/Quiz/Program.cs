internal class Program
{
    private static void Main(string[] args)
    {
        string word = "spiderman";
        int maxLives = 7;

        DisplayInto();
        PlayGame(word, maxLives);
    }

    static void DisplayInto()
    {
        Console.WriteLine("Welcome to Guess the Word!");

    }

    private static void PlayGame(string word, int maxLives)
    {
        int currentLives = maxLives;
        bool win = false;
        List<char> guessedLetters = new List<char>();

        while (currentLives > 0 && !win)
        {
            DisplayWord(word, guessedLetters);
            Console.WriteLine("\nPlease guess a letter!");
            Console.WriteLine($"{currentLives}/{maxLives} lives remaining.");

            char guess = GetPlayerGuess();

            if (ProcessGuess(word, guessedLetters, guess))
                Console.WriteLine("Correct!");
            else
            {
                Console.WriteLine("Incorrect!");
                currentLives--;
            }

            win = CheckWinCondition(word, guessedLetters);
        }

        DisplayGameResult(win);
    }

    private static void DisplayWord(string word, List<char> guessedLetters)
    {
        foreach (char c in word)
        {
            if (guessedLetters.Contains(c))
                Console.Write(c);
            else
                Console.Write("_");
        }
    }

    private static char GetPlayerGuess()
    {
        return Convert.ToChar(Console.ReadLine());
    }

    private static bool ProcessGuess(string word, List<char> guessedLetters, char guess)
    {
        if (!guessedLetters.Contains(guess))
        {
            guessedLetters.Add(guess);
            return word.Contains(guess);
        }
        return false;
    }

    private static bool CheckWinCondition(string word, List<char> guessedLetters)
    {
        foreach (char c in word)
        {
            if (!guessedLetters.Contains(c))
                return false;
        }
        return true;
    }

    private static void DisplayGameResult(bool win)
    {
        if (win)
            Console.WriteLine("Congratulations, you win!");
        else
            Console.WriteLine("You lose...");
    }
}


