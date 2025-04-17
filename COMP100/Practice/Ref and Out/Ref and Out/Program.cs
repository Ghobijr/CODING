// See https://aka.ms/new-console-template for more information


int var_a = 5;
Console.WriteLine($"Before method call {var_a}");
Twice(ref var_a);
Console.WriteLine($"After method call {var_a}");

static void Twice( ref int a)
{
   a *= 2;
   Console.WriteLine($"In method call {a}");
}


class Program
{
   static void Main(string[] args)
   {
       int num = 10;
       Console.WriteLine($"The value of number before calling the normal method is {num}");
       Addnumber(num);
       Console.WriteLine($"The value of number after calling the normal method is {num}");
       Console.WriteLine($"##################################################");
       Console.WriteLine($"The value of number before calling the ref method is {num}");
       Addnumber(ref num);
       Console.WriteLine($"The value of number after calling the ref method is {num}");

       Console.ReadLine();
   }

   static void Addnumber(int number)
   {
       number++;
       Console.WriteLine($"The value of number inside the method is {number}");
   }

   static void Addnumber(ref int number)
   {
       number++;
       Console.WriteLine($"The value of number inside the method with ref is {number}");
   }
}

class Program
{
   public static void Main()
   {
       double radius = 10;
       double area;
       double volume;

       Console.WriteLine($"Radius: {radius:f2}, area: {CalArea(radius):f2}, volume: {CalVol(radius):f2}");
       Console.ReadKey();
   }

   static double CalArea(double r) //out modifier
   {
       double a = Math.PI * r * r;
       return a;//out parameter must be initialized
   }

   static double CalVol(double r) //out modifier
   {
       double v = 4 * Math.PI * r * r * r / 3;
       return v;//out parameter must be initialized
   }
}

class Program
{
   public static void Main()
   {
       double radius = 10;
       double area;
       double volume;

       CalAreaVol(radius, out area, out volume); //out modifier specified
       Console.WriteLine($"Radius: {radius:f2}, area: {area:f2}, volume: {volume:f2}");
       Console.ReadKey();
   }
   static void CalAreaVol(double r, out double a, out double v) //out modifier
   {
       a = Math.PI * r * r;         //out parameter must be initialized
       v = 4 * Math.PI * r * r * r / 3; //out parameter must be initialized
   }
}

int i = 1;
Console.WriteLine("Previous value of integer i:" + i.ToString());
GetNextName(ref i);
Console.WriteLine("Current value of integer i:" + i.ToString());
static void GetNextName(ref int id)
{
   id += 1;
}

int j = 1;
Console.WriteLine("Previous value of integer j:" + j.ToString());
GetNextNameByOut(out j);
Console.WriteLine("Current value of integer j:" + j.ToString());

static void GetNextNameByOut(out int idj)
{
   idj = 2;
}

double fees = CalculateFees(5, 549.99);
Console.WriteLine($"The fee value {fees}");
fees = CalculateFees(numberOfCourses: 5, cost: 549.99);
Console.WriteLine($"The fee value {fees}");
fees = CalculateFees(cost: 549.99, numberOfCourses: 5);
Console.WriteLine($"The fee value {fees}");

double CalculateFees(int numberOfCourses, double cost)
{
   return numberOfCourses * cost;
}


//// Instantiate random number generator using system-supplied value as seed.
//var rand = new Random(54321);

//// Generate and display 5 random byte (integer) values.
//var bytes = new byte[5];

////NextBytes(byte[] bytes) is a method of the Random class 
////that fills the provided byte array with random values.
rand.NextBytes(bytes);
Console.WriteLine("Five random byte values:");
foreach (byte byteValue in bytes)
   Console.Write("{0, 5}", byteValue);
Console.WriteLine();

Random rand = new Random();
// Generate and display 5 random integers.
Console.WriteLine("Five random integer values:");
for (int ctr = 0; ctr <= 4; ctr++)
{
   var mayVal = Math.Round((rand.NextDouble()) * 40);
   Console.Write($"{mayVal,15:F0}");
}
Console.WriteLine();


Random rand2 = new Random();
// Generate and display 5 random integers.
Console.WriteLine("Five random integer values:");
for (int ctr = 0; ctr <= 4; ctr++)
{
   var mayVal = Math.Round (rand2.NextDouble(),2) * 40 + 140;
   Console.Write($"{mayVal,15:F0}");
}
Console.WriteLine();


var rand = new Random();
// Generate and display 5 random integers.
Console.WriteLine("Five random integer values:");
for (int ctr = 0; ctr <= 4; ctr++)
{
   Console.Write($"{rand.Next(25, 100),5:N0}");
}
Console.WriteLine();

class Program
{
   //create the random object
   static Random rand = new Random(100);
   public static void Main()
   {
       //declare and allocate for 100 int element
       char[] letters = new char[5];
       //loop to set each item to a random value
       for (int i = 0; i < letters.Length; i++)
       {
           letters[i] = (char)rand.Next('A', 'Z');
       }

       foreach (char letter in letters)
       {
           Console.WriteLine(letter);
       }
   }
}


class Program
{   //create the random object
   static Random rand = new Random();
   public static void Main()
   {
       //declare the source of my random names
       string[] names = { "Bart", "Arya", "Curt", "Eden", "Fred", "Gina", "Jack", "Dave", "Kate" };

       //declare the source of my random pets
       string[] pets = { "dog", "cat", "hamster", "parrot", "buggie", "spider", "rabbit", "snake" };

       //declare the resulting sentences
       string[] result = new string[5];

       //loop to build the sentences
       for (int i = 0; i < result.Length; i++)
       {
           string name = names[rand.Next(names.Length)];
           string pet = pets[rand.Next(pets.Length)];
           int age = rand.Next(5, 10);
           result[i] = $"{name} is my {pet}. She/He is {age} months old.";
           Console.WriteLine(result[i]);
       }
   }
}



PrintAstrick(10);
static void PrintAstrick(int n)
{
   for (int i = 1; i <= n; i++)
   {
       for (int j = 1; j <= n; j++)
       {
           Console.Write("* ");
       }
       Console.WriteLine();
   }
}