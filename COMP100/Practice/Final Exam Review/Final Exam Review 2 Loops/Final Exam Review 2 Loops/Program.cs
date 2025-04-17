using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {

        //Question 1

        int [] numRange = {1,2,3,4,5,6,7,8,9,10};

        for (int i = 0; i < numRange.Length; i++)
        {
           Console.Write(numRange[i] + " ");
        }

        //Console.WriteLine();

        ////Question 2

        Array.Reverse(numRange);
        foreach (int num in numRange)
        {
           Console.Write(num + " ");
        }

        //Question 3
        int[] numarray = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25};
        for (int i = 0; i < numarray.Length; i++)
        {
           if (numarray[i] %2 != 0)
           Console.Write(numarray[i] + " ");
        }

        //Question 4

        int sum = 0;
        for(int i= 1; i <= 100; i++)
        {
          sum += i;
        }
        Console.WriteLine($"{sum}");

        //Question 5

        int num;
        Console.WriteLine("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        int result = 1;

        for (int i = 1; i <= num; i++)
        {
           result *= i ;
        }
        Console.WriteLine($"{result}");

        //Question 6 (cant understand how to get this)//////////////////////////////////////////

        int num;
        Console.WriteLine("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {

           Console.WriteLine("*");
        }

        //Question 7

        int num;
        double cube;
        Console.WriteLine("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            cube = Math.Pow(i, 3);
            Console.WriteLine($"number is {i} and the cube of the {i} is {cube}");
        }

        //Question 8

        int num1;

        Console.Write("Enter a number starting from 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication table from 1 to {num1}");

           for (int i = 1; i <=num1; i++)
           {
               int result = i * num1;
               Console.Write($"{i}x{num1} = {result} ");
           }

           Console.WriteLine();

        //Question 9 

        int num1;

        Console.Write("Enter number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num1; i++)//row
        {
            for (int j = 1; j <= i; j++)//column
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        //Question 10
        int num3;

        Console.Write("Enter number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num3; i++)//row
        {
            for (int j = 1; j <= i; j++)//column
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}