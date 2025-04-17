using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        //Question 21
        int num;
        int i = 0;
        int sum = 0;
        double average = 0;

        do
        {
           Console.Write("Please enter an integer (enter a negative number to exit):");
           num=Convert.ToInt32(Console.ReadLine());
           if (num >= 0)
           {
               sum += num;
               i++;
           }
        }
        while (num>0);

        average = sum / i;
        Console.WriteLine($"The sum of the positive integer entered is {sum} and the average of them is {average:F2}");

        //Question 22

        Random random = new Random();
        int num = random.Next(1,5);
        int inputNum;
        bool sameNumbertoGuess = false;
        do
        {
           Console.Write("Guess the number (between 1 and 5): ");
           inputNum = Convert.ToInt32(Console.ReadLine());

           if (inputNum < num)
           {
               Console.WriteLine("Tow low! Try again");
           }

           else if (inputNum > num)
           {
               Console.WriteLine("Too high! Try again");
           }
           else
           {
               Console.WriteLine($"Congratulations! You guessed the number");
               sameNumbertoGuess = true;
           }
        }
        while (inputNum!=num);

        //Question 23

        string password = "password123";
        string inputPassword;
        Console.Write("Enter the password: ");
        inputPassword = (Console.ReadLine());
        int attempts = 1;

        do
        {

           if (inputPassword != password)
           {
               Console.Write("Enter the password: ");
               inputPassword = (Console.ReadLine());
               attempts++;
           }
           else
           {
               Console.WriteLine("Successful Login!");
               break;
           }
        } while (attempts < 3);

        //Question 24

        int num;
        Console.Write("Please enter an integer number to calculate its factorial: ");
        num = Convert.ToInt32(Console.ReadLine());
        int result = num;

        int i = 1;
        while (i < num)
        {
           result *= i;
           i++;
        }
        Console.WriteLine($"The factorial of the number is {result}");

        //Question 25

        int num;
        int max= int.MinValue;
        int min= int.MaxValue;
        Console.Write("Enter a series of integers (ending with -1): ");
        num = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        while (num > 0)
        {
           if (num > max)
           {
               max = num;
           }

           else if (num < min)
           {
               min = num;
           }

           Console.Write("Enter a series of integers (ending with -1): ");
           num = Convert.ToInt32(Console.ReadLine());
           i++;

        }
        Console.WriteLine($"The largest number entered is {max}");
        Console.WriteLine($"The smallest number entered is {min}");

        //Question 26 Fiobonacci
        int inputednum;

        Console.WriteLine("Enter a number: ");
        inputednum = Convert.ToInt32(Console.ReadLine());

        int num1 = 1;
        Console.WriteLine($"{num1}");

        int num2 = 1;

        Console.WriteLine($"{num1}");

        int sum = 0;

        while (sum <= inputednum)
        {
           sum = num1 + num2;
           Console.WriteLine($"{sum}");

           num1 = num2;
           num2 = sum;
        }

        // Question 28 Methods

        int num1;
        Console.WriteLine("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        int num2;
        Console.WriteLine("Enter a 2nd number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        AddInteger(num1, num2);

        static void AddInteger(int num1, int num2)
        {
           int sum = num1 + num2;
           Console.WriteLine($"The sum of the two numbers is {sum}");
        }

        //Question 29 

           int[] numberArrays = { 1, 2, 3, 4, 5 };



           static void PrintArray(int[] numberArrays)
           {
               double average = 0;
               for (int i = 0; i < numberArrays.Length; i++)
               {
                   int sum = 0;
                   average = sum / numberArrays.Length;

               }

               Console.WriteLine($"The average of the array is {average}");
           }

    }

}



