//2/7/2025*****Assignment 1 Practice=========================================================================================================================================================================================================================================================================

//Question 1: Acme Builder’s Inc. has worked out that the wiring of an average house requires 45m of 14AWG wire. If a contractor has to wire 5 houses, what length of wire will be needed?==========================

//int wirePerHouse = 45;
//int house = 5;
//int totalWiresNeeded = wirePerHouse * house;


//Console.WriteLine("You have 5 houses to wire");
//Console.WriteLine($"There for you need {totalWiresNeeded}m");

//Console.ReadKey();

//Question 2: Burnaby Farms wants to estimate the cost of fertilizing their fields for the coming year. Each hectare of cultivated land requires 15kg and they intend to work 300 hectares. **Cannot be done, no price given per KG. ** Below shows the amount of fertilizer needed?================
//Cannot be done, no price given per KG.
//Below shows the amount of fertilizer needed only

//int hectares = 300;
//int fertilizingPerHectares = 15;
//int totalCostOfFertilizing = hectares * fertilizingPerHectares;

//Console.WriteLine("You have to work on 300 hectares");
//Console.WriteLine($"Thus you will need {totalCostOfFertilizing}kg of fertilizers");

//Console.ReadKey();

//Question 3 Cherry Entertainment Corp. is looking into the profitability of hosting MMA XXII at the Rogers Center. The sale of tickets, broadcasting rights and advertising will gross approximately $2 million.?==========================
//How much profit will Cherry Entertainment Center make if Rogers Centre cost $800,000?

//int possibleProfitability = 2000000;
//int rogersCentreCost = 800000;
//int totalProfitability = possibleProfitability - rogersCentreCost;

//Console.WriteLine($"Your profitability of hosting the MMA XXII at the Rogers Center is ${totalProfitability}");

//Console.ReadKey();

//Question 4 Delta Airlines estimates that the fuel efficiency of a Boeing 747 jet is 12 liters per km. If the price of aviation fuel is $1 per liter, how much would it cost the airline to fly to New York and back from Toronto? ?==========================
//Cannot solve, we dont know the distance from New York to Toronto
//Assuming distance from New York to Toronto is 551.66km

//int fuelEfficiency = 12;
//int aviationFuel = 1;
//double distance = 551.66;
//double totalCost = (fuelEfficiency * aviationFuel * distance) * 2;

//Console.WriteLine($"Your total cost from New York to Toronto is ${totalCost}");

//Console.ReadKey();

//Question 5 Estelle’s Grocery is having a back to school sale of up to 50% off on most food items. The price of potatoes is 11₵ per kg. A plastic bag costs 5₵. What will the total cost (potatoes and bag) if someone buys 25kg of potatoes?==========================

//double pricePerPotatoe = .11;
//double pricePerPlasticBag = .05;
//int purchasedPotatoes = 25;
//double totalCostOfPotatoes = purchasedPotatoes * pricePerPotatoe;
//double discountedPotatoes = totalCostOfPotatoes * .50;
//double totalCostOfBagPlusPotatoes = pricePerPlasticBag + discountedPotatoes;

//Console.WriteLine($"Your total cost of 25kg of potatoes with one plastic bag is: ${totalCostOfBagPlusPotatoes}");

//Console.ReadKey();

//Question 6 Fancy Jewelers is located in the Scarborough Town Center on the second floor near to Wal-Mart. In their Boxing week sale earrings were priced at $20 per pair.========================================================================================================
//If Narendra wants to get a pair for as many females in his family as he can. How many pairs can he get if he has $125? [You may assume that there are more females in his family than he can buy earrings]

//int pricePerPairOfEarrings = 20;
//int spendingMoney = 125;
//int pairsToGet = spendingMoney / pricePerPairOfEarrings;

//Console.WriteLine($"With $125, you can buy {pairsToGet} pairs of earrings");

//Question 7 Gerard The Plumber charges $1.25 per meter for pipe installation. Each join cost 90₵. How much will Gerard charge for a job that is 12m with 4 joins?========================================================================================================

//double plumberCharge = 1.25;
//double costOfJoin = .90;
//double jobLength = 12;
//int jobJoins = 4;
//double totalCostOfJob = (jobLength * plumberCharge) + (costOfJoin * jobJoins);

//Console.WriteLine($"For 12m with 4 joins, Gerard will charge: ${totalCostOfJob}");

//Console.ReadKey();  

//Question 8 Last year at the CNE, the Halls family bought 50 ride tickets. If the Polar Express, the Ferris Wheel, the HighDrop and the WaterFall requires 15, 10, 12 and 9 tickets respectively, how many tickets will remain at the end of the day? ==========================

//int rideTicket = 50;
//int polarExpressTicket = 15;
//int ferrisWheelTicket = 10;
//int highDropTicket = 12;
//int waterFallTicket = 9;
//int ticketsRemaining = rideTicket - (polarExpressTicket +  ferrisWheelTicket + highDropTicket + waterFallTicket);

//Console.WriteLine($" After taking the Polar Express, the Ferris Wheel, the HighDrop and the WaterFall rides, you are left with {ticketsRemaining} ride tickets");

//Console.ReadLine();

//Question 9 Isabelle’s Confectionary sells a packet of Maynard’s sourdrops for 25₵. Each packet contains approximately 30 candies. How many packets will Sarah get if she has $3?========================================================================================================

//double pricePerPacket = .25;
//double currentCash = 3;
//int totalPurchasablePackets = (int) (currentCash / pricePerPacket);// makes it with no decimals at the end

//Console.WriteLine($"With $3, Sarah can get {totalPurchasablePackets} packets of Maynards sourdrops");

//Console.ReadKey();

//Question 10 Jake’s Towing Services works out of the Markham/Finch area. They charge $5.50 per km for towing in addition to a flat service fee of $18. What would be the cost of towing a Toyota RAV 4 from Morningside/Ellesmere to McCowan/Sheppard?  ===================================
//Assume 25km

//double costPerTowing = 5.50;
//double costFlatFee = 18;
//int kmTaking = 25;
//double totalCostTowing = (kmTaking * costPerTowing) + costFlatFee;

//Console.WriteLine($"Your total cost from Morningside/Ellesmere to McCowan/Sheppard is: ${totalCostTowing}");

//Console.ReadKey();

//****Assignment 1 Alternative==================================================================================================================================================================================================================

//Problem 1: Ice Cream Shop Bella's Ice Cream Shop wants to calculate the total cost of ice cream for a customer. The cost is based on the number of scoops and the price per scoop =======================================================
//Output: Total cost of ice cream.
// Inputs: Number of scoops, price per scoop.
// Algorithm:
//     Prompt the user for the number of scoops.
//     Prompt the user for the price per scoop.
//     Calculate the total cost (number of scoops * price per scoop).
//     Display the total cost.

//double numberOfScoops;
//double pricePerScoop;

//Console.WriteLine("How many scoops are you taking today?");
//numberOfScoops = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter price per scoop");
//pricePerScoop = Convert.ToDouble(Console.ReadLine());

//double totalPriceOfIcecream = numberOfScoops * pricePerScoop;

//Console.WriteLine($"Your total cost of your icecream is ${totalPriceOfIcecream}");
//totalPriceOfIcecream = Convert.ToDouble(Console.ReadLine());

//Console.ReadKey();

//Problem 2: Pizza Palace wants to calculate the total cost of a pizza party. The cost is based on the number of pizzas and the price per pizza. ==============================================================================================================
//1. Output: Total cost of the pizza party.
//2. Inputs: Number of pizzas, price per pizza.
//3. Algorithm:
//• Prompt the user for the number of pizzas.
//• Prompt the user for the price per pizza.
//• Calculate the total cost (number of pizzas * price per pizza).
//• Display the total cost.

//double numberOfSlices;
//double pricePerPizza;

//Console.WriteLine("How many slices are you buying today?: ");
//numberOfSlices = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("What is the price per pizza? $ ");
//pricePerPizza = Convert.ToDouble(Console.ReadLine());

//double totalCostOfPizza = numberOfSlices * pricePerPizza;

//Console.WriteLine($"Your total cost of your Pizza is ${totalCostOfPizza}");

//Console.ReadKey();

//Problem 3 Bookworm Bookstore is having a sale. Customers get a 10% discount on their total purchase. Calculate the discounted total.  ==============================================================================================================
//1. Output: Discounted total.
//2.Inputs: Original total purchase.
//3. Algorithm:
//• Prompt the user for the original total purchase.
//• Calculate the discount (10% of the original total).
//• Calculate the discounted total (original total - discount).
//• Display the discounted total

//double originalPurchase;

//Console.Write("How much is the original total purchase you paid: $");
//originalPurchase = Convert.ToDouble(Console.ReadLine());

//double discountPurchase = originalPurchase * .10;
//double discountedTotal = originalPurchase - discountPurchase;

//Console.WriteLine($"Your new discounted purchase price is ${discountedTotal}");

//Problem 4 Cinema World wants to calculate the total cost of movie tickets for a group. The cost is based on the number of tickets and the price per ticket.==============================================================================================================
//1. Output: Total cost of movie tickets.
//2. Inputs: Number of tickets, price per ticket.
//3. Algorithm:
//• Prompt the user for the number of tickets.
//• Prompt the user for the price per ticket.
//• Calculate the total cost (number of tickets * price per ticket).
//• Display the total cost.

//double numberOfTickets;
//double pricePerTicket;

//Console.Write("How many tickets did you purchase? ");
//numberOfTickets = Convert.ToDouble(Console.ReadLine());

//Console.Write("What was the price per ticket? $");
//pricePerTicket = Convert.ToDouble(Console.ReadLine());  

//double totalCostTicket = numberOfTickets * pricePerTicket;

//Console.WriteLine($"Your total cost for your tickets are ${totalCostTicket}");

//Console.ReadKey();

//**************Assignment 2 .============================================================================================================================================================================================================================
//Problem 1 Create a program that prompts the user for her first name, middle initial and last name. The
//program will display the user name three times using the following three formats:
//first name and last name
//first name middle initial and last name
//last name, first name and middle initial
//Example for inputs Barack H Obama
//Barack Obama
//Barack H Obama
//Obama, Barack H

//string firstName;
//string lastName;
//char middleInitials;

//Console.WriteLine($"What is your first name");
//firstName = Console.ReadLine();
//Console.WriteLine($"What is your middle initials");
//middleInitials = Convert.ToChar(Console.ReadLine());
//Console.WriteLine($"What is your last name");
//lastName = Console.ReadLine();

//string fullName = firstName + " " + middleInitials + " " + lastName;

//Console.WriteLine($"{firstName} {lastName}");
//Console.WriteLine($"{fullName}");
//Console.WriteLine($"{lastName} {firstName} {middleInitials}");

//Console.ReadKey();

//Problem 2 Write a program that prompts the user for the number of siblings he has. The program should display a message, “I also have 4 siblings” (assuming that the user enters 4). ==============================================================================

//int siblings;

//Console.Write("How many siblings do you have? ");
//siblings = Convert.ToInt32(Console.ReadLine());

//Console.Write($"I also have {siblings} siblings");

//Console.ReadKey();

//Problem 3 Write a program that prompts the user for two integers.The program will display the result of summing and finding the difference. (If the user enters 8 and 3, the display should be 8 + 3 = 11 and 8 – 3 = 5) ===============================

//double num1;
//double num2;
//Console.WriteLine("Enter first number: ");
//num1=Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter Second number: ");
//num2 = Convert.ToDouble(Console.ReadLine());

//double sum = num1 + num2;
//double difference = num1 - num2;

//Console.WriteLine($"Your sum is {sum}");
//Console.WriteLine($"Your difference is {difference}");

//Console.ReadKey();

//Problem 4 Write a program that prompts the user for the number of siblings they have. The program should display a message, “I have 4 siblings” (assuming that the user enters 3). =============================================================================

//int siblings;

//Console.WriteLine("How many siblings do you have");
//siblings = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"I have 4 siblings");

//Console.ReadKey();

//Problem 5 Write a program to prompt the user to enter a single character. The program should display a message like “Your response was y”. For this question, you must use a variable of type char ==============================================================

//char singleInput;

//Console.WriteLine("Enter a single character");
//singleInput = Convert.ToChar(Console.ReadLine());

//Console.WriteLine($"Your response was {singleInput}");

//Console.ReadKey();

//Problem 6 Write a program to ask the user about the validity of a simple statement. The program should accept the response then display the statement as well as the response. The response should be true or false. For this question, you must use a variable of type bool. ===================
//It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc

//bool statement;

//Console.WriteLine("Are trees made of wood? (True/False)");
//statement = Convert.ToBoolean (Console.ReadLine());

//Console.WriteLine($"{statement}");

//Console.ReadKey();  

//Problem 7 Write a program to calculate the area of a circle. The user will enter the radius of the circle and the program will calculate and display the area according to the formula (area = 3.14 * radius * radius). You must accept fractions as the input. If===================
//the user enters 1.2 for the radius then the area will be 4.52. (Use the "F" format-specifier for floating point values)

//double radius;

//Console.WriteLine("Enter the radius of the circle in question");
//radius = Convert.ToDouble(Console.ReadLine());

//double area = 3.14 * radius * radius;

//Console.WriteLine($"The area of your circle is {area:F2}");

//Console.ReadKey(); 

//Problem 8 Write a program that prompts the user for a number (that may be a fraction). The program reads in the input and
//print the following: the input as a double, the input as an int and finally the input as a char. e.g. if the input is 65.790, then the output will be 65.790, 65, and A========

//double doubleNum;
//int intnum;
//char charnum;

//Console.WriteLine("Enter a number");
//doubleNum = Convert.ToDouble(Console.ReadLine());

//intnum = (int)doubleNum;
//charnum = (char)doubleNum;

//Console.WriteLine($"The input to double is {doubleNum}");
//Console.WriteLine($"The input to integer is {intnum}");
//Console.WriteLine($"The input to double is {charnum}");

//Console.ReadKey();

//Problem 9 Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt the user for the amount of adult and child ticket that they need. The program will display a user-friendly message of the number of tickets brought as well as the total cost. (Use the "C" format-string========
//for currency)

//double adultTicketsNeeded;
//double childrenTicketsNeeded;

//Console.WriteLine("How many Adult Tickets did you need? ");
//adultTicketsNeeded = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("How many Children Tickets did you need? ");
//childrenTicketsNeeded = Convert.ToDouble(Console.ReadLine());

//double adultTickets = 3.75 * adultTicketsNeeded;
//double childTickets = 2.25 * childrenTicketsNeeded;
//double totalAdultAndChildTicket = adultTickets + childTickets;

//Console.WriteLine($"You need {adultTicketsNeeded} adult tickets and {childrenTicketsNeeded} child tickets which is a total cost of {totalAdultAndChildTicket:C2} ");

//Console.ReadKey();

//Problem 10 Write a program to calculate and display the potential difference between the ends of a wire. The program will prompt the user for the current flowing and the resistance of the wire. Potential difference is the product of the current and the resistance of the wire and may
//include a fractional part. (Again, use the "F" format-specifier for floating point values)

//double currentFlow;
//double resistance;

//Console.WriteLine("What is the current Flow");
//currentFlow = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("What is the resistance of the wire");
//resistance = Convert.ToDouble(Console.ReadLine());

//double differenceOfCurrentAndResistance = currentFlow *  resistance;

//Console.WriteLine($"The diference of the current flow and the resistance of the wire is {differenceOfCurrentAndResistance:F2}");

//Console.ReadKey();

//****Pretend Test ============================================================================================================================================================================================================================

//Q1 ============================================================================================================================================================================================================================
//+++++++++++++++++++++++++++
//+Centennial College +
//+941 Progress Avenue   +
//+   Scarborough           +
//+++++++++++++++++++++++++++

//Console.WriteLine("+++++++++++++++++++++++++++");
//Console.WriteLine("+   Centennial College    +");
//Console.WriteLine("+   941 Progress Avenue   +");
//Console.WriteLine("+   Scarborough           +");
//Console.WriteLine("+++++++++++++++++++++++++++");

//Q2============================================================================================================================================================================================================================

//Enter your name: Joe
//Enter you average monthly bill: 100
//Hi Joe, your annual visa bill will be $1,200.00

//string name;

//Console.Write("Enter your name: ");
//name = Console.ReadLine();

//int averageMonthlyBill;

//Console.Write("Enter your average monthly bill: ");
//averageMonthlyBill = Convert.ToInt32(Console.ReadLine());

//int annualVisaBill = averageMonthlyBill * 12;

//Console.Write($"Hi {name}, your annual visa bill will be {annualVisaBill:C2}");

//Console.ReadKey();

//Q3 ============================================================================================================================================================================================================================

//char singleLetter;

//Console.Write("Please enter a single letter: ");
//singleLetter = Convert.ToChar(Console.ReadLine());

//int correspondantValue = (int) singleLetter;

//Console.WriteLine($"The letter {singleLetter} corresponds to the number {correspondantValue}");

//Console.ReadKey();  

//Q4 ============================================================================================================================================================================================================================

//string homePlanet;

//Console.Write("Enter your home planet: ");
//homePlanet = Console.ReadLine().ToLower();

//if (homePlanet == "earth")
//{
//    Console.WriteLine($"{homePlanet}! You are an Earthling and you have 10 fingers");
//}
//else if (homePlanet == "venus")
//{
//    Console.WriteLine("{homePlanet}! You are a Venusian and you have 12 fingers");
//}
//else if (homePlanet == "mars")
//{
//    Console.WriteLine("{homePlanet}! You a Martian and you have 8 fingers");
//}
//else 
//{
//    Console.WriteLine($"{homePlanet}! I am sorry i don't know of that planet");
//}

//Console.ReadKey();

//TEST 01 SAMPLE Question
//Write a program that you get two numbers, and you calculate the summation of them.
//You must check the numbers and none of them should be negative.
//For normal cases:
// Please enter the first number: 10
// Please enter the second number: 25
// The summation of these two numbers is 35
//For negative numbers:
// Please enter the first number: 20
// Please enter the second number: -10
//Negative numbers are not acceptable

//int firstNumber;
//int secondNumber;

//Console.Write("Enter the first number: ");
//firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter the second number: ");
//secondNumber = Convert.ToInt32(Console.ReadLine());

//if (firstNumber < 0 || secondNumber < 0)
//{
//    Console.Write("Negative numbers are not acceptable");
//}
//else 
//{
//    int sumFirstSecond = firstNumber + secondNumber;
//    Console.WriteLine($"The summation of these two number is {sumFirstSecond}");
//}

//============================================================================================================================================================================================================================
//Assignment 3============================================================================================================================================================================================================================
//Q1 Validating Hourly Pay Rate
//o Write a program that prompts the user for an hourly pay rate.
//o If the value entered is less than $7.50 or greater than $49.99, display an
//error message.
//o Otherwise, display a message indicating that the rate is acceptable.

//double hourlyPayRate;

//Console.Write("What is your hourly pay rate? $");
//hourlyPayRate = Convert.ToDouble(Console.ReadLine());

//if (hourlyPayRate < 7.50 || hourlyPayRate > 49.99)
//{
//    Console.WriteLine("Rate not acceptable");
//}
//else 
//{
//    Console.WriteLine("Rate is acceptable");
//}

//2.Bank Interest Calculation============================================================================================================================================================================================================================
//o Write a program that prompts the user for the number of years money was
//left in the bank.
//o If the duration is more than 5 years, apply an interest rate of 7.5%.
//o Otherwise, apply an interest rate of 5.4%.
//o Display the corresponding interest rate

//int numOfYears;
//Console.Write("How many years was your money left in the bank? ");
//numOfYears = Convert.ToInt32(Console.ReadLine());

//if (numOfYears > 5)
//{
//    Console.WriteLine($"7.5%");
//}
//else
//{
//    Console.WriteLine("5.4%");
//}

////3 Social Media Message Length Validation
//o Accept a user's message and check if it is within 140 characters.
//o Display whether the message is acceptable or too long.

//string message;
//Console.WriteLine("Enter your message");
//message = Console.ReadLine();

//if (message.Length < 140)
//{
//    Console.WriteLine("Message acceptable");
//}
//else
//{
//    Console.WriteLine($"Message not acceptable");
//}


// 4 IQ Score Categorization
//o Prompt the user for an IQ score.
//o If the score is less than 0 or greater than 200, issue an error message.
//o Otherwise, categorize the score as:
//▪ Above average(score > 100)
//▪ Average(score = 100)
//▪ Below average(score< 100)

//int iqScore;
//Console.WriteLine("Enter your IQ score");
//iqScore = Convert.ToInt32(Console.ReadLine());

//if (iqScore < 0 || iqScore > 200)
//{
//    Console.WriteLine("Submission Error");
//}
//else if (iqScore > 100)
//{
//    Console.WriteLine("Above Average");
//}
//else if (iqScore == 100)
//{
//    Console.WriteLine("Average");
//}
//else 
//{
//    Console.WriteLine("Below Average");
//}

//5. Payroll Calculation
//o Prompt the user for hourly pay rate and hours worked.
//o Compute gross pay (hours × pay rate), withholding tax, and net pay.
//o Withholding tax rates:
//▪ Up to $300: 10 %
//▪ More than $300: 12 %

//double hourlyPayRate;
//double hoursWorked;

//Console.Write("What is your hourly pay rate? $");
//hourlyPayRate = Convert.ToDouble(Console.ReadLine());

//Console.Write("How many hours did you work? ");
//hoursWorked = Convert.ToDouble(Console.ReadLine());

//double grossPay = hoursWorked *  hourlyPayRate;

//double withholdingTax = 0;

//if (grossPay <= 300)
//{
//    withholdingTax = grossPay * .10;
//}
//else if (grossPay > 300)
//{
//    withholdingTax = grossPay * .12;
//}

//double netPay = grossPay - withholdingTax;

//Console.WriteLine($"Your gross pay is ${grossPay}");
//Console.WriteLine($"Your withholding tax ${withholdingTax}");
//Console.WriteLine($"Your Net Pay is now ${netPay}");

//6 Textbook Pricing
//o The average cost of a textbook is $125.
//o Hardcover books have a 20% premium.
//o If more than 4 books are purchased, apply a 5% discount.
//o Prompt the user for number of hardcover and softcover books and
//calculate the total cost.

//double textBookCost = 125;
//double hardCoverBookPremiumRate = .20;
//double discountRate = .05;

//Console.WriteLine("How many hardcover books did you purchase?");
//int numhardCoverBook = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("How many softcover books did you purchase?");
//int numsoftCoverBook = Convert.ToInt32(Console.ReadLine());

//double hardCoverCost = numhardCoverBook * (textBookCost * (1 + hardCoverBookPremiumRate));
//double softCoverCost = numsoftCoverBook * textBookCost;
//double totalCost = hardCoverCost + softCoverCost;

//if (numhardCoverBook + numsoftCoverBook > 4)
//{
//    totalCost -= totalCost * discountRate;
//}

//Console.WriteLine($"The total cost of your text books are: {totalCost}");

//7 Basic Arithmetic Operations
//o Prompt the user to enter two integers and a character (A, S, M).
//o Perform the following based on the character input:
//▪ A: Add the two numbers.
//▪ S: Subtract the second number from the first.
//▪ M: Multiply the two numbers.
//o Display the result.

//int firstNumber;
//int secondNumber;
//char singleCharacters;

//Console.WriteLine("Enter your first number");
//firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter your second number");
//secondNumber = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter 'A', 'S', or 'M'");
//singleCharacters = Convert.ToChar(Console.ReadLine().ToUpper());

//int sumFirstAndSecond = firstNumber + secondNumber;
//int subtractFirstAndSecond = firstNumber - secondNumber;
//int multiplyFirstAndSecond = firstNumber * secondNumber;

//if (singleCharacters == 'A')
//{
//    Console.Write($"Your summation result is {sumFirstAndSecond}");
//}
//else if (singleCharacters == 'S')
//{
//    Console.Write($"Your Subtracted result is {subtractFirstAndSecond}");
//}
//else if (singleCharacters == 'M')
//{
//    Console.WriteLine($"Your Multiplication result is {multiplyFirstAndSecond}");
//}

//8 Validating Hourly Pay Rate with Retry
//o If the user enters an invalid pay rate (< $7.50 or > $49.99), prompt them
//again.
//o If they enter an invalid value again, display an error message.
//o If a valid value is entered on either attempt, display the pay rate and the
//weekly earnings (hourly rate × 40).

//double hourlyPayRate;
//int attemptCount = 0;

//Console.Write("What is your hourly pay rate? $ ");
//hourlyPayRate = Convert.ToDouble(Console.ReadLine());

//if (hourlyPayRate < 7.50 || hourlyPayRate > 49.99)
//{
//    Console.WriteLine("Invalid value, please enter the hourly pay rate again.");
//    hourlyPayRate = Convert.ToDouble(Console.ReadLine());
//}
//if (hourlyPayRate < 7.50 || hourlyPayRate > 49.99)
//{
//    Console.WriteLine("Invalid value entered twice, exiting");

//}
//else
//{
//    double payRate = hourlyPayRate * 40;
//    Console.WriteLine($"Your pay rate is {payRate}");
//}

//9 College Admissions Decision
//o Prompt for high school GPA and admission test score.
//o Admission criteria:
//▪ GPA ≥ 3.0 and test score ≥ 60 → Accept
//▪ GPA < 3.0 and test score ≥ 80 → Accept
//▪ Otherwise, Reject.

//double highSchoolGpa;
//double admissionTestScore;

//Console.WriteLine("What is your high school GPA? ");
//highSchoolGpa = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("What is your admission test score? ");
//admissionTestScore = Convert.ToDouble(Console.ReadLine());

//if (highSchoolGpa >= 3 && (admissionTestScore >= 60))
//    {
//    Console.Write("Accepted");
//}
//else if (highSchoolGpa < 3 && (admissionTestScore >= 80))
//{
//    Console.Write("Accepted");
//}
//else
//{
//    Console.Write("Rejected");
//}

//10 Lawn Mowing Service
//• Lawn - mowing season lasts 20 weeks.
//• Weekly fee based on lawn size:
//o < 400 sq.ft.: $25 per week
//o 400-599 sq. ft.: $35 per week
//o ≥ 600 sq. ft.: $50 per week
//Calculate weekly and seasonal mowing costs.

