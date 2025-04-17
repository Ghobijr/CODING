using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        char[] vowels = { 'j', 'o', 'e' };
        Console.WriteLine(vowels.Length);

        int[] primes = { 1, 2, 3, 4, 5 };
        Console.WriteLine(primes.Length);

        string[] poems = { "Marry", "had", "a", "little", "lamb" };
        Console.WriteLine(poems.Length);

        int i = 0;
        do
        {
           Console.WriteLine(poems[i]);
           i++;
        }
        while (i < poems.Length);

        int i1 = 0;
        while (i1 < poems.Length)
        {
           Console.WriteLine(poems[i1]);
           i1++;
        }

        for (int i2 = 0; i2 < poems.Length; i2++)
        {
           Console.WriteLine(poems[i2]);
        }


        double[] marks = { 10, 20, 30, 40, 50 };

        int i3 = 0;
        while (i3 < marks.Length)
        {
           marks[i3] += 3;
           i3++;
        }

        //i3 = 0;
        //while (i3 < marks.Length)
        //{
        //    Console.WriteLine(marks[i3]);
        //    i3++;
        //}

        //for (int i4 = 0; i4 < marks.Length; i4++)
        //{
        //    marks[i4] += 3;
        //    Console.WriteLine(marks[i4]);
        //}

        //double[] numsToSum = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //double sum = 0;
        //for (int i5 = 0; i5 < numsToSum.Length; i5++)
        //{
        //  sum += numsToSum[i5];
        //}
        //Console.WriteLine($"{sum}"); //its outside the loop so that it sums all the numbers into 1 value

        //Split

        //string[] poems1 = "Mary had a little lamb".Split();
        //Console.WriteLine(string.Join(" ", poems1));

        //ForEach Loop

        //int[] numbers = { 1, 2, 3, 4, 5 };

        //foreach (int x in numbers)
        //{
        //    Console.WriteLine(x);
        //}

        //Array Reverse

        //int[] numbers1 = { 1, 2, 3, 4, 5 };
        //Array.Reverse(numbers1);
        //foreach (int x1 in numbers1)
        //{
        //    Console.WriteLine(x1);
        //}

        ////Array Sort

        //int[] numbers2 = { 1, 2 , 3, 4, 5 };
        //Array.Sort(numbers2);
        //foreach (int x2 in numbers2)
        //{
        //    Console.WriteLine(x2);
        //}

        //Binary Search (gives you the position of the value your looking for. *when using binary, you must sort)

        // int[] numbers3= { 1,5,7,6,2,4,1,3,0,5};
        // Array.Sort(numbers3);
        // Array.BinarySearch(numbers3, 8);

        // foreach (int x3 in numbers3)
        // {
        // Console.WriteLine(x3);
        // }

        //Practice A using Arrays Week 11

        //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
        //Console.WriteLine(cars[3]);

        //int[] intArray = new int [] {5};
        //for (int i = 0; i < intArray.Length; i++) 
        //{
        //    intArray[i] = i * 10;
        //}

        //for (int i = 0; i < intArray.Length; i++)
        //{
        //    Console.WriteLine($"The value in index {i+1} are {intArray[i]}");
        //}

        //////////////////

        //string[] cars1 = new string[4];
        ///////
        //cars1[0] = "Volvo";
        //cars1[1] = "BMW";
        //cars1[2] = "Ford";
        //cars1[3] = "Mazda";

        //foreach (string car in cars1)
        //{
        //    Console.WriteLine(car);
        //}

        //// Create an array of four elements and add values right away 
        //string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

        //foreach (string car in cars2)
        //{
        //    Console.WriteLine(car);
        //}

        //// Create an array of four elements without specifying the size 
        //string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

        //foreach ( string car in cars3)
        //{
        //    Console.WriteLine(car);
        //}

        //// Create an array of four elements, omitting the new keyword, and without specifying the size
        //string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };

        //foreach (string car in cars4)
        //{
        //    Console.WriteLine(car);
        //}

        //string[] cars5;
        //cars5 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

        //foreach (string car in cars5)
        //{
        //    Console.WriteLine(car);
        //}

        //carArray(cars5);


        //static void carArray (string[] cars)
        //{
        //    string[] cars6 = { "Volvo", "BMW", "Ford", "Mazda" };

        //    foreach (string car in cars)
        //    {
        //        Console.WriteLine(car);
        //    }
        //}

        //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        //Console.WriteLine(vowels.Length);

        //foreach (char vowel in vowels)
        //    Console.WriteLine(vowel);

        //int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
        //Console.WriteLine(primes);//will print gibberish

        //int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };

        //PrintMyArray(primes);

        //static void PrintMyArray(int [] primes)
        //{
        //    foreach (int num in primes)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}

        //string[] poem = { "Mary", "had", "a", "little", "lamb" };

        //int counter = 0;
        ////do
        ////{
        ////    Console.WriteLine(poem[counter]);
        ////    counter++;
        ////}
        ////while (counter < poem.Length);

        //while (counter < poem.Length)
        //{
        //    Console.WriteLine(poem[counter]);
        //}

        //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        //int counter = 0;

        //do
        //{
        //    Console.WriteLine(vowels[counter]);
        //    counter++;
        //}
        //while (counter<vowels.Length);

        //double[] marks = { 50, 67, 73, 55, 89, 68, 66, 76, 49 };
        //int counter = 0;
        //while (counter < marks.Length)
        //{
        //    marks[counter] += 3;
        //    Console.WriteLine(marks[counter]);
        //    counter++;
        //}

        //counter = 0;
        //while (counter < marks.Length)
        //{
        //    Console.WriteLine(marks[counter]);
        //    counter++;
        //}

        //int[] primes = { 2, 3, 5, 7};
        //int sum = 0;
        //for (int counter = 0; counter < primes.Length; counter++)
        //{
        //    Console.WriteLine($"{primes[counter]}");
        //    sum += primes[counter];
        //}
        //Console.WriteLine($"The sum is {sum}");


        //int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 37, 41, 47 };

        //int sum = 0;
        //double average;
        //for (int counter = 0; counter < primes.Length; counter++)
        //{
        //    Console.Write($"{primes[counter]} ");
        //    sum += primes[counter];
        //}
        ////now we can display the sum
        //Console.WriteLine($"\nThe sum is {sum}");

        //average = sum/ primes.Length;
        //Console.WriteLine($"\nThe average is {average:F2}");


        //string[] poem = "Mary had a little lamb".Split();


        //for (int counter = 0; counter < poem.Length; counter++)
        //{
        //    Console.WriteLine(poem[counter]);
        //}

        //int[] numbers = { 3, 2, 6, 8, 1, 9, 5, 7, 4, 0 };

        //foreach (int x in numbers)
        //{
        //    //x assumes the value of each item of the array
        //    //starting with the first and ending with the last

        //    //the variable x is readonly!!!
        //    Console.WriteLine(x);
        //}

        //int[] numbers = { 3, 2, 6, 8, 1, 9, 2, 3, 4, 0 };
        ////0,1,2,2,3,3,4,6,8,9
        //Array.Sort(numbers);

        //foreach (int number in numbers)
        //{
        //    Console.Write($"{number}, ");
        //}

        //Console.WriteLine();
        //Console.WriteLine(Array.BinarySearch(numbers, 4));
        //Console.WriteLine(Array.BinarySearch(numbers, 2));
        //Console.WriteLine(Array.BinarySearch(numbers, 5));


        //int[] myNumbers = { 5, 1, 8, 9 };
        //Console.WriteLine(myNumbers.Max());     // largest value
        //Console.WriteLine(myNumbers.Min());     // smallest value
        //Console.WriteLine(myNumbers.Sum());
        //Console.WriteLine(myNumbers.Length);
        //Console.WriteLine(myNumbers.Average());

        //Console.WriteLine("Welcome to Sum/Average calculator!");
        //Console.Write("How many numbers are you summing today? ");
        //int userInput = Convert.ToInt32(Console.ReadLine());
        //int[] userArray = new int[userInput];
        //int counter = 1;
        //for (int i = 0; i < userInput; i++)
        //{
        //    Console.Write($"Enter your number {counter++} value: ");
        //    userArray[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //SumAvgMethod(userArray);
        //static void SumAvgMethod(int[] numbers)
        //{
        //    Console.WriteLine($"The sum of your numbers is {numbers.Sum()}");
        //    Console.WriteLine($"The avg of your numbers is {numbers.Average():F2}");
        //}

//        int[][] stuffs =
//[
//    [1, 2, 3 ],
//    [4, 5, 6],
//    [7, 8, 9]
//];

//        foreach (int[] stuff in stuffs)
//            foreach (int i in stuff)
//                Console.WriteLine(i);














    }
}
