using static System.Console;

class DemoVariables
{
    private static void Main()
    {
        int num = 4;
        bool num1 = 6 > num;
        WriteLine("When num is {0}, num1 is {1}", num, num1);

        num = 35;
        num1 = 6 > num;
        WriteLine("When num is {0}, num1 is {1}", num, num1);

    }
}
