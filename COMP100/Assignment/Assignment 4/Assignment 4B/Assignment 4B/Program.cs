using System.Linq.Expressions;

internal class Program
{
    private static void Main()
    {
        runMyCode();
    }

    static void runMyCode()
    {
        //Task 1=========================================================================================
        //try
        //{

           Console.Write("Enter the first number: ");
           double num1 = Convert.ToDouble(Console.ReadLine());

           Console.Write("Enter the second number: ");
           double num2 = Convert.ToDouble(Console.ReadLine());


           Console.Write("Enter an operation (+,-,*,/): ");
           char operationSelect = Convert.ToChar(Console.ReadLine());

           switch (operationSelect)
           {
               case '+':
                   Console.WriteLine($"Result:{num1 + num2}");
                   break;

               case '-':
                   Console.WriteLine($"Result:{num1 - num2}");
                   break;

               case '*':
                   Console.WriteLine($"Result:{num1 * num2}");
                   break;

               case '/':
                   if (num2 == 0)
                       Console.WriteLine("Error: Division by 0 is not allowed");
                   else
                       Console.WriteLine($"Result:{num1 / num2}");
                   break;

               default:
                   Console.WriteLine("You have entered an invalid operation");
                   break;
           }

           Console.ReadKey();
        }

        //catch (Exception Error)
        //{
        //    Console.Write($"Invalid input detected.. Press any key to retry");
        //    Console.ReadKey();
        //    Console.Clear();
        //    runMyCode();
        //}

        //        Task 2=========================================================================================

        try
        {
                       Console.Write("Enter your numeric grade (0-100): ");
                       int numericGrade = Convert.ToInt32(Console.ReadLine());

                       switch (numericGrade)
                       {
                           case 100: case 99: case 98: case 97: case 96: case 95: case 94: case 93: case 92: case 91: case 90:
                               Console.WriteLine("Your letter grade is : A");
                               break;

                           case 89: case 88: case 87: case 86: case 85: case 84: case 83: case 82:  case 81: case 80:
                               Console.WriteLine("Your letter grade is : B");
                               break;

                           case 79: case 78: case 77: case 76: case 75: case 74: case 73: case 72:  case 71: case 70:
                               Console.WriteLine("Your letter grade is : C");
                               break;

                           case 69: case 68: case 67: case 66: case 65: case 64: case 63: case 62: case 61: case 60:
                               Console.WriteLine("Your letter grade is : D");
                               break;

                           case 59: case 58: case 57: case 56: case 55: case 54: case 53: case 52: case 51: case 50:
                           case 49: case 48: case 47: case 46: case 45: case 44: case 43: case 42: case 41: case 40:
                           case 39: case 38: case 37: case 36: case 35: case 34: case 33: case 32: case 31: case 30:
                           case 29: case 28: case 27: case 26: case 25: case 24: case 23: case 22: case 21: case 20:
                           case 19: case 18: case 17: case 16: case 15: case 14: case 13: case 12: case 11: case 10:
                           case 9: case 8: case 7: case 6: case 5: case 4: case 3: case 2: case 1: case 0:
                               Console.WriteLine("Your letter grade is : F");
                               break;

                           default:
                               Console.WriteLine("Invalid entry");
                               break;

                       }
                       Console.ReadKey();
        //            }

        //            catch (Exception Error)
        //            {
        //                Console.Write($"Invalid range input, Press any key to retry");
        //                Console.ReadKey();
        //                Console.Clear();
        //                runMyCode();
        //            }

        //        Task 3  =========================================================================================

        //try
        {
           Console.WriteLine("Vending Machine Menu:");
           Console.WriteLine("1. Coffee - $2.50");
           Console.WriteLine("2. Tea - $2.00");
           Console.WriteLine("3. Soda - $1.50");
           Console.WriteLine("4. Water - $1.00");
           Console.WriteLine("5. Juice - $3.00");
           Console.Write("Enter your choice (1-5): ");
           int choiceselection = Convert.ToInt32(Console.ReadLine());

           switch (choiceselection)
           {
               case 1:
                   Console.WriteLine("You selected Coffee. The price is $2.50");
                   break;

               case 2:
                   Console.WriteLine("You selected Tea. The price is $2.00");
                   break;

               case 3:
                   Console.WriteLine("You selected Soda. The price is $1.50");
                   break;

               case 4:
                   Console.WriteLine("You selected Water. The price is $1.00");
                   break;

               case 5:
                   Console.WriteLine("You selected Juice. The price is $3.00");
                   break;

               default:
                   Console.WriteLine("Invalid Entry Selection");
                   break;
           }

        }

        //catch (Exception ex)
        //{
        //    Console.Write($"Invalid option selection, Press any key to retry");
        //    Console.ReadKey();
        //    Console.Clear();
        //    runMyCode();
        //}

    }

}
