using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Numerics;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

internal class Program
{

    //1) Write a program in C# Sharp to create a user defined function.
    // Expected Output:
    //Welcome Friends!
    //Have a nice day!

    //static void Welcome()
    //{
    //    Console.WriteLine("Welcome Friends!");
    //    Console.WriteLine("Have a nice day!");
    //}
    //private static void Main(string[] args)
    //{
    //    Welcome();
    //}

    //2. Write a program in C# Sharp to create a user defined function with parameters.
    //Test Data:
    //Please input a name: John
    //Expected Output:
    //Welcome friend John!
    //Have a nice day!

    //static void Welcome1 (string name)
    //{
    //    Console.WriteLine("Welcome friend " + name + "!");
    //    Console.WriteLine("Have a nice day!");
    //}

    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Please input a name: ");
    //    string name = Console.ReadLine();

    //    Welcome1(name);
    //}

    //3. Write a program in C# Sharp to create a function for the sum of two numbers.
    //Test Data:
    //Enter a number: 15
    //Enter another number: 16
    //Expected Output:
    //The sum of two numbers is: 31

    //static void Sum(int a, int b)
    //{
    //    Console.WriteLine("The sum of two numbers is: " + (a + b));
    //}

    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter a number: ");
    //    int num1 = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter another number: ");
    //    int num2 = Convert.ToInt32(Console.ReadLine());

    //    Sum(num1, num2);
    //}

    //4. Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.
    //Test Data:
    //Please input a string: This is a test string.
    //Expected Output:
    //"This is a test string." contains 4 spaces.

    //static void CountSpaces(string str)
    //{
    //    int count = 0;
    //    for (int i = 0; i < str.Length; i++)
    //    {
    //        if (str[i] == ' ')
    //        {
    //            count++;
    //        }
    //    }
    //    Console.WriteLine($"{str} contains {count} spaces");
    //}

    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Please input a series of strings: ");
    //    string stringput = Console.ReadLine();

    //    CountSpaces(stringput);
    //}

    //5. Write a program in C# Sharp to calculate the sum of elements in an array.
    //Test Data:
    //Input 5 elements in the array:
    //element - 0: 5
    //element - 1: 7
    //element - 2: 3
    //element - 3: 2
    //element - 4: 9
    //Expected Output:
    //The sum of the elements of the array is 26

    //static void SumArray(int[] arr)
    //{
    //    int sum = 0;
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        sum += arr[i];
    //    }
    //    Console.WriteLine("The sum of the elements of the array is " + sum);
    //}

    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Input 5 elements in the array: ");
    //    int[] arrList = new int[5];
    //    for (int i = 0; i < arrList.Length; i++)
    //    {
    //        Console.Write("element - " + i + ": ");
    //        arrList[i] = Convert.ToInt32(Console.ReadLine());
    //    }
    //    SumArray(arrList);
    //}

    //6. Write a program in C# Sharp to create a function to swap two integer numbers.
    //Test Data:
    //Enter a number: 5
    //Enter another number: 6
    //Expected Output:
    //Now the 1st number is: 6 , and the 2nd number is: 5

    //static void SwapNumbers(ref int a, ref int b)
    //{
    //    int temp = a;
    //    a = b;
    //    b = temp;
    //}
    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter a number: ");
    //    int num1 = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter another number: ");
    //    int num2 = Convert.ToInt32(Console.ReadLine());
    //    SwapNumbers(ref num1, ref num2);
    //    Console.WriteLine("Now the 1st number is: " + num1 + " , and the 2nd number is: " + num2);
    //}

    //7. Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
    //Test Data:
    //Input Base number: 3
    //Input the Exponent: 2
    //Expected Output:
    //So, the number 3 ^ (to the power) 2 = 9

    //static void Power(int x, int y)
    //{
    //    int result = 1;
    //    for (int i = 1; i <= y; i++)
    //    {
    //        result *= x;
    //    }
    //    Console.WriteLine("So, the number " + x + " ^ (to the power) " + y + " = " + result);
    //}
    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Input Base number: ");
    //    int num1 = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Input the Exponent: ");
    //    int num2 = Convert.ToInt32(Console.ReadLine());
    //    Power(num1, num2);
    //}

    //8. Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.
    //Test Data:
    //Input number of Fibonacci Series: 5
    //Expected Output:
    //The Fibonacci series of 5 numbers is:
    //0 1 1 2 3

    //static void Fibonacci(int n)
    //{
    //    int a = 0;
    //    int b = 1;
    //    int c = 0;
    //    Console.WriteLine("The Fibonacci series of " + n + " numbers is:");
    //    for (int i = 0; i < n; i++)
    //    {
    //        Console.Write(a + " ");
    //        c = a + b;
    //        a = b;
    //        b = c;
    //    }
    //}
    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Input number of Fibonacci Series: ");
    //    int num = Convert.ToInt32(Console.ReadLine());
    //    Fibonacci(num);
    //}

    //9. Write a program in C# Sharp to create a function to check whether a
    //number is prime or not.
    //Test Data:
    //Input a number: 31
    //Expected Output:
    //31 is a prime number

    //static void Prime(int n)
    //{
    //    bool isPrime = true;
    //    for (int i = 2; i <= n / 2; i++)
    //    {
    //        if (n % i == 0)
    //        {
    //            isPrime = false;
    //            break;
    //        }
    //    }
    //    if (isPrime)
    //    {
    //        Console.WriteLine(n + " is a prime number");
    //    }
    //    else
    //    {
    //        Console.WriteLine(n + " is not a prime number");
    //    }
    //}

    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Input a number: ");
    //    int num = Convert.ToInt32(Console.ReadLine());
    //    Prime(num);
    //}

    //10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
    //Test Data:
    //Enter a number: 1234
    //Expected Output:
    //The sum of the digits of the number 1234 is: 10

    //static void SumDigits(int n)
    //{
    //    int sum = 0;
    //    while (n != 0)
    //    {
    //        sum += n % 10;
    //        n /= 10;
    //    }
    //    Console.WriteLine("The sum of the digits of the number " + n + " is: " + sum);
    //}
    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter a number: ");
    //    int num = Convert.ToInt32(Console.ReadLine());
    //    SumDigits(num);
    //}

    //11. Write a program in C# Sharp to create a recursive function to find the
    //factorial of a given number.
    //Test Data:
    //Enter a number: 5
    //Expected Output:
    //The factorial of 5! is 120

    //static int Factorial(int n)
    //{
    //    if (n == 0)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        return n * Factorial(n - 1);
    //    }
    //}

    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter a number: ");
    //    int num = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("The factorial of " + num + "! is " + Factorial(num));
    //}

    //12. Write a program in C# Sharp to create a recursive function to calculate the
    //Fibonacci number of a specific term.
    //Test Data:
    //Enter a number: 10
    //Expected Output:
    //The Fibonacci of 10 th term is 55

    //static int Fibonacci(int n)
    //{
    //    if (n == 0)
    //    {
    //        return 0;
    //    }
    //    else if (n == 1)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        return Fibonacci(n - 1) + Fibonacci(n - 2);
    //    }
    //}

    //private static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter a number: ");
    //    int num = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("The Fibonacci of " + num + " th term is " + Fibonacci(num));
    //}

}

