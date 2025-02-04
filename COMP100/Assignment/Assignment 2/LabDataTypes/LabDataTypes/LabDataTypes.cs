using System;
class HelloWorld
{
    static void Main()
    {
        //Task 1 Data Types and Type Conversion ---------------------------------------------------------
        Console.WriteLine("Task 1: Data Types and Type Conversion");

        int intValue = 42;
        double doubleValue = 42.42;
        char charValue = 'A';
        bool boolValue = true;

        Console.WriteLine($"Integer Value: {intValue}");
        Console.WriteLine($"Double Value:{doubleValue}");
        Console.WriteLine($"Character Value: {charValue}");
        Console.WriteLine($"Boolean Value:{boolValue}");

        Console.WriteLine("\n ---Type Conversions---");
        string stringInput = "123B";
        int convertedInt = Convert.ToInt32(stringInput.Substring(0, 3));
        double convertedDouble = Convert.ToDouble(stringInput.Substring(0, 3));
        char convertedChar = stringInput[3];
        bool convertedBool = Convert.ToBoolean(stringInput != "0");

        Console.WriteLine($"String to Integer: {convertedInt}");
        Console.WriteLine($"String to Double: {convertedDouble}");
        Console.WriteLine($"String to Character: {convertedChar}");
        Console.WriteLine($"String to Boolean: {convertedBool}");

        //Task 2 String Manipulation ------------------------------------------------------------------
        Console.WriteLine("\nTask 2: String Manipulation");
        string firstName = "John";
        string lastName = "Doe";

        //Concatenation
        string fullNameContact = firstName + " " + lastName;
        Console.WriteLine($"Concatemated String: {fullNameContact}");

        //Verbatim Strings
        string filePath = @"C:\Users\JohnDoe\Documents";
        Console.WriteLine($"Verbatim String (File Path): {filePath}");

        //String Interpolation
        string fullNameInterpolation = $"{firstName} {lastName}";
        Console.WriteLine($"Interpolated String: {fullNameInterpolation}");

        //Multi - line Verbatim String
        Console.Write("Multi-Line Verbatim String: ");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"Full Name: {fullNameInterpolation}");

        //Task 3 Input and Output--------------------------------------------------------------------
        Console.WriteLine("\nTask 3: Input and Output");
        Console.Write("Enter your name: ");
        string? userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}! Welcome to C# Lab.");

        Console.Write("Enter your age: ");
        string? userAge = Console.ReadLine();
        Console.WriteLine($"{userName}, you are {userAge} years old.");

        //Task 4 Numeric Literals--------------------------------------------------------------------
        Console.WriteLine("\nTask 4: Numeric Literals");
        int decimalValue = 255; //Decimal
        int hexValue = 0xFF;  //Hexadecimal   
        int binaryValue = 0b11111111; //Binary
        char convertedCharacter = 'J';
        int asciiValue = (int)convertedCharacter;

        Console.WriteLine($"Decimal:{decimalValue}");
        Console.WriteLine($"Hexadecimal:{hexValue}");
        Console.WriteLine($"Binary:{binaryValue}");
        Console.WriteLine($"Character 'J' Ascii value: {asciiValue}");

        //Task 5 Type Conversion and Casting ---------------------------------------------------------
        Console.WriteLine("\nTask 5: Type Conversion and Casting");

        //Implicit Conversion
        int smallValue = 100;
        double largerValue = smallValue;  //This is implicit
        Console.WriteLine($"Implicit Conversion: {largerValue}");

        //Explicit Conversion
        double preciseValue = 123.45;
        int roundedValue = (int)preciseValue;  //This is explicit
        Console.WriteLine($"Explicit Conversion: {roundedValue}");
        bool trueValue = true;
        int boolToInt = Convert.ToInt32(trueValue);
        Console.WriteLine($"Boolean to Integer: {boolToInt}");

        //Task 6 Decimal Type-----------------------------------------------------------------------
        Console.WriteLine("\nTask 6: Decimal Type");
        decimal price = 19.99m;
        decimal quantity = 3;
        decimal total = price * quantity;
        Console.WriteLine($"Total (Decimal): {total:C}");

        //Task 7 Formatting Numeric Values-------------------------------------------------------- -
        Console.WriteLine("\nTask 7: Formatting Numeric Values");
        double pi = 3.14159265359;
        int hexaValue = 255;
        Console.WriteLine($"Currency: {pi:C}");
        Console.WriteLine($"Fixed Points: {pi:F2}");
        Console.WriteLine($"Exponential: {pi:E}");
        Console.WriteLine($"Hexadecimal: {hexaValue:X}");
    }
}