//Task 1 User Input & Output =======================================================================
string first_Name = "";
string last_Name = "";
string full_Name = first_Name + last_Name;
int age;

Console.WriteLine("Enter your full name please");
full_Name = Console.ReadLine();

Console.WriteLine("Enter your age");
age = Convert.ToInt32(Console.ReadLine());

Console.Write($"Greetings {full_Name}, you are {age} years old");

Console.ReadKey();

//Task 2  Data Conversion & Arithmetic Operations =======================================================================
int num1;
int num2;
char add_Multiply;

Console.WriteLine("Please your first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please your second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Please enter 'A' for addition or 'M' for Multiplication: ");
add_Multiply = Convert.ToChar(Console.ReadLine());

if (add_Multiply == 'A' || add_Multiply == 'a')
{
    Console.WriteLine($"Your result of your addition is: {num1 + num2} ");
}
else if (add_Multiply == 'M' || add_Multiply == 'm')
{
    Console.WriteLine($"Your result of your multiplication is: {num1 * num2} ");
}
else
{
    Console.WriteLine($"Incorrect Input. Please only enter 'A' or 'M'");
}

Console.ReadKey();

//Task 3 Even or Odd Check=======================================================================

int numb;

Console.WriteLine("Enter a number: ");
numb = Convert.ToInt32(Console.ReadLine());

if (numb % 2 == 0)
{
    Console.WriteLine($"{numb} is an even number ");
}

else
{
    Console.WriteLine($"{numb} is an odd number ");
}

Console.ReadKey();

//Task 4 Age Validation =======================================================================

int age;

Console.WriteLine("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

if (age >= 0 && age <= 120)
{
    Console.WriteLine($"Your age is {age}");
}
else
{
    Console.WriteLine($"Invalid age. Please enter a number between 0 and 120");
}

Console.ReadKey();

//Task 5 Boolean Evaluation =======================================================================

bool true_false;

Console.WriteLine("Have you completed your assignment? (True/False)? Answer accordingly please.");
true_false = Convert.ToBoolean(Console.ReadLine());

if (true_false)
{
    Console.WriteLine($"Great job on finishing your assignment, Woohoo. ");
}

else
{
    Console.WriteLine($"Oh no, you did not finish your assignment, better hit the books again.");
}

Console.ReadKey();

//Task 6 Grading System =======================================================================

int score;

Console.WriteLine("What score did you get on your exam?");
score = Convert.ToInt32(Console.ReadLine());
if (score <= 100 && score >= 90)
{
    Console.WriteLine($"You got an A, Excellent!");
}
else if (score <= 89 && score >= 75)
{
    Console.WriteLine($"You got an B, Good Job!");
}
else if (score <= 74 && score >= 50)
{
    Console.WriteLine($"You got an C, Needs Improvement.");
}
else
{
    Console.WriteLine($"You got an F, You have failed.");
}
Console.ReadKey();

//Task 7 Time-Based Greeting ======================================================================= Task if we were taught about this.

int time = DateTime.Now.Hour;
int min = DateTime.Now.Minute;

if (time >= 0 && time <= 11)
{
    Console.WriteLine($"The time is {time}:{min} Good Morning");
}
else if (time >= 12 && time <= 17)
{
    Console.WriteLine($"The time is {time}:{min} Good Afternoon");
}
else if (time >= 18 && time <= 23)
{
    Console.WriteLine($"The time is {time}:{min} Good Evening");
}
Console.ReadKey();


//Bonus Task

int favNum;                                         
int anotherNum = 10; // 10 = binary 00001010

Console.WriteLine("Please enter your favourite number");
favNum = Convert.ToInt32(Console.ReadLine());

int anD = favNum & anotherNum;  //Compares bits (1) for each number, both bits must have a 1 *alinged to count 
int oR = favNum | anotherNum;   //Compares bits (1) for each number , atleast one bit is 1 *alinged to count

Console.WriteLine($"Here is the AND & Bitwise result: {anD}");
Console.WriteLine($"Here is the OR | Bitwise result: {oR}");

Console.ReadKey();