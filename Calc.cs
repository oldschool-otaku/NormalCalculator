namespace NormalCalculator;

public class Calc
{
    private static int Plus(int a, int b) => a + b;
    private static int Minus(int a, int b) => a - b;
    private static int Divide(int a, int b)
    {
        try { return a / b; }
        catch (DivideByZeroException) 
        {
            Console.WriteLine("Divide by zero!");
            return 0;   
        }
    }
    private static int Multiply(int a, int b) => a * b;
    public static int Choise(int a, int b, char symb)
    {
        return symb switch
        {
            '+' => Plus(a, b),
            '-' => Minus(a, b),
            '*' => Multiply(a, b),
            '/' => Divide(a, b),
            _ => 0
        };
    }
    
}