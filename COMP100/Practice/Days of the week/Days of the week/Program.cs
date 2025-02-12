//int day;
//Console.Write("Please enter a number for a week day: ");
//day = Convert.ToInt32(Console.ReadLine());

//switch (day)
//    {
//    case 1:
//    Console.WriteLine("Mon");
//        break;

//    case 2:
//    Console.WriteLine("Tue");
//        break;

//    case 3:
//    Console.WriteLine("Wed");
//        break;

//    case 4:
//    Console.WriteLine("Thur");
//        break;

//    case 5:
//    Console.WriteLine("Fri");
//         break;
//    case 6: 
//    Console.WriteLine("Sat");
//        break;
//    case 7:
//    Console.WriteLine("Sun");
//        break;
//}


//int season;
//Console.WriteLine("Please enter a number");
//season = Convert.ToInt32(Console.ReadLine());

//switch (season)
//{
//    case 1:
//        Console.WriteLine("Winter");
//        break;

//    case 2:
//        Console.WriteLine("Spring");
//        break;

//    case 3:
//        Console.WriteLine("Summer");
//        break;

//    case 4:
//        Console.WriteLine("Fall");
//        break;

//    case 5:
//        Console.WriteLine("Invalid Season");
//        break;
//}    

//int season;
//Console.WriteLine("Please enter a number");
//season = Convert.ToInt32(Console.ReadLine());

//switch (season)
//{
//    case 12:
//    case 1:
//    case 2:
//        Console.WriteLine("Winter");
//        break;
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("Spring");
//        break;
//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("Summer");
//        break;
//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("Fall");
//        break;
//    default:
//        Console.WriteLine("Invalid entry");
//        break;
//}

//int season;
//Console.WriteLine("Please enter a number");
//season = Convert.ToInt32(Console.ReadLine());

//switch (season)
//{
//    case 12 or 1 or 2:
//        Console.WriteLine("Winter");
//        break;
//    case 3 or 4 or 5:
//        Console.WriteLine("Spring");
//        break;
//    case 6 or 7 or 8:
//        Console.WriteLine("Summer");
//        break;
//    case 9 or 10 or 11:
//        Console.WriteLine("Fall");
//        break;
//    default:
//        Console.WriteLine("Invalid entry");
//        break;
//}

//int year;
//Console.Write("Enter the year of education: ");
//year = Convert.ToInt32(Console.ReadLine());

//switch (year)
//{
//    case 1:
//        Console.WriteLine("Freshmen");
//        break;
//    case 2:
//        Console.WriteLine("Sophomore");
//        break;
//    case 3:
//        Console.WriteLine("Junior");
//        break;
//    case 4:
//        Console.WriteLine("Senior");
//        break;
//    default:
//        Console.WriteLine("Your not suppose to be in Uni");
//        break;
//}

//string name;
//Console.Write("Enter your name please: ");
//name = Convert.ToString(Console.ReadLine());

//switch (name)
//{
//    case "Joe":
//        Console.WriteLine("Hi Joe");
//        break;

//    case "Ghobi":
//        Console.WriteLine("Hi Ghobi");
//        break;
//    default:
//        Console.WriteLine($"Although i dont know you, Hi");
//        break;
//}

//string answer;
//Console.Write("Do you want to have a Coffee Break? (Yes/No)");
//answer = (Console.ReadLine());

//switch (answer)
//{
//    case "Yes":
//    case "yes":
//        Console.WriteLine("Why are you asking Reza? It is obvious that we need a break!");
//        break;
//    case "No":
//    case "no":
//        Console.WriteLine("No! we need to finish this before the break! Continue!");
//        break;
//    default:
//        Console.WriteLine("Please enter yes or no");
//        break;
//}


//*string answer;
//Console.Write("Do you want to have a Coffee Break? (Yes/No)");
//answer = (Console.ReadLine().ToLower());

//switch (answer)
//{
//    case "yes":
//        Console.WriteLine("Why are you asking Reza? It is obvious that we need a break!");
//        break;
//    case "no":
//        Console.WriteLine("No! we need to finish this before the break! Continue!");
//        break;
//    default:
//        Console.WriteLine("Please enter yes or no");
//        break;
//}


//Console.Write("Enter a number: ");
//int input = Convert.ToInt32(Console.ReadLine());
//int remainder = input % 5;
//switch (remainder)
//{
//    case 0:
//        Console.WriteLine("Even");
//        break;
//    default:
//        Console.WriteLine("Odd");
//        break;
//}


//char letter;

//Console.Write("Enter a letter: ");
//letter = Convert.ToChar(Console.ReadLine());
//switch (letter)
//{
//    case 'B':
//    case 'b':
//        Console.WriteLine("Bee");
//        break;
//    case 'D':
//    case 'd':
//    case 'E':
//    case 'e':
//        Console.WriteLine("Desk or Elephant");
//        break;
//    default:
//        Console.WriteLine("Sorry, I don't know that letter");
//        break;
//}

//int choice;
//Console.WriteLine("Enter 1 or 2 or 3");
//choice = Convert.ToInt32(Console.ReadLine());

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("Hello User");
//        break;
//    case 2:
//        Console.WriteLine("Current Date and Time: " + DateTime.Now);
//        break;
//    case 3:
//        Console.WriteLine("Exit- Terminating the program");
//        break;
//    default:
//        Console.WriteLine("Only enter 1 or 2 or 3");
//        break;
//}

//int num1;
//int num2;
//Console.WriteLine("Enter your first number: ");
//num1= Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter your second number: ");
//num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 < 0 || num2 < 0)
//{
//    Console.WriteLine("Negative numbers are not acceptable");
//}
//else  
//{
//    int sum = num1 + num2;
//    Console.WriteLine($"The summation of your numbers are {sum}");
//}
//Console.ReadKey();  