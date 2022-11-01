internal class Program
{
    private static void Main(string[] args)
    {
        WriteSomething();
        WriteSomethingSpecific("Specific text");
    }

    // acces modifier (static) return type method name (parameter1, parameter2)
    public static void WriteSomething()
    {
        Console.WriteLine("i am called from a method");
        Console.Read();
    }

    public static void WriteSomethingSpecific(string myText)
    {
        Console.WriteLine(myText);
        Console.Read();
    }
}
