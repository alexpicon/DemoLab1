namespace DemoConsoleApp;

public static class Calculator
{
    public static int Add(int a, int b) => a + b;

    public static int Subtract(int a, int b) => a - b;

    public static int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"2 + 3 = {Calculator.Add(2, 3)}");
        Console.WriteLine($"10 - 4 = {Calculator.Subtract(10, 4)}");
        Console.WriteLine($"6 * 7 = {Calculator.Multiply(6, 7)}");
    }
}
