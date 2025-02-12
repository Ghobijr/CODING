//Question 1

int firstNumber;
int secondNumber;

Console.WriteLine("**************************************");
Console.WriteLine("*  Simple Concole Based Calculator   *");
Console.WriteLine("**************************************");

Console.Write("Please enter your first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");

Console.WriteLine("Please choose from the following options:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exit");
Console.Write("Please enter your choice: ");
int choice = Convert.ToInt32(Console.ReadLine());

int sumFirstAndSecondNumber = firstNumber + secondNumber;
int subFirstAndSecondNumber = firstNumber - secondNumber;
int multiFirstAndSecondNumber = firstNumber * secondNumber;
int divFirstAndSecondNumber = firstNumber / secondNumber;

switch (choice)
{
    case 1:
        Console.WriteLine($"The result of Addition is {sumFirstAndSecondNumber}");
        break;
    case 2:
        Console.WriteLine($"The result of Subtraction is {subFirstAndSecondNumber}");
        break;
    case 3:
        Console.WriteLine($"The result of Multiplication is {multiFirstAndSecondNumber}");
        break;
    case 4:
        Console.WriteLine($"The result of Division is {divFirstAndSecondNumber}");
        break;
    case 5:
        Console.WriteLine("See you soon :)");
        break;
    default:
        Console.WriteLine("Please enter 1,2,3,4 or 5");
        break;
}
Console.ReadKey();

//Question 2 

int num1;
int num2;
int num3;

Console.Write("Please enter your first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2 && num1 < num3)
{
    Console.WriteLine($"{num1} is the smallest");
}
else if (num2 < num1 && num2 < num3)
{
    Console.WriteLine($"{num2} is the smallest");
}
else if (num3 < num1 && num3 < num2)
{
    Console.WriteLine($"{num3} is the smallest");
}
Console.ReadKey();

//Question 3 

int num1;
int num2;

Console.Write("Please enter your first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == 0)
{
    Console.WriteLine("Divided by Zero error!");
}
else
{
    int divisionNum1Num2 = num1 / num2;
    Console.WriteLine($"The result of division is {divisionNum1Num2}");
}

Console.ReadKey();