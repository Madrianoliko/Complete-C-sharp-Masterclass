Console.WriteLine("Please enter a number");
string userInput = Console.ReadLine();

try
{
    int userInputAsInt = int.Parse(userInput);
    Console.WriteLine(userInputAsInt);
}
catch (FormatException)
{
    Console.WriteLine("Format exception");
}
catch (OverflowException)
{
    Console.WriteLine("Overflow Exception");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Argument Null Exception");
}
catch (Exception)
{
    Console.WriteLine("General exception");
}
finally
{
    Console.WriteLine("Finally This is called anyway!");
}
Console.Read();