internal class Program
{
    private static void Main(string[] args)
    {
        //Excercise 1

        //int num1 = 5;
        //int num2 = 10;
        //int tempnum;


        //Swap(ref num1, ref num2);

        //static void Swap(ref int num1, ref int num2)
        //{
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;

        //    Console.WriteLine($"{num1},{num2}");
        //}

        //Excercise 2

        //int num1 = 5;
        //int num2 = 10;

        //Swap(ref num1, ref num2);

        //static void Swap(ref int num1, ref int num2)
        //{
        //    num1 = (int)Math.Pow(num1, 2);
        //    num2 = (int)Math.Pow(num2,2);

        //    Console.WriteLine($"{num1},{num2}");
        //}


        //Excercise 3
        //int num1;
        //Console.WriteLine("Enter a number: ");
        //num1=Convert.ToInt32(Console.ReadLine());
        //int result = 1;

        //Factorial(ref num1, ref result);

        //static void Factorial( ref int num1 , ref int result)
        //{
        //    for (int i = 1; i <= num1; i++)
        //    {
        //        result *= i;
        //    }
        //    Console.WriteLine($"{result}");

        //}

        //Excercise 4
        //int[] arrayNumbers = { 1, 2, 3, 4, 5 };

        //SqaureArrays(ref arrayNumbers);

        //static void SqaureArrays(ref int[] arrayNumbers)
        //{
        //    for (int i = 0; i < arrayNumbers.Length; i++)
        //    {
        //        arrayNumbers[i] = (int)Math.Pow(arrayNumbers[i], 2);//get it to the power of 2 first
        //    }

        //    foreach (int number in arrayNumbers)
        //    {
        //        Console.WriteLine($"{number}");   //then print each one
        //    }

        //Excercise 5

        //string name = "Joseph";

        //AppendSuffix(ref name);

        //static void AppendSuffix(ref string name)
        //{
        //    name += "es";
        //}

        //foreach (char letter in name)
        //{
        //    Console.Write($"{letter}");
        //}

        //Excercise 1 OUT
        //double num1;
        //double num2;

        //Console.Write("Enter a number: ");
        //num1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter a 2nd number: ");
        //num2 = Convert.ToInt32(Console.ReadLine());

        //double result = 0;

        //DivideOut(num1, num2, out result);

        //static void DivideOut(double num1, double num2, out double result)
        //{
        //    result = num1 / num2;
        //    Console.WriteLine($"The result is: {result}");
        //}


        //Excercise 2 OUT
        //int baseNum;
        //int exponentNum;

        //Console.WriteLine("Write a base number:");
        //baseNum = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Write a exponent number: ");
        //exponentNum = Convert.ToInt32(Console.ReadLine());

        //double result = 0;

        //Power(baseNum, exponentNum, out result);

        //static void Power(int baseNum, int exponentNum, out double result)
        //{
        //    result = Math.Pow(baseNum, exponentNum);
        //    Console.WriteLine($"The result is: {result}");
        //}
    }
}