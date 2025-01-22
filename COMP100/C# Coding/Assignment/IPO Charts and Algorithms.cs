// Input
double numberOfScoops;
double pricePerScoop;

// Output
double totalCost;

// Processing
// no variable needed

// Algorithm
Console.Write("Enter number of scoops added: ");

numberOfScoops = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter price per scoop: $");

pricePerScoop = Convert.ToDouble(Console.ReadLine());

totalCost = numberOfScoops * pricePerScoop;

Console.WriteLine("Total cost of ice-cream for a customer is: $" + totalCost);
