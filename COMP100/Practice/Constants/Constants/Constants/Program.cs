using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

//const double TAX_RATE = .13;


//Console.Write("Please , enter your salary:");
//double sal = Convert.ToDouble(Console.ReadLine());
//double netSal = sal - (sal * TAX_RATE);
//Console.WriteLine($"Your net income is {netSal}:C");
//Console.ReadLine();




//const double PI = 3.1415;
//double rad;
//double area;

//Console.Write("Please enter the radius: ");
//rad = Convert.ToDouble(Console.ReadLine());
//area = rad * rad * PI;
//Console.Write($"The area of the circle that you have is {area:F2}");
//Console.ReadLine();


//string userAnswer;
//do
//{
//    Console.WriteLine("Hello!");
//    Console.Write("You still want to continue? (yes/no) ");
//    userAnswer = Console.ReadLine();
//} while (userAnswer == "yes");
//Console.ReadLine();


//int counter = 0; //initializer
//int stop = 5; //initializer
//do
//{
//    counter = counter + 1; //updater
//    Console.WriteLine(counter);
//} while (counter < stop);      //checker
//Console.ReadLine();


//int counter = 0; //initializer
//int stop = 5; //initializer
//do
//{
//    counter = counter + 1; //updater
//    Console.WriteLine("Hello");
//} while (counter < stop);      //checker
//Console.ReadLine();

//int num = 1;

//do
//{
//    Console.WriteLine($"Your {num,-3}>>>> {num * 12,3}");
//    num ++;
//} while (num < 10 );
//Console.ReadLine();


//int start = 50;
//int stop = 80;
//int increment = 10;

//do
//{
//    Console.WriteLine(start);
//    start += increment;
//} while (start <= stop);
//Console.ReadLine();

//int start = 50;
//int stop = 80;
//double sum = 0;
//int count = 0;
//double avg;
//do
//{
//    sum += start;
//    count++;
//    start = start + 1;
//} while (start <= stop);
//avg = sum / count;
//Console.WriteLine($"The counter value is {count}");
//Console.WriteLine($"The sum is {sum}");
//Console.WriteLine($"The average is {avg}");
//Console.ReadLine();

//int num1;
//int sum = 0;

//do
//{
//    Console.Write("Enter a positive number for summation: ");
//    num1 = Convert.ToInt32(Console.ReadLine());
//    if (num1 > 0);
//    sum = sum + num1;
//} 

//while (num1 > 0);

//Console.WriteLine($"The sum is {sum}");
//Console.ReadKey();

//double sum = 0;
//int number;
//double avg;
//int count = 0;
//bool toContinue = true;
//do
//{
//    Console.Write("Enter a positive number (any negative number or zero to Exit): ");
//    number = Convert.ToInt32(Console.ReadLine());
//    if (number > 0)
//    {
//        sum = sum + number;
//        count++;
//    }
//    else
//    {
//        toContinue = false;
//    }
//} while (toContinue);
//avg = sum / count;
//Console.WriteLine($"The sum is {sum} and the average is {avg}");
//Console.ReadLine();


//int i = 0;
//for (; ; )
//{
//    i++;
//    Console.WriteLine($"Hello from Reza {i}");
//    if (i >= 3)
//    {
//        break;
//    }
//}
//Console.ReadKey();



//int i = 0;

//while (i <= 10)
//{
//    Console.WriteLine($"Hello from Reza {i + 1}");
//    i++;
//}
//Console.ReadKey();


//int i = 0;

//do
//{
//    Console.WriteLine($"Hello from Joe {i + 1}");
//    i++;
//   } while (i <= 10) ;
//}

//Console.ReadKey();


//int counter = 0;
//do
//{
//    Console.WriteLine(counter);
//} while (counter++ < 5);
//Console.ReadKey();


//int i = 0;

//for (i = 0; i < 5; i++ )
//{ 
//    Console.WriteLine($"Hello >>>>{i}");
//}while (i++ < 5) ; 

//Console.ReadKey();


//int i = 0;

//while (i < 5 )
//{
//    Console.WriteLine($"Hello >>>>{i++}");
//    if (i >= 5)
//    { 
//    break;
//    }
//}

//Console.ReadKey();


//int counter = 0;              //initializer
//for (;  ; )
//{
//    Console.WriteLine("Hello");
//    if (++ counter > 5)             //checker
//    {
//        break;
//    }
//}
//Console.ReadKey();



//=============================================================

//Think of this as a pre Test Loop
//int num = 1;
//int total = 0;

//while (num > 0)
//{
//    Console.WriteLine("Enter a number: ");
//    num = Convert.ToInt32(Console.ReadLine());
//    total = total + num;
//}
//Console.WriteLine($"Your total is {total}");

//Console.ReadKey();

//int count = 0;

//while (count < 10)
//{
//    Console.WriteLine(count);
//    count++;
//}

//Console.ReadKey();


// Think of this as a post Test Loop

//int count = 0;

//do
//{
//    Console.WriteLine(count);
//    count++;
//} while (count < 10);

//Console.ReadKey();


//int count;

//for (count = 0; count < 10; count++)
//{
//    Console.WriteLine(count);
//}

//Console.ReadKey();

//You can decrease or increase my a number for count by using count +or - = number ie.count += 2 or count -=2

//int count;
//for (count = 20; count >= 0; count--)
//{
//    Console.WriteLine(count);
//}

//Console.ReadKey();



//Infinite for loop

//for (; ; )
//{
//    Console.WriteLine("Hello");
//}

//Console.ReadKey();



//string word;
//for (;;)
//{
//    Console.WriteLine("Enter a word:");
//    word = Console.ReadLine().ToLower();

//    if (word == "stop")
//    {
//        break;
//    }
//}


//do while===============
//int count = 0;

//do
//{
//    Console.WriteLine("Hello");
//    count++;
//} while (count < 5);

//Console.ReadKey();


//while Practice===================================
//int counter = 2;
//while (counter < 5)
//{
//    Console.WriteLine("Hello");
//    counter++;
//}

//Console.ReadKey();

//for==========
//for (int count = 0; count < 5; count++)
//{
//    Console.WriteLine("Hello");
//}
//Console.ReadKey();

//For Scoping


//int sum = 0;
//for (int count = 0; count < 5; count++)
//{
//    Console.WriteLine("Hello");
//    sum += count;
//    Console.WriteLine($"{sum}");
//}
//Console.ReadKey();

//int counter = 0;
//for (; counter < 5; counter++)
//{
//    Console.WriteLine("Hello");
//}
//Console.ReadKey();

//Continue=================================================

//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}
//Console.ReadKey();

//int sum = 0;
//int counter = 0;
//int stop = 10;
//int mark;
//do
//{
//    Console.Write($"Enter course #{counter + 1} (any negative number to Exit): ");
//    mark = Convert.ToInt32(Console.ReadLine());
//    if (mark < 0)
//    {
//        break;
//    }
//    sum += mark;
//    counter++;
//} while (counter < stop);
//Console.WriteLine($"Total of {counter} marks is {sum}");
//Console.ReadKey();


//int sum = 0;
//int counter = 0;
//int stop = 10;
//int mark;
//do
//{
//    Console.Write($"Enter course #{counter + 1} (any negative number to Exit): ");
//    mark = Convert.ToInt32(Console.ReadLine());
//    if (mark < 0)
//    {
//        break;
//    }
//    sum += mark;
//    counter++;
//} while (counter < stop);
//Console.WriteLine($"Total of {counter} marks is {sum}");
//Console.ReadKey();


//int sum = 0;
//int counter = 0;
//int stop = 10;
//int mark;

//while (counter < stop)
//{
//    Console.Write($"Enter course #{counter + 1} (any negative number to Exit): ");
//    mark = Convert.ToInt32(Console.ReadLine());

//    if (mark < 0)
//    {
//        break;
//    }
//    sum += mark;
//    counter++;
//}

//Console.WriteLine($"Total of {counter} marks is {sum}");
//Console.ReadKey();
//}


//Average====================================
//double sum = 0;
//int counter = 0;
//int stop = 25;
//double mark;
//double average;

//do
//{
//    Console.Write($"Enter course #{counter + 1} (any negative number to Exit): ");
//    mark = Convert.ToInt32(Console.ReadLine());
//    if (mark < 0)
//    {
//        break;
//    }
//    sum += mark;
//    counter++;

//} while (counter < stop);

//Console.WriteLine($"Total of {counter} marks is {sum}");

//if (counter > 0)
//{
//    average = sum / counter;
//    Console.WriteLine($"Average of marks entered: {average}");
//}
//else 
//{
//    Console.WriteLine("No eligible marks entered, cannot calculate");
//}

//Console.ReadKey();

//int sum = 0;
//int counter = 0;
//int mark;
//bool flag = true;\

//while (flag)
//{
//    Console.Write($"Enter mark # {counter + 1} (any negative number to exit): ");
//    mark = Convert.ToInt32(Console.ReadLine());

//    if (mark < 0)
//    {
//        break;
//    }
//    sum += mark;
//    counter++;

//    if (counter == 8 )
//    { 
//    flag = false
//    }
//}
//Console.WriteLine($"Total of {counter} marks is {sum}");
//Console.ReadKey();

//int sum = 0;

//for (int i = 1; i < 100; i++)
//{
//    Console.WriteLine($"Current value of i: {i}");
//    if (i % 7 == 0)
//    {
//        break; // Terminate the loop if i is divisible by 7
//    }
//    sum += i;
//}

//Console.WriteLine("Total sum of all values of i before encountering a value divisible by 7: " + sum);
//}


//for (int i = 0; i <= 10; i++)
//{
//    if (i % 2 != 0)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

//Console.ReadKey();


//string savedUername = "Joe";
//string uername;
//string savedPassword = "Ghobi";
//string password;
//bool status = false;
//int count = 0;
//int stop = 3;

//while (status == false && count < 3)
//{
//    Console.Write("Please enter your username: ");
//    uername = Console.ReadLine();

//    Console.Write("Please enter your password: ");
//    password = Console.ReadLine();

//    if ((savedUername.ToLower() == (uername.ToLower())) && (savedPassword == password))
//    {
//        Console.WriteLine("Successful login.");
//        status = true;
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Either username or password is incorrect.");
//        Console.WriteLine("Please try one more time");
//        count++;
//    }
//}

//Console.WriteLine("########################");
//Console.ReadKey();


//string savedUername = "Joe";
//string uername;
//string savedPassword = "joe123";
//string password;

//int counter = 0;

//while (counter <= 3)
//{
//    Console.Write("Please enter your usernamer: ");
//    uername = Console.ReadLine();

//    Console.Write("Please enter your password: ");
//    password = Console.ReadLine();

//    if ((savedUername.ToLower() == (uername.ToLower())) && (savedPassword == password))
//    {
//        Console.WriteLine("Successful login.");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Either username or password is incorrect.");
//    }
//    counter++;
//    if (counter == 3)
//    {
//        Console.WriteLine("No more chance to try!");
//    }
//}
//Console.WriteLine("########################");
//Console.ReadKey();


//for example
//string savedUername = "Joe";
//string uername;
//string savedPassword = "joe123";
//string password;
//int counter;

//for (counter = 0; counter < 3; counter++)
//{
//    Console.Write("Please enter your usernamer: ");
//    uername = Console.ReadLine();

//    Console.Write("Please enter your password: ");
//    password = Console.ReadLine();

//    if ((savedUername.ToLower() == (uername.ToLower())) && (savedPassword == password))
//    {
//        Console.WriteLine("Successful login.");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Either username or password is incorrect.");
//    }

//    if (counter == 3)
//    {
//        Console.WriteLine("No more chance to try!");
//    }
//}
//Console.WriteLine("########################");
//Console.ReadKey();



int i = 0;

while (i < 10)

{
    Console.WriteLine($"Now i is {i}");
    i++;
}
Console.WriteLine("########################");

Console.ReadKey();