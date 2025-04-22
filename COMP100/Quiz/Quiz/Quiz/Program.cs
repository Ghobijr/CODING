using static System.Console;

namespace Quiz
{
    class WordGuessingGame
    {
        private readonly static string[] words = ["superman", "ironman", "batman"];
        private readonly static string secretWord = GetWord();

        private static int attempts = 5;

        private static char guessedLetter;
        private static bool guessStatus = false;
        static bool continuePlaying = false;
        private static char usersInput;

        private static void Main()
        {
            DisplayIntro();
        }

        static void DisplayIntro()
        {
            WriteLine("Welcome to the Word Guessing Game");
            WriteLine("1.Start 2.Exit");
            usersInput = Convert.ToChar(ReadLine()!);

            switch (usersInput)
            {
                case '1':
                    do
                    {
                        DisplayWord(secretWord, guessedLetter);
                    }
                    while (continuePlaying);
                    break;

                case '2':
                    WriteLine("Exiting the game. Goodbye!");
                    break;

                default:
                    WriteLine("Invalid action. Please enter 1 to start or 2 to exit.");
                    break;
            }

            //Methods

            static void DisplayWord(string secretWord, char guessedLetter)
            {
                char[] hiddenWord = new char[secretWord.Length];

                for (int i = 0; i < secretWord.Length; i++)
                {
                    hiddenWord[i] = '_'; //fills every hidden letter of the word with _
                }

                while (attempts > 0 && !guessStatus)
                {
                    WriteLine($"Word: {new string(hiddenWord)} Attempts remaining: {attempts}");

                    Write("Guess a letter: ");
                    guessedLetter = Convert.ToChar(ReadLine()!);
                    if (secretWord.Contains(guessedLetter))
                    {
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            if (secretWord[i] == guessedLetter)
                            {
                                hiddenWord[i] = guessedLetter;
                            }
                        }

                        if (new string(hiddenWord) == secretWord)
                        {
                            guessStatus = true;
                            WriteLine($"Congratulations! You've guessed the word {secretWord}.");
                        }
                    }
                    else
                    {
                        attempts--; //lowers the attempts the user has if incorrect letter added
                        WriteLine("Incorrect guess. Try again.");
                    }
                }
                if (attempts == 0 && !guessStatus)
                {
                    WriteLine($"Sorry, you've run out of attempts. The word was {secretWord}.");
                }

                Write("Do you want to play again? (Y/N): ");

                if (char.Parse(ReadLine()!.ToUpper()) == 'Y')
                {
                    Reset();
                }
                else continuePlaying = false;
                ReadKey(true);
            }
        }

        static string GetWord()
        {
            Random rand = new();
            string secretWord = words[rand.Next(words.Length)]; // words[1];
            return secretWord;
        }

        static void Reset()
        {
            guessStatus = false;
            continuePlaying = true;
            attempts = 5;
            Clear();
        }

    }

}


