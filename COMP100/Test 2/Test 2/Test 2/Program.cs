using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Tasks;

internal class Program
{

    //Question 1 

    static void DisplayResult(int num)
    {

       {
           if (num >= 90 && num <= 100)
           {
               Console.WriteLine("Letter Grade: A");
               Console.WriteLine("Excellen Work!");
           }

           else if (num >= 80 && num <= 89)

           {
               Console.WriteLine("Letter Grade: B");
               Console.WriteLine("Good Job!");
           }

           else if (num >= 70 && num <= 79)
           {
               Console.WriteLine("Letter Grade: C");
               Console.WriteLine("Satisfactory");
           }

           else if (num >= 60 && num <= 69)

           {
               Console.WriteLine("Letter Grade: D");
               Console.WriteLine("Needs Improvement");
           }

           else if (num >= 0 && num <= 59)

           {
               Console.WriteLine("Letter Grade: F");
               Console.WriteLine("Please see me after class");
           }

           else
           {
               Console.WriteLine("Invalid input! Please enter a number between 0 and 100");
           }
       }
    }

    private static void Main(string[] args)
    {
       Console.Write("Enter your grade (0-100): ");
       int grade = Convert.ToInt32(Console.ReadLine());

       DisplayResult(grade);
    }


    //Question 2

    static void DisplayUsersInfo(string UserName)
    {
       Console.WriteLine($"Username generated:{UserName}");
    }
    private static void Main(string[] args)
    {

       Console.WriteLine("Enter your first name: ");
       string firstName = Console.ReadLine();

       Console.WriteLine("Enter your last name: ");
       string lastName = Console.ReadLine();

       Console.WriteLine("Enter your date of birth (4 digits only): ");
       string dob = Console.ReadLine();

       if (dob.Length != 4)
       {
           Console.WriteLine("Invalid date of birth. Please enter 4 digits only");
       }

       else if (firstName != "")
       {
           Console.WriteLine("Invalid input! Please enter a valid first name and last name");
       }

       else if (lastName != "")
       {
           Console.WriteLine("Invalid input! Please enter a valid first name and last name");
       }
       else
       {
           string userName = firstName.ToLower().Substring(0, 3) + lastName.ToUpper().Substring(0, 2) + dob.Substring(0, 2);
           DisplayUsersInfo(userName);
       }
    }


    //Question 3 


    static double QuadraticEquation(double a, double b, double c)
    {
        double xNum1 = (-b + Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / (2 * a);
        return xNum1;
    }

    private static void Main(string[] args)
    {
        Console.Write("Enter coefficient a: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c1 = Convert.ToDouble(Console.ReadLine());

        double discriminantResult = Math.Pow(b1, 2) - 4 * a1 * c1;

        if (discriminantResult > 0)
        {
            double firstX = (-b1 + Math.Sqrt(Math.Pow(b1, 2) - 4 * a1 * c1)) / (2 * a1);
            double secondX = (-b1 - Math.Sqrt(Math.Pow(b1,2) - 4 * a1 * c1)) / (2 * a1);
            Console.WriteLine($"Two real solutions: {firstX} and {secondX}");
        }
        else if (discriminantResult == 0)
        {
            double x = (-b1 + Math.Sqrt(Math.Pow(b1,2) - 4 * a1 * c1)) / (2 * a1);
            Console.WriteLine($"One real solution: {x}");
        }
        else
        {
            Console.WriteLine("No real solutions exist.");
        }

        QuadraticEquation(a1, b1, c1);
    }


    //Question 4

    static void DisplayMenu()
    {
       Console.WriteLine("Menu:");
       Console.WriteLine("1. Addition");
       Console.WriteLine("2. Subtraction");
       Console.WriteLine("3. Multiplication");
       Console.WriteLine("4. Division");
       Console.WriteLine("5. Check if a number is odd or even");
       Console.WriteLine("6. Quit");
    }
    private static void Main(string[] args)
    {
       bool keepLooping = true;

       while (keepLooping)
       {

           DisplayMenu();

           Console.Write("Select an option (1-6): ");
           string usersOption = (Console.ReadLine());

           if (usersOption != "1" && usersOption != "2" && usersOption != "3" && usersOption != "4" && usersOption != "5" && usersOption != "6")

           {
               Console.WriteLine("Invalid input! Please enter a number between 1 and 6");
               continue;
           }

           else if (usersOption == "1")
           {
               Console.Write("Enter your first number: ");
               int num1 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter your second number: ");
               int num2 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine($"Result: {num1 + num2}");
           }
           else if (usersOption == "2")
           {
               Console.Write("Enter your first number: ");
               int num1 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter your second number: ");
               int num2 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine($"Result: {num1 - num2}");
           }
           else if (usersOption == "3")
           {
               Console.Write("Enter your first number: ");
               int num1 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter your second number: ");
               int num2 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine($"Result: {num1 * num2}");
           }
           else if (usersOption == "4")
           {
               Console.Write("Enter your first number: ");
               int num1 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter your second number: ");
               int num2 = Convert.ToInt32(Console.ReadLine());

               if (num2 == 0)
               {
                   Console.WriteLine("Cannot divide by zero");
               }
               else
               {
                   Console.WriteLine($"Result: {num1 / num2}");
               }

           }
           else if (usersOption == "5")
           {
               Console.Write("Enter your number: ");
               int num = Convert.ToInt32(Console.ReadLine());
               if (num % 2 == 0)
               {
                   Console.WriteLine($"{num} is an even number");
               }
               else
               {
                   Console.WriteLine($"{num} is an odd number");
               }
           }
           else if (usersOption == "6")
           {
               Console.WriteLine("Goodbye! Quitting program...");
               keepLooping = false;
               break;
           }
       }
    //}
}

