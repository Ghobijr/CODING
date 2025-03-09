using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //1) Write a C# program that repeatedly prints "Hello!" and asks the user, "You still want to continue? (yes/no) ". Use a "do-while" loop to continue execution as long as the user enters "yes"

        //string usersChoice;

        //do
        //{
        //Console.WriteLine("Hello");
        //Console.Write("You still want to continue? (yes/no): ");
        //usersChoice = Console.ReadLine();

        //} while (usersChoice == "yes");
        //Console.ReadKey();

        //2) Modify the given C# program in 1) to ensure the user input is case-insensitive when checking if they want to continue. Use a "do-while" loop that keeps running as long as the user enters "yes" in any letter case (e.g., "Yes", "YES", "yEs").

        //string usersChoice1;

        //do
        //{
        //    Console.WriteLine("Hello");
        //    Console.Write("You still want to continue? (yes/no): ");
        //    usersChoice1 = Console.ReadLine().ToLower();

        //} while (usersChoice1 == "yes");
        //Console.ReadKey();

        //3) Write a C# program that repeatedly prints "Hello!" and asks the user, "You still want to continue? (yes/no) ". Use a "while" loop to continue execution as long as the user enters "yes" in any letter case (e.g., "YES", "Yes", "yEs").

        //string userChoice2 = "yes";

        //while (userChoice2 == "yes")
        //{
        //    Console.WriteLine("Hello");
        //    Console.WriteLine("You still want to continue? (yes/no)");
        //    userChoice2 = Console.ReadLine().ToLower();
        //}
        //Console.ReadKey();

        //4 slide 06) Write a C# program using a do-while loop that initializes a counter at 0 and increments it by 1 in each iteration. The loop should continue running until the counter reaches a specified stop value (5). Display the counter value in each iteration.

        //int count = 0;
        //int stop = 5;

        //do
        //{
        //    count = count + 1;
        //    Console.WriteLine($"{count}");
        //}
        //while (count < stop);

        //5 slide 07) Write a C# program that uses a do-while loop to print "Hello" five times. Initialize a counter at 0, increment it in each iteration, and stop when the counter reaches 5.

        //int count1 = 0;
        //int stop1 = 5;

        //do
        //{
        //    count1 = count1 + 1;
        //    Console.WriteLine("Hello");
        //}
        //while (count1 < stop1);

        //6 slide 08) Write a C# program using a do-while loop that prints numbers from 1 to 10, displaying each number followed by its product with 12.

        //int count2 = 0;
        //int stop2 = 10;

        //do
        //{
        //    count2 = count2 + 1;
        //    Console.WriteLine($"{count2} >>>>>>> {count2 * 12}");
        //}
        //while (count2 < stop2);


        //7 slide 08 Better Version) Write a C# program using a do-while loop that prints numbers from 1 to 10, displaying each number alongside its product with 12. Format the output so that numbers are 'right-aligned' in a two-character width.


        //int count3 = 0;
        //int stop3 = 10;

        //do
        //{
        //    count3 = count3 + 1;
        //    Console.WriteLine($"{count3,2} >>>>>>> {count3 * 12}");
        //}
        //while (count3 < stop3);

        //8 slide 08 Another Version) Write a C# program using a do-while loop that prints numbers from 1 to 10, displaying each number followed by its product with 12. Ensure that the numbers are 'left-aligned' with a width of two characters.

        //int count4 = 0;
        //int stop4 = 10;

        //do
        //{
        //    count4 = count4 + 1;
        //    Console.WriteLine($"{count4,-2} >>>>>>> {count4 * 12}");
        //}
        //while (count4 < stop4);

        //9 slide 09) Write a C# program using a do-while loop that starts with a value of 50 and increments by 10 in each iteration. The loop should stop when the value exceeds 80, printing the current value in each iteration.

        //int count5 = 50;
        //int stop5 = 80;
        //int increment = 10;

        //do
        //{
        //    Console.WriteLine(count5);
        //    count5 += increment; //use += when question asks for increments of a number
        //}
        //while (count5 <= stop5);

        //10 slide 10) Write a C# program using a do-while loop that starts with a value of 80 and increments by 10 in each iteration. The loop should stop when the value exceeds 50, printing the current value in each iteration.

        //int count6 = 80;
        //int stop6 = 50;
        //int increment1 = 10;

        //do
        //{
        //    Console.WriteLine(count6);
        //    count6 += increment1;
        //}
        //while (count6 <= stop6);

        //11 slide 11) Write a C# program using a do-while loop to calculate the 'sum' of all integers starting from 50 and ending just before 80. The program should display the sum after the loop finishes.

        //int count7 = 50;
        //int stop7 = 80;
        //int sum = 0;

        //do
        //{
        //    sum = sum + count7;
        //    count7++; //When incrementing by 1
        //}
        //while (count7 < stop7);
        //Console.WriteLine($"The sum is : {sum}");

        //Explanation

        //int start = 50; //This is where the loop begins.
        //int stop = 80;   // This is where the loop stops.
        //double sum = 0;  // This will store the sum of numbers from 50 to 80.
        //int count = 0;   //This keeps track of how many numbers are added.
        //double avg; //This will store the calculated average.

        //do
        //{
        //    sum += start; // Add the current number to sum
        //    count++; // Increase count by 1
        //    start = start + 1; // Move to the next number
        //} while (start <= stop); //Loop should not exceed the value 80
        //avg = sum / count; //sum is divided by count to get the average.

        //Console.WriteLine($"The counter value is {count}");
        //Console.WriteLine($"The sum is {sum}");
        //Console.WriteLine($"The average is {avg}");
        //Console.ReadLine();

        //12 slide 12) Write a C# program using a do-while loop that starts at 50 and counts down to 20, printing all numbers divisible by 3.

        //int start1 = 50;
        //int stop8 = 20;

        //do
        //{
        //    if (start1 % 3 == 0)
        //    {
        //        Console.WriteLine(start1);

        //    }
        //    start1 = start1 - 1;
        //}
        //while (start1 > stop8);

        //13 slide 13) Write a C# program using do-while that repeatedly asks the user to enter a positive number. The program should sum all the positive numbers entered and stop when the user enters a non-positive number.
        //Finally, it should print the sum of all entered positive numbers.

        //int numentered;
        //double sum = 0;

        //do
        //{
        //    Console.WriteLine("Enter a positive number (negative to stop): ");
        //    numentered = Convert.ToInt32(Console.ReadLine());

        //    if (numentered > 0)
        //    {
        //        sum = sum + numentered;
        //    }
        //} while (numentered > 0);

        //Console.WriteLine($"Total sum is :{sum}");

        //13B slide 13) Write a C# program that repeatedly asks the user to enter positive numbers. The program should calculate the sum and average of all the positive numbers entered.
        //If a negative number is entered, the program should stop and display the sum and average of the entered numbers, with the average rounded to two decimal places.

        //double numentered1;
        //double sum = 0;
        //double avg = 0;
        //double numOfInputs = 0;
        //bool toContinue = true;

        //do
        //{
        //    Console.WriteLine("Enter a positive number (negative to exit): ");
        //    numentered1 = Convert.ToDouble(Console.ReadLine());

        //    if (numentered1 >= 0)
        //    {
        //        sum += numentered1;
        //        numOfInputs++;
        //    }

        //    else
        //    {
        //        toContinue = false;
        //    }
        //}
        //while (toContinue);

        //Console.WriteLine($"Your sum is {sum}");

        //avg = sum / numOfInputs;
        //Console.WriteLine($"Your average is {avg:F2}");



        //In class practice
        //double sum = 0;
        //double myNum;
        //double average = 0;
        //int counter = 0;

        //string userAnswer;
        //do
        //{
        //    Console.Write("Please enter a number: ");
        //    myNum = Convert.ToDouble(Console.ReadLine());
        //    sum += myNum;
        //    counter++;
        //    Console.Write("Do you want to add any new number? (y/n) ");
        //    userAnswer = Console.ReadLine();
        //} while (userAnswer.ToLower() == "y");
        //Console.WriteLine($"The sum is equal to {sum}");
        //average = sum / counter;
        //Console.WriteLine($"The average is equal to {average}");
        //Console.ReadKey();


        //int num;
        //double sum = 0;
        //int counter = 0;
        //double avg;
        //string userReply = "yes";

        //while (userReply.ToLower() == "yes")
        //{
        //    Console.Write("Please enter a number: ");
        //    num = Convert.ToInt32(Console.ReadLine());
        //    // Add it to the sum
        //    // Add it to the sum
        //    sum += num;
        //    counter++;
        //    //Ask do you want to continue
        //    Console.Write("Do you want to continue? (yes/no) ");
        //    userReply = Console.ReadLine();
        //}

        //Console.WriteLine("After the loop");
        ////Print the sum
        //Console.WriteLine($"The sum is {sum}");
        //avg = sum / counter;
        //Console.WriteLine($"The average is {avg}");
        //Console.ReadKey();

        //int num;
        //double sum = 0;
        //int counter = 0;
        //double avg;
        //string userReply = "yes";

        //for (; ; )
        //{
        //    Console.Write("Please enter a number: ");
        //    num = Convert.ToInt32(Console.ReadLine());
        //    // Add it to the sum
        //    sum = sum + num;
        //    counter++;
        //    //Ask do you want to continue
        //    Console.Write("Do you want to continue? (yes/no) ");
        //    userReply = Console.ReadLine();
        //    if (userReply == "yes") 
        //    {
        //        break;
        //}



    }
}

