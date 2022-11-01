internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Multiply(1, 2));
        Console.WriteLine(Divide(15,123));
        Console.Read();
    }
    public static int Add(int digit1, int digit2)
    {
        return digit1 + digit2;
    }
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    public static double Divide(double num1, double num2)
    {
        return num1 / num2;
    }
}