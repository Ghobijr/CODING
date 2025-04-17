internal class Program
{
    private static void Main(string[] args)
    {
        //More Advanced loops
        //Develop a C# console application using do-while that repeatedly prompts the user to enter numerical values,
        //calculates the cumulative sum and average, and displays the results. The program should allow the user to input numbers
        //until they choose to stop by entering 'n'. The application must handle user input correctly and ensure the calculations
        //reflect the provided values. The final sum and average should be displayed at the end of the session.

        //1)

        //{

        //double sum = 0;
        //double average = 0;
        //int count = 0;
        //double inputtedNumber;
        //string usersInput;

        //do
        //{
        //    Console.WriteLine("Input a number: ");
        //    inputtedNumber = Convert.ToInt32(Console.ReadLine());
        //    sum += inputtedNumber;
        //    count++;

        //    Console.WriteLine("Do you want to enter another number? (y/n)");
        //    usersInput = Console.ReadLine();

        //}
        //while (usersInput.ToLower() == "y");

        //Console.WriteLine($"The total sum of your numbers is {sum}");
        //Console.WriteLine($"The average of your numbers is {sum / count:F2}");

        //    }
        //}


        //2) Create a C# console application using while that continuously prompts the user to enter integer values, calculates their
        //cumulative sum and average, and displays the results. The program should keep accepting numbers until the user chooses to stop by entering "no".
        //After exiting the loop, the program should display the total sum and the average of the entered numbers.
        //Ensure proper handling of user input to maintain accurate calculations.

        //int inputtedNumber;
        //double sum = 0;
        //int count = 0;
        //double average;
        //string usersInput = "y";

        //while (usersInput.ToLower() == "y")
        //{
        //    Console.WriteLine("Enter a number: ");
        //    inputtedNumber = Convert.ToInt32(Console.ReadLine());
        //    sum+=inputtedNumber;
        //    count++;

        //    Console.WriteLine("Do you want to continue (y/n)? ");
        //    usersInput = Console.ReadLine();
        //}

        //Console.WriteLine($"Your sum is {sum}");
        //average = sum / count;
        //Console.WriteLine($"Your average is {average}");

        //3) Convert the above example using a for loop (for (;; )).

        //double sum = 0;
        //int count = 0;
        //double average;
        //string usersInput = "y";
        //int inputtedNumber;

        //for (; ; )
        //{
        //    Console.WriteLine("Enter a number: ");
        //    inputtedNumber = Convert.ToInt32(Console.ReadLine());
        //    sum += inputtedNumber;
        //    count++;

        //    Console.WriteLine("Would you like to enter another number (y/n)? ");
        //    usersInput= Console.ReadLine();

        //    if (usersInput.ToLower() == "n")
        //    {
        //        break;
        //    }
        //}
        //Console.WriteLine($"The sum is {sum}");
        //average = sum / count;
        //Console.WriteLine($"The average is {average}");

        // Develop a C# console application that prompts the user to enter four integer values using a for loop.
        // The program should calculate the cumulative sum and average of the entered numbers and display the results after the loop completes.
        // Ensure that the program correctly tracks and processes user input, providing clear feedback on the entered values.

        //int num;
        //double sum = 0;
        //double average = 0;
        //int counter = 0;

        //for (int i = 0; i < 4; i++)
        //{
        //    Console.WriteLine("Enter a number: ");
        //    num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($"You have entered {num}");
        //    sum += num;
        //    counter++;
        //}

        //Console.WriteLine($"Sum is {sum}");
        //average = sum / 4;
        //Console.WriteLine($"Average is {average}");

    }

}
