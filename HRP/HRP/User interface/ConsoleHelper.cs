namespace HRP;

public class ConsoleHelper
{
    static public string ReadString(string prompt,Boolean required)
    {
        Console.WriteLine();
        return Console.ReadLine()??"" .Trim();    
    }
}