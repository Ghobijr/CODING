internal class Program
{

  
    private static void Main(string[] args)
    {
        //Question 1

        int[] ExamArray = createArray();

        int[] NewArray= CreateEvenArray(ExamArray, GetEvenCount(ExamArray));

        Console.Write($"Your new even array is: ");
        foreach (int i in NewArray)
        {
            Console.Write($"{i} ");
        }

        static int[] createArray()
        { 
            int[] arrayNumbers = new int [15];

            for (int i=0; i <15; i++ )
            {
                Console.Write($"Please enter your element {i}, in your array:");
                arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            DisplayArray(arrayNumbers);
            return arrayNumbers;
        }

        static void DisplayArray(int[] inputtedNum)
        {
            Console.WriteLine("Here is the array that you have just defined: ");
            foreach (int number in inputtedNum)
            {
                Console.Write($"{number}");
            }
        }

        static int GetEvenCount(int[] inputtedNum)
        {
            int evenCount = 0;
            foreach (int number in inputtedNum)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine($"You have {evenCount} even numbers in your array.");
            return evenCount;
        }

        static int[] CreateEvenArray(int[] inputtedNum, int count)
        {
            int[] evenArray = new int[count];
            int i = 0;
            foreach (int number in inputtedNum)
            {
                if (number % 2 == 0)
                {
                    evenArray[i] = number;
                    i++;
                }
            }
            return evenArray;
        }



    }
}