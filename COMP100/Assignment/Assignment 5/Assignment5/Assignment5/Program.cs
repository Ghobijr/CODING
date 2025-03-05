internal class Program
{
    private static void Main()
    {
        runMyCode();
    }
    static void runMyCode()
    {
        ////Task 1  Counting Game (For Loop)
        //int num;
        //int count;

        //Console.Write("Enter a number (5 & 15): ");
        //num = Convert.ToInt32(Console.ReadLine());

        //if (num >= 5 && num <= 15)
        //{
        //    Console.WriteLine($" You have selected {num}");

        //    for (count = 0; count < num; count++)
        //    {
        //        if ((count + 1) % 2 == 0)
        //        {
        //            Console.WriteLine($"{count + 1} Even Number");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{count + 1} Odd Number");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("You have entered a invalid number");
        //}



        //Task 2 Summation Game (Using While Loop)

        //int num = 0;
        //int total = 0;


        //while (num >= 0)
        //{
        //    Console.Write("Enter a number (negative to stop): ");
        //    num = Convert.ToInt32(Console.ReadLine());

        //    if (num >= 0)
        //    {
        //        total += num;
        //    }
        //}
        //Console.WriteLine($"Total Sum: {total}");


        //Task 3 Guessing Game(using Do-While Loop)

        //Random randomNumber = new Random();  //randamizer the number
        //int randomNum = randomNumber.Next(1, 10); //makes the randomizer pick numbers between (1-10)
        //int numGuess = 0;

        //do
        //{
        //    Console.Write("Guess the number (1-10): ");
        //    numGuess = Convert.ToInt32(Console.ReadLine());

        //    if (numGuess > randomNum)
        //    {
        //        Console.Write("Too high! Try again: ");
        //    }
        //    else if (numGuess < randomNum)
        //    {
        //        Console.Write("Too Low! Try again: ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Correct! You guessed it");
        //    }

        //} while (numGuess != randomNum); //if guess is not like the random number, keep looping




        //Task 4 Skipping Game (Using continue and break)

        //int num;

        //for (num = 1; num <= 20; num++)
        //{
        //    if (num % 4 == 0)
        //    {
        //        continue;
        //    }

        //    Console.WriteLine($"{num}");

        //    if (num == 15)
        //    {
        //        break;
        //    }
        //}


        //Task 5 Challenge

        Random randomNumber = new Random();
        int randomNum = randomNumber.Next(1, 10);
        int numGuess;
        int attempts = 0;
        int maxNumOfAttempts = 5;

        do
        {
            Console.Write("Guess the number (1-10): ");
            numGuess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (numGuess > randomNum)
            {
                Console.WriteLine("Too high! Try again: ");
            }
            else if (numGuess < randomNum)
            {
                Console.WriteLine("Too Low! Try again: ");
            }
            else
            {
                Console.WriteLine("Correct! You guessed it");
            }
        } while (numGuess != randomNum && attempts < maxNumOfAttempts);

        if (numGuess != randomNum)
        {
            Console.WriteLine($"Game Over! The number was {randomNum}");
        }

    }
}





