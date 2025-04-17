using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        //Task 1.1

        int usersNum;
        int countEven = 0;
        int countOdd = 0;

        Console.Write("Enter a number (enter 0 to stop): ");
        usersNum = Convert.ToInt32(Console.ReadLine());

        while (usersNum != 0)
        {

            if (usersNum % 2 == 0)
            {
                countEven++;
            }
            else
            {
                countOdd++;
            }

            Console.Write("Enter a number (enter 0 to stop): ");
            usersNum = Convert.ToInt32(Console.ReadLine());

        }

        Console.WriteLine($"Total even numbers: {countEven}");
        Console.WriteLine($"Total odd numbers: {countOdd}");


        //Task 1.2

        int inputtedNum;
        int largestNum;
        int smallestNum;
        int count;

        Console.Write("Enter a number (You will enter 5 more numbers): ");
        inputtedNum = Convert.ToInt32(Console.ReadLine());

        largestNum = smallestNum = inputtedNum; //assigning both large and small numbers to inputted number by the user

        for (count = 1; count < 6; count++)
        {
           Console.Write("Enter a number: ");
           inputtedNum = Convert.ToInt32(Console.ReadLine());

           if (inputtedNum > largestNum)
           {
               largestNum = inputtedNum;
           }
           if (inputtedNum < smallestNum)
           {
               smallestNum = inputtedNum;
           }
        }
        Console.WriteLine($"The largest number you selected is {largestNum}");
        Console.WriteLine($"The smallest number you selected is {smallestNum}");

        //Task 2.3

        double productPrice1 = 999.99;
        int productQuantity1 = 2;
        double productPrice2 = 19.95;
        int productQuantity2 = 5;
        double productPrice3 = 199.49;
        int productQuantity3 = 1;
        string product1 = "Laptop";
        string product2 = "Mouse";
        string product3 = "Monitor";

        Console.WriteLine($"|{"Item",-15} | {"Qty",8}| {"Price",8}|");
        Console.WriteLine("|----------------|--------:|--------:|");
        Console.WriteLine($"|{product1,-15} | {productQuantity1,8}| {productPrice1,8:C2}|");
        Console.WriteLine($"|{product2,-15} | {productQuantity2,8}| {productPrice2,8:C2}|");
        Console.WriteLine($"|{product3,-15} | {productQuantity3,8}| {productPrice3,8:C2}|");

        //Task 2.4

        double celsius1 = -10;
        double celsius2 = 0;
        double celsius3 = 15;
        double celsius4 = 25;
        double celsius5 = 37.5;
        double celsius6 = 100;

        double fahrenheit1 = (celsius1 * 9 / 5) + 32;
        double fahrenheit2 = (celsius2 * 9 / 5) + 32;
        double fahrenheit3 = (celsius3 * 9 / 5) + 32;
        double fahrenheit4 = (celsius4 * 9 / 5) + 32;
        double fahrenheit5 = (celsius5 * 9 / 5) + 32;
        double fahrenheit6 = (celsius6 * 9 / 5) + 32;

        double kelvin1 = Math.Round(celsius1 + 273.15, 1);
        double kelvin2 = Math.Round(celsius2 + 273.15, 1);
        double kelvin3 = Math.Round(celsius3 + 273.15, 1);
        double kelvin4 = Math.Round(celsius4 + 273.15, 1);
        double kelvin5 = Math.Round(celsius5 + 273.15, 1);
        double kelvin6 = Math.Round(celsius6 + 273.15, 1);

        Console.WriteLine("|Celsius |Fahrenheit|Kelvin   |");
        Console.WriteLine("|--------|----------|---------|");

        Console.WriteLine($"|{celsius1,8:F1}|{fahrenheit1,8:F1}°F|{kelvin1,8:F1}K|");
        Console.WriteLine($"|{celsius2,8:F1}|{fahrenheit2,8:F1}°F|{kelvin2,8:F1}K|");
        Console.WriteLine($"|{celsius3,8:F1}|{fahrenheit3,8:F1}°F|{kelvin3,8:F1}K|");
        Console.WriteLine($"|{celsius4,8:F1}|{fahrenheit4,8:F1}°F|{kelvin4,8:F1}K|");
        Console.WriteLine($"|{celsius5,8:F1}|{fahrenheit5,8:F1}°F|{kelvin5,8:F1}K|");
        Console.WriteLine($"|{celsius6,8:F1}|{fahrenheit6,8:F1}°F|{kelvin6,8:F1}K|");


        //Task 2.5 

           double lightYearKm = 9.461E12;
           double proximaCentauri = 4.24;
           double andromedaGalaxy = 2_500_000;
           double milkyWayDiameter = 105_700;
           double observableUniverse = 93_000_000_000;

           Console.WriteLine("|Object              |Distance (km)         |Scientific Notation   |");
           Console.WriteLine("|--------------------|---------------------:|---------------------:|");

           distance("Proxima Centauri", 4.24 * lightYearKm);
           distance("Andromeda Galaxy", 2_500_000 * lightYearKm);
           distance("Milky Way Diameter", 105_700 * lightYearKm);
           distance("Observable Universe", 93_000_000_000 * lightYearKm);
        }

        static void distance(string name, double km)
        {
           Console.WriteLine($"|{name,-20}|{ScientificNotation(km),20}km|{km,20:E2}km|");
        }
        static string ScientificNotation(double value)
        {
           return $"{value / Math.Pow(10, Math.Floor(Math.Log10(value))):F2} × 10^{(int)Math.Floor(Math.Log10(value))}";
        // Math.log10 calculates the value to base 10: E.G 1000 = 10^3 "returns 3"
        // Math.Floor rounds the value down to the nearest whole number
        // Math.Pow raises the value to the power of the second value


        //Task 3.6

           string name;
           int hourNow = DateTime.Now.Hour;

           Console.WriteLine("Enter your name");
           name = Console.ReadLine();

           GreetUser(name, hourNow);
        }
        static void GreetUser(string name, int hour)
        {
           if (hour >= 0 && hour < 12)
           {
               Console.WriteLine($"Good morning, {name}!");
           }
           else if (hour >= 12 && hour < 18)
           {
               Console.WriteLine($"Good afternoon, {name}!");
           }
           else
           {
               Console.WriteLine($"Good evening, {name}!");
           }

        //Task 3.7

           int num1;

           Console.Write("Enter a number: ");
           num1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($"Square of {num1}: {Square(num1)}");
           Console.WriteLine($"Cube of {num1}: {Cube(num1)}");
        }
        static int Square(int num1)
        {
           return num1 * num1;
        }

        static int Cube(int num1)
        {
           return num1 * num1 * num1;
    }
}