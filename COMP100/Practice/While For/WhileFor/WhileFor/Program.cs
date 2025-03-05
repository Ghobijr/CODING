using System.Diagnostics;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        //1 Write a C# program that uses a for loop to print the message "Hello from Joe X" eleven times, where X starts from 1 to 10 and increments by 1 in each iteration.

        //for (int count = 0; count <= 10; count++)
        //{
        //    Console.WriteLine($"Hello from Joe {count + 1 }");
        //}

        //2 Write a C# program that prints "Hello from Joe X", where X starts from 1 and goes up to 11, using a while loop.

        //int count1 = 0;

        //while (count1 <= 10)
        //{
        //    Console.WriteLine($"Hello from Joe {count1 + 1}");
        //    count1++;
        //}

        //3 Write a C# program that prints "Hello from Joe X", where X starts from 1 and goes up to 11, using a do-while loop.

        //int count2 = 0;
        //int stop2 = 11;

        //do
        //{
        //    Console.WriteLine($"Hello from Joe {count2 + 1}");
        //    count2++;
        //}
        //while (count2 < stop2);


        //4 slide 5) Write a C# program that uses a do-while loop to print "Hello" five times.

        //int count3 = 0;
        //int stop3 = 5;

        //do
        //{
        //    Console.WriteLine("Hello");
        //    count3++;
        //}
        //while (count3 < stop3);

        //5 Write a C# program that uses a while loop to print "Hello" five times.

        //int count4 = 0;
        //int stop4 = 5;

        //while (count4 < stop4)
        //{
        //    Console.WriteLine("Hello");
        //    count4++;
        //}

        //6 Write a C# program that uses a Do while loop to print "Hello" five times.

        //int count5 = 0;
        //int stop = 5;

        //do
        //{
        //    Console.WriteLine("Hello");
        //    count5++;
        //}
        //while (count5 < stop);

        //7 Please explain the following code and what is changed in it. Why the results are different.

        //int counter = 0;
        //do
        //{
        //    Console.WriteLine(counter);
        //} while (counter++ < 5); //++ afer the count prints the value first then adds 1 (0,1,2,3,4,5)
        //Console.ReadKey();

        //int counter1 = 0;
        //do
        //{
        //    Console.WriteLine(counter1);
        //} while (++counter1 < 5); //++ before the count increments it first then prints so 0 is left out (1,2,3,4). Why only 4 because it has met the condition of <5
        //Console.ReadKey();

        //8 slide 5) Write a C# program that uses a for loop to print "Hello >>>> X", where the X is the loop counter starting from 0 and incrementing by 1, up to 4. (4 included)

        //for (int count6 = 0; count6 < 5; count6++)
        //{
        //    Console.WriteLine($"Hello >>>> {count6} ");
        //}

        //9 slide 06) Write a C# program that uses a do-while loop to print "Hello" at least once, even though the loop condition is initially false (counter is 6 and the condition is counter < 5).
        //int count7 = 6;
        //int stop = 5;

        //do
        //{
        //    Console.WriteLine("Hello");
        //    count7++;
        //}
        //while (count7 < stop);

        //10 slide 06) Write a C# program that uses a while loop to print "Hello" only if the counter is less than 5. The counter starts at 6, so the loop should not execute.

        //int count8 = 6;
        //int stop = 5;

        //while (count8<stop)
        //{
        //    Console.WriteLine("Hello");
        //    count8++;
        //}

        //11 slide 09) Write a C# program that uses a for loop to print "Hello" five times.

        //for (int count9 = 0; count9 < 5; count9++)
        //{
        //    Console.WriteLine("Hello");

        //}

        //12 slide 10) Write a C# program that uses a for loop to print "Hello" six times. The loop should use an infinite loop structure, and break when the counter exceeds 5.

        //for (int count10 = 0; count10 < 6; count10++)
        //{
        //    Console.WriteLine("Hello");

        //    if (count10 > 5)
        //        break;
        //}

        //13 slide 11)  Write a C# program that uses a for loop to iterate five times, printing "Hello" each time. During each iteration, add the value of counter to sum, and print the cumulative value of sum after each iteration.
        //After the loop, print the final value of sum.

        //double sum = 0;

        //for (int count11 = 0; count11 < 5; count11++)
        //{
        //    sum += count11;
        //    Console.WriteLine($"Hello");
        //    Console.WriteLine($"{sum}");
        //}
        //Console.WriteLine($"After the loop, sum is {sum}");

        //14 slide 12) Write a C# program that uses a for loop to iterate five times, printing "Hello" each time. During each iteration, add the value of counter to sum. After the loop, print the final value of sum.

        //double sum = 0;

        //for (int count12 = 0; count12 < 5; count12++)
        //{

        //    Console.WriteLine("Hello");
        //    sum += count12;
        //}
        //Console.WriteLine($"Sum is: {sum}");

        //15 Write a C# program that calculates the total and the average grades for a student based on the number of courses. The program should:Ask the user to input the number of courses.
        //Prompt the user to enter the grade for each course.Calculate the sum and average of the grades.Display the sum and average of the grades, formatted to two decimal places.

        //double grade;
        //int numOfCourses;
        //double sum = 0;
        //double avg = 0;

        //Console.WriteLine("Enter the number of courses taken: ");
        //numOfCourses = Convert.ToInt32(Console.ReadLine());

        //for (int count13 = 0; count13 < numOfCourses; count13++)
        //{
        //    Console.WriteLine($"Please enter the grade for course No {count13 + 1}");
        //    grade = Convert.ToDouble(Console.ReadLine());
        //    sum+= grade;
        //}
        //avg = sum / numOfCourses;
        //Console.WriteLine($"Your average grade is: {avg:F2}");


    }
}