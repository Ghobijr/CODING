internal class Program
{
   //Task 1
   static string gameTitle = "Adventure Time";

   private static void Main(string[] args)
   {
       string gameTitle = "Time for an adventure";
       for (int player = 1; player <= 3; player++)
       {
           Console.WriteLine($"Player {player} joined");
       }
       Console.WriteLine($"Local game title: {gameTitle}");
       Console.WriteLine($"Global game title: {Program.gameTitle}");
   }
}


internal class Program2
{
   //Task 2
   private static void Main(string[] args)
   {
       int level = 5;
       UpdateStats(ref level, out int newScore);
   }
   static void UpdateStats(ref int level, out int newScore)
   {
       Random random = new Random();

       level++;
       newScore = (random.Next(1000, 5000));

       Console.WriteLine($"Updated Level: {level}");
       Console.WriteLine($"New Score: {newScore}");
   }
}

internal class Program3
{

    //Task3
    private static void Main(string[] args)
    {

        Console.WriteLine(GenerateRandomChar());
        Console.WriteLine(GenerateDoubleRange());

        string[] petNames = { "Fluffy", "Spot", "Rex", "Joe", "Whiskers", "Roy", "Max", "Bella", "Lucy", "Daisy" };
        Console.WriteLine(randomPetName(petNames));
    }

    static char GenerateRandomChar()
    {
       Random rand = new Random();
       char randomChar = (char)rand.Next('A','Z');

       return randomChar;
    }

    static double GenerateDoubleRange()
    {
       Random rand = new Random();
       double randomDouble = rand.Next(1, 100);

       return randomDouble;
    }

    static string randomPetName(string[] namedPet)
    {
       Random random = new Random();
   
       return namedPet[random.Next(namedPet.Length)];
    }
}

