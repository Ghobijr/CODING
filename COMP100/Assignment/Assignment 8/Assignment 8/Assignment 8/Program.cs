using System.Linq;
using System.Runtime.InteropServices.JavaScript;

internal class Program
{
    private static void Main(string[] args)
    {
        //Part 1.1 

        int[] arrayNumbers = new int[5] { 10, 20, 30, 40, 50 };
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
           Console.WriteLine(arrayNumbers[i]);
        }

        Console.WriteLine();

        ////Part 1.2

        arrayNumbers[2] = 100;
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
           Console.WriteLine(arrayNumbers[i]);
        }


        //Part 2.3 

        int[] arrayNumbers1 = new int[5] { 10, 20, 30, 40, 50 };
        foreach (int i in arrayNumbers1)
        {
           Console.WriteLine(i);
        }

        Console.WriteLine();

        for (int j = 0; j < arrayNumbers1.Length; j++)
        {
           Console.WriteLine(arrayNumbers1[j]);
        }

        Console.WriteLine();

        int k = 0;
        while (k < arrayNumbers1.Length)
        {
           Console.WriteLine(arrayNumbers1[k]);
           k++;
        }

        ////Part 2.4 

        Random random = new Random();

        int[,] twoDimensionalArrays = new int [3,3];

        for (int row = 0; row < 3; row++)
        {
           for (int column = 0; column < 3; column++)
           {
               twoDimensionalArrays[row, column] = random.Next(1, 20);
               Console.Write(twoDimensionalArrays[row, column] + " ");
           }
           Console.WriteLine();
        }

        //Part 3.5

        int[] arrayValues1 = { 5, 3, 8, 1, 2 };
        Array.Sort(arrayValues1);
        foreach (int value in arrayValues1)
        {
           Console.Write(value);
        }

        Console.WriteLine();

        Array.Reverse(arrayValues1);
        foreach (int value in arrayValues1)
        {
           Console.Write(value);
        }

        Console.WriteLine();

        Array.Sort(arrayValues1);
        int num = Array.BinarySearch(arrayValues1, 8);

        Console.Write(num);

        Console.WriteLine();

        ////Part 3.6

        Console.WriteLine(arrayValues1.Length);


        //Part 4.7
        int[] arrayValues2 = { 7, 14, 21, 28, 35 };
        sumArray(arrayValues2);
        averageArray(arrayValues2);
        minAndMax(arrayValues2);

        //Part 4.8
        Console.Write("Enter a string of words: ");
        string words = Console.ReadLine();

        string[] splitWords = words.Split();
        foreach (string word in splitWords)
        {
           Console.WriteLine(word);
        }

        //Part 5.9
        int[] arrayValues3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        SumOfEvenArrays(arrayValues3);

        //Part 5.10
        int[] arrayValues4 = { 1, 2, 3, 4, 5 };
        integerExists(arrayValues4);


    }

    static void sumArray(int[] arrayValues2)
    {
       Console.WriteLine($"The sum value is {arrayValues2.Sum()}");
    }
    static void averageArray(int[] arrayValues2)
    {
       Console.WriteLine($"The average value is {arrayValues2.Average()}");
    }
    static void minAndMax(int[] arrayValues2)
    {
       Console.WriteLine($"The minimum value is {arrayValues2.Min()}");
       Console.WriteLine($"The maximum value is {arrayValues2.Max()}");
    }


    static void SumOfEvenArrays(int[] arrayValues3)
    {
       int sum = 0;
       foreach (int i in arrayValues3)
       {
           if (i % 2 == 0)
           {
               sum += i;
           }
       }
       Console.WriteLine(sum);
    }

    static void integerExists(int[] arrayValues4)
    {
       int num = 3;
       foreach (int i in arrayValues4)
       {
           if (i == num)
           {
               Console.WriteLine($"{i} has been found");
           }
       }
    }
}



