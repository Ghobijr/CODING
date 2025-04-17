using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Part A Question 1 Basics

        //Console.WriteLine("Hello");
        //Console.WriteLine("Joseph");

        //Question 2
        //int num1 = 6;
        //int num2 = 3;
        //int sum = num1 + num2;
        //Console.WriteLine($"The sum of {num1} and {num2} is {sum}");

        //Question 3
        //double num1 = 6;
        //double num2 = 5;
        //double division = num1 / num2;
        //Console.WriteLine($"{division:F2}");

        //Question 4
        //int num1 = 5;
        //int num2 = 6;
        //int num3 = num1;
        //num1 = num2;
        //num2 = num3;
        //Console.WriteLine("After Swapping");
        //Console.WriteLine($"First Number is {num1}");
        //Console.WriteLine($"First Number is {num2}");

        //Question 5
        //int num1;
        //int num2;
        //int num3;

        //Console.WriteLine("Please enter your first number: ");
        //num1=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter your second number: ");
        //num2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter your third number: ");
        //num3 = Convert.ToInt32(Console.ReadLine());

        //int multiplicationResult = num1 * num2 * num3;
        //Console.WriteLine($"The multiplication of {num1}, {num2} and {num3} are {multiplicationResult}");

        //Part B Question 1 Conditional Statements

        //int num1;
        //Console.WriteLine("Enter a number: ");
        //num1 = Convert.ToInt32(Console.ReadLine());

        //if (num1 < 0)
        //{
        //    Console.WriteLine($"{num1} is not a positive number");
        //}

        //else
        //{
        //    Console.WriteLine($"{num1} is a positive number");
        //}

        //Question 2

        //int num1;
        //Console.WriteLine("Enter a number: ");
        //num1 = Convert.ToInt32(Console.ReadLine());

        //if (num1 %2 == 0)
        //{
        //    Console.WriteLine($"{num1} is even");
        //}

        //else
        //{
        //    Console.WriteLine($"{num1} is odd");
        //}

        //Question 3

        //int num1;
        //int num2;
        //int num3;
        //int currentmax;

        //Console.WriteLine("Please enter your first number: ");
        //num1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter your second number: ");
        //num2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter your third number: ");
        //num3 = Convert.ToInt32(Console.ReadLine());

        //if (num1 > num2 && num1>num3)
        //{
        //     currentmax = num1;
        //}

        //else if (num2 > num3 && num2> num1)
        //{
        //     currentmax = num2;
        //}
        //else
        //{
        //     currentmax = num3;
        //}

        //Console.WriteLine($"The maximum number is {currentmax}");

        //Question 4

        //char vowel;

        //Console.WriteLine("Please enter a character: ");
        //vowel = Convert.ToChar(Console.ReadLine());

        //for (int i = 0; i < 1; i++)
        //{
        //    if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
        //    {
        //        Console.WriteLine($"{vowel} is a vowel");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{vowel} is a consonant");
        //    }
        //}

        //Question 5 

        //int side1;
        //int side2;
        //int side3;

        //Console.WriteLine("Please enter the first side of the triangle: ");
        //side1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter the second side of the triangle: ");
        //side2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please enter the third side of the triangle: ");
        //side3 = Convert.ToInt32(Console.ReadLine());

        //if (side1 != side2 && side2!=side3 && side1!=side3)
        //{
        //    Console.WriteLine("You have a Scalene Triangle");   
        //}
        //else if (side1 == side2 && side2 == side3)
        //{
        //    Console.WriteLine("You have an Equilateral Triangle");
        //}
        //else
        //{
        //    Console.WriteLine("You have an Isosceles Triangle");
        //}

        //Question 6 

        //int year;
        //Console.WriteLine("Enter a year: ");
        //year = Convert.ToInt32(Console.ReadLine());

        //if (year %4==0)
        //{
        //    Console.WriteLine($"{year} is a leap year ");
        //}

        //else
        //{
        //    Console.WriteLine($"{year} is not a leap year");
        //}

        //Question 7 

        //int grade;
        //Console.WriteLine("Enter your grade: ");
        //grade = Convert.ToInt32(Console.ReadLine());

        //if (grade >= 90)
        //{
        //    Console.WriteLine("A+");
        //}
        //else if (grade < 90 && grade>=80)
        //{
        //    Console.WriteLine("A");
        //}

        //else if (grade < 80 && grade >= 70)
        //{
        //    Console.WriteLine("B");
        //}

        //else if (grade < 70 && grade >= 60)
        //{
        //    Console.WriteLine("C");
        //}

        //else if (grade < 60 && grade >= 50)
        //{
        //    Console.WriteLine("D");
        //}
        //else
        //{
        //    Console.WriteLine("F");
        //}

        //Question 8

        //string username = "admin";
        //string password = "password";

        //Console.WriteLine("Enter your username: ");
        //username = Console.ReadLine();
        //Console.WriteLine("Enter your password: ");
        //password = Console.ReadLine();

        //if (username == username.ToLower() && password==password)
        //{
        //    Console.WriteLine("Valid username and password");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid username and password");
        //}

        //Question 9 

        //int num;
        //Console.WriteLine("Enter a number: ");
        //num = Convert.ToInt32(Console.ReadLine());

        //switch (num)
        //{
        //    case 1:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Tuesday");
        //        break;
        //    case 3:
        //        Console.WriteLine("Wednesday");
        //        break;
        //    case 4:
        //        Console.WriteLine("Thursday");
        //        break;
        //    case 5:
        //        Console.WriteLine("Friday");
        //        break;
        //    case 6:
        //        Console.WriteLine("Saturday");
        //        break;
        //    case 7:
        //        Console.WriteLine("Sunday");
        //        break;
        //}

        //Question 10

        //int month;
        //int year;
        //Console.WriteLine("Enter a month number (1-12): ");
        //month = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter a year: ");
        //year = Convert.ToInt32(Console.ReadLine());

        //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        //{
        //    Console.WriteLine("That month has 31 days ");
        //}

        //if (month == 4 || month == 6 || month == 9 || month == 11)
        //{
        //    Console.WriteLine(" That month has 30 days");
        //}

        //if (year % 4 == 0 && month == 2)
        //{
        //    Console.WriteLine("That month has 29 days");
        //}

        //else if (year % 4 != 0 && month == 2)
        //{
        //    Console.WriteLine("That month has 28 days");
        //}
    }
}
