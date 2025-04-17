using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

internal class Program //Practice 1 Display Information
{
   static void Main(string[] args) 
   {
     displayPersonalInformation();
   }
   static void displayPersonalInformation()
   {
       string name = "Joe";
       string program = "Software Engineering";
       string course = "COMP100";

       Console.WriteLine($"Name: {name}");
       Console.WriteLine($"Program: {program}");
       Console.WriteLine($"Favourite Course: {course}");
   }
}


internal class Program //Practice 2 Area of a Circle
{
   static void Main(string[] args) 
   {
       double argument1 = 1;
       double argument2 = 10;

       DisplayAreaOfCircle(argument1);
       DisplayAreaOfCircle(argument2);
   }

   static void DisplayAreaOfCircle(double radius)
   {
       double area = Math.PI * Math.Pow(radius, 2);
       Console.WriteLine($"The area of the circle with radius {radius} is: {area:F2}");

   }

}


internal class Program //Practice 3 Calculate Tax
{
   static void Main(string[] args) 
   {
       double price = 10;
       double tax = CalculateTax(price);
       Console.WriteLine($"The tax on the price is {tax:C}");
   }

   static double CalculateTax(double price)
   {
       double taxRate = .14;
       double tax = price * taxRate;
       return tax;
   }
}


internal class Program //Practice 4 Calculate Volume
{
   static void Main(string[] args) 
   {
       double volume = GetVolumeOfCube();
       Console.WriteLine($"The volume of the cube is {volume:F1}");
   }
   static double GetVolumeOfCube()
   {
       Console.WriteLine("What is the length of the Cube");
       double cubeLength = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("What is the width of the Cube");
       double cubeWidth = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("What is the height of the Cube");
       double cubeHeight = Convert.ToDouble(Console.ReadLine());

       double calculatedVolume = cubeLength * cubeWidth * cubeHeight;
       return calculatedVolume;

   }
}

//1. Write a program in C# Sharp to create a user defined function.
//Expected Output :
//Welcome Friends!
//Have a nice day!

internal class Program //https://www.w3resource.com/csharp-exercises/function/index.php practices

{
   static void Main(string[] args) 

   {
       WelcomeFriends();
   }

   static void WelcomeFriends()
   {
       Console.WriteLine("Welcome Friends!");
       Console.WriteLine("Have a great day!");
   }


}


//2.Write a program in C# Sharp to create a user defined function with parameters.
//Test Data :
//Please input a name : John
//Expected Output :
//Welcome friend John !
//Have a nice day!

internal class Program
{

   static void Main(string[] args)

   {
       Console.Write("Please input your name:");
       string name = Console.ReadLine();

       WelcomedName(name);
   }

   static void WelcomedName(string name)
   {
       Console.WriteLine($"Welcome friend {name} !");
       Console.WriteLine("Have a nice day!");
   }

}

//3.Write a program in C# Sharp to create a function for the sum of two numbers.
//Test Data :
//Enter a number: 15
//Enter another number: 16
//Expected Output :
//The sum of two numbers is : 31


internal class Program
{
   static void Main(string[] args)

   {
       Console.WriteLine("Enter a number: ");
       int num1 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter another number: ");
       int num2 = Convert.ToInt32(Console.ReadLine());

       int sum = SumOfTwoNumbers(num1, num2);

       Console.WriteLine($"The sum of two numbers is: {sum} ");
   }

   static int SumOfTwoNumbers(int num1, int num2)
   {
       return num1 + num2;
   }
}

//4.Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.
//Test Data :
//Please input a string : This is a test string.
//Expected Output :
//"This is a test string." contains 4 spaces


internal class Program
{
   static void Main(string[] args)

   {
       Console.WriteLine($"Please input a string: ");
       string inputString = Console.ReadLine();

       int spaceCount = CountSpacesInString(inputString);

       Console.WriteLine($"{inputString} contains {spaceCount} spaces");

   }
   static int CountSpacesInString(string input)
   {
       int spaceCount = 0;
       int counter = 0;

       for (counter = 0; counter < input.Length; counter++)  //counter < input.Length is for when counter is less than the length of the string
       {
           if (input[counter] == ' ')
           {
               spaceCount++;
           }
       }
   return spaceCount;
   }

}

//5.Write a program in C# Sharp to calculate the sum of elements in an array.
//Test Data :
//Input 5 elements in the array :
//element - 0 : 5
//element - 1 : 7
//element - 2 : 3
//element - 3 : 2
//element - 4 : 9
//Expected Output :
//The sum of the elements of the array is 26

internal class Program
{
   static void Main(string[] args)

   {
       int size = 5;
       int[] array = new int[5];

       Console.WriteLine("Input 5 elements in the array: ");
       for (int i = 0; i < size; i++)
       {
           Console.Write($"element - {i} : ");
           array[i] = Convert.ToInt32(Console.ReadLine());
       }
       Console.WriteLine($"The sum of the elements of the array is {SumOfArray(array)}");

   }
   static int SumOfArray(int[] array)
   {
       int totalSum = 0;
       int count = 0;

       for (count = 0; count < array.Length; count++)
       {
           totalSum += array[count];
       }
       return totalSum;
   }
}

//6.Write a program in C# Sharp to create a function to swap two integer numbers.
//Test Data :
//Enter a number: 5
//Enter another number: 6
//Expected Output :
//Now the 1st number is : 6 , and the 2nd number is : 5

internal class Program
{
   static void Main(string[] args)

   {
       Console.WriteLine("Enter a number: ");
       int num1 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter a number: ");
       int num2 = Convert.ToInt32(Console.ReadLine());

       SwapNumbers(ref num1,ref num2);

       Console.WriteLine($"Now the 1st number {num1} and the 2nd number is {num2} ");
   }

   static void SwapNumbers( ref int num1, ref int num2) //ref is used to pass the reference of the variable
   {
       int newnum; 
       newnum = num1;
       num1 = num2;
       num2 = newnum;    
   }
}

//7.Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
//Test Data :
//Input Base number: 3
//Input the Exponent : 2
//Expected Output :
//So, the number 3 ^ (to the power) 2 = 9

internal class Program
{
   static void Main(string[] args)

   {
       Console.WriteLine("Enter a base number: ");
       int baseNum = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter a Exponent number: ");
       int exponentNum = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine($"So, the number {baseNum} ^ (to the power) {exponentNum} = {CalculateExponent (baseNum, exponentNum)}");

   }
   static int CalculateExponent(int baseNum, int exponentNum)
   {
       int result = 1;
       for (int i = 1; i <= exponentNum; i++)
       {
           result *= baseNum;  //1*2=2, 2*2=4, 4*2=8
       }

       return result;
   }
}

//8.Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.
//Test Data :
//Input number of Fibonacci Series : 5
//Expected Output :
//The Fibonacci series of 5 numbers is :
//0 1 1 2 3

internal class Program
{
   static void Main(string[] args)

   {
       Console.WriteLine("Input number of Fibonacci Series: ");
       int num = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine($"The Fibonacci series of {num} numbers is: ");
       FibonacciSeries(num);

   }
       static void FibonacciSeries(int numF)
       {
           int num1 = 0;
           int num2 = 1;
           int num3;

           for (int i = 0; i < numF; i++)
           {
               Console.Write(num1 + " ");

               num3 = num1 + num2;
               num1 = num2;
               num2 = num3;
           }
           Console.WriteLine();
       }
}



//Assignment using Methods
//1) Write a method with the following specifications:
//name: DisplayMenu
//arguments: none
//return value: none
//tasks: display the following menu choice on the screen
//Calculation Menu
//3) Calculate Sum
//4) Calculate Sum of Squares
//5) Calculate Sum of Cubes
//0) To Exit
//Enter the number that corresponds to your choice:
//You may beautify the output to your own likings. You don’t have to implement the functionalities of the
//various menu choices at this stage


using System;

class Program
{
   static void Main()
   {
       DisplayMenu();
   }
   static void DisplayMenu()
   {
       Console.WriteLine("3) Calculate Sum");
       Console.WriteLine("4) Calculate Sum of Squares");
       Console.WriteLine("5) Calculate Sum of Cubes");
       Console.WriteLine("0) To Exit");
       Console.WriteLine("==============================");
       Console.Write("Enter the number that corresponds to your choice: ");
       int num = Convert.ToInt32(Console.ReadLine());

       switch (num)
       {
           case 3:
               Console.WriteLine("You have selected Calculate Sum");
               break;
           case 4:
               Console.WriteLine("You have selected Calculate Sum of Squares");
               break;
           case 5:
               Console.WriteLine("You have selected Calculate Sum of Cubes");
               break;
           case 0:
               Console.WriteLine("You have selected To Exit");
               break;
           default:
               Console.WriteLine("Invalid choice");
               break;
       }
   }
}


//2) Modify your main so that the above method is call repeatedly.
//The program will terminate when the user enters 0. Any other
//choice should produce an error message. Because you will not
//be doing any arithmetic you may accept the user response
//either as an int, or a char or a string.


//using System;

class Program
{
   static void Main()
   {
       string choice;
       do
       {
           DisplayMenu();
           Console.Write("Enter the number that corresponds to your choice: ");
           choice = Console.ReadLine();

           switch (choice)
           {
               case "3":
                   Console.WriteLine("You have selected: Calculate Sum");
                   break;
               case "4":
                   Console.WriteLine("You have selected: Calculate Sum of Squares");
                   break;
               case "5":
                   Console.WriteLine("You have selected: Calculate Sum of Cubes");
                   break;
               case "0":
                   Console.WriteLine("You have selected: Exit");
                   break;
               default:
                   Console.WriteLine("Invalid choice. Please enter a valid option.");
                   break;
           }
           Console.WriteLine();
       } while (choice != "0");
   }

   static void DisplayMenu()
   {
       Console.WriteLine("==============================");
       Console.WriteLine("         Calculation Menu         ");
       Console.WriteLine("==============================");
       Console.WriteLine("3) Calculate Sum");
       Console.WriteLine("4) Calculate Sum of Squares");
       Console.WriteLine("5) Calculate Sum of Cubes");
       Console.WriteLine("0) To Exit");
       Console.WriteLine("==============================");
   }
}

//3. Write a method with the following specifications:
//name: CalculateSum
//arguments : a single int representing the number of inputs that will constitute the sum
//return value : int representing the sum of all the user inputs
//displays : only the prompt for the user inputs, but does not display the sum
//tasks : prompt and accepts inputs (as many as specified by the argument), and sum them, Finally
//the method will return the sum of all the inputs (the sum)
//In your main you will call this method when the user enters 3 in response to the menu choices. You will
//invoke this method with argument 5 and then display the resulting value from the method.

class Program
{
   static void Main()
   {
       string choice;
       do
       {
           DisplayMenu();
           Console.Write("Enter the number that corresponds to your choice: ");
           choice = Console.ReadLine();

           switch (choice)
           {
               case "3":
                   // Call the CalculateSum method with argument 5
                   int sum = CalculateSum(2);
                   Console.WriteLine("The sum of the inputs is: " + sum);
                   break;
               case "4":
                   Console.WriteLine("You have selected: Calculate Sum of Squares");
                   break;
               case "5":
                   Console.WriteLine("You have selected: Calculate Sum of Cubes");
                   break;
               case "0":
                   Console.WriteLine("You have selected: Exit");
                   break;
               default:
                   Console.WriteLine("Invalid choice. Please enter a valid option.");
                   break;
           }
           Console.WriteLine();
       } while (choice != "0");
   }

   static void DisplayMenu()
   {
       Console.WriteLine("==============================");
       Console.WriteLine("         Calculation Menu         ");
       Console.WriteLine("==============================");
       Console.WriteLine("3) Calculate Sum");
       Console.WriteLine("4) Calculate Sum of Squares");
       Console.WriteLine("5) Calculate Sum of Cubes");
       Console.WriteLine("0) To Exit");
       Console.WriteLine("==============================");
   }

//    // Method to calculate the sum of user inputs
   static int CalculateSum(int numberOfInputs)
   {
       int sum = 0;

       // Prompt the user for the specified number of inputs
       Console.WriteLine("Please enter " + numberOfInputs + " numbers:");

       // Accept inputs and sum them
       for (int i = 1; i <= numberOfInputs; i++)
       {
           Console.Write("Enter number " + i + ": ");
           if (int.TryParse(Console.ReadLine(), out int input))
           {
               sum += input;
           }
           else
           {
               Console.WriteLine("Invalid input. Please enter a valid integer.");
               i--; // Decrease the counter to retry the same input
           }
       }

       // Return the sum of all inputs
       return sum;
   }
}


