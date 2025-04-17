using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Net.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        Welcome(userName);

        Console.WriteLine("\nArithmetic Operations");
        Console.Write("Enter your first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        ArithmeticOperation(num1, num2);

        Console.WriteLine("\nArea of a Circle");
        Console.Write("Enter the radius of your circle: ");
        double radius = Convert.ToDouble((Console.ReadLine()));
        Console.WriteLine($"The area of circle result: {CalculateCircleArea(radius):F2}");

        Console.WriteLine("\nPower Calculation");
        Console.Write("Enter a base number: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a exponent: ");
        double exponentNum = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{baseNum} to the power of {exponentNum} is: {RaiseToPower(baseNum, exponentNum)}");

        for (int i = 1; i <= 1; i++)
        {
            double result = Math.Pow(baseNum, exponentNum);
            Console.WriteLine($"{baseNum} to the power of {exponentNum} is: {result} (Loop)");
        }

        Console.WriteLine("\nPrime Number Checker");
        Console.Write("Enter a number to check if it is prime: ");
        int primeNumber = Convert.ToInt32(Console.ReadLine());
        isPrime(primeNumber);

        Goodbye();
    }
    static void Welcome(string userName)

    {
        Console.WriteLine($"Hello {userName}.Welcome to the Amazing Calculator Adventure");
    }

    static void ArithmeticOperation(int num1, int num2)
    {
        Console.WriteLine($"Addition result: {num1 + num2}");
        Console.WriteLine($"Subtraction result: {num1 - num2}");
        Console.WriteLine($"Multiplication resulte: {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"Division result: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Division result: Invalid, you cannot divide by zero");
        }
    }

    static double CalculateCircleArea(double radius)

    {
        double area = Math.PI * (Math.Pow(radius, 2));
        return area;
    }

    static double RaiseToPower(double baseNum, double exponentNum)
    {
        double result = Math.Pow(baseNum, exponentNum);
        return result;
    }

    static void isPrime(int primeNumber)
    {
        if (primeNumber <= 1)
        {
            Console.WriteLine($"{primeNumber} is not a prime number");
        }

        else if (primeNumber % 2 == 0)
        {
            Console.WriteLine($"{primeNumber} is not a prime number");
        }

        else if (primeNumber == 2)
        {
            Console.WriteLine($"{primeNumber} is a prime number");
        }

        else
        {
            Console.WriteLine($"{primeNumber} is a prime number");
        }
    }

    static void Goodbye()
    {
        Console.WriteLine("\nThank you for using the Amazing Calculator. Goodbye.");
    }

}

