namespace NormalCalculator;

internal class Program
{
    private static int a;
    private static int b;
    private static char symbol;
    private static void Main()
    {   
        while (symbol != 0)
        {
            Console.WriteLine("Type first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type symbol: ");
            symbol = Convert.ToChar(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine(Calc.Choise(a, b, symbol));
        }
    }
}