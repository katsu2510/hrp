namespace HRP;

public class ConsoleHelper
{
    static public string ReadString(string prompt)
    {
        Console.Write(prompt+": ");
        return Console.ReadLine()??"" .Trim();    
    }

    static public bool ReadYN(string prompt)
    {
        
        string input=Console.ReadLine()??"".Trim().ToLower();
        while (input!="y" && input!="n")
        {
            Console.WriteLine("Please write only 'y' or 'n'.");
            Console.Write(prompt+" (y/n): ");
            input=Console.ReadLine()??"".Trim().ToLower();     
        }           
        
        return input=="y";      
    }

    static public int? ReadIntNull(string prompt)
    { 
        string inputStr;
        int inputInt;

        Console.Write(prompt + ": ");
        inputStr=Console.ReadLine()??"".Trim();
        if (string.IsNullOrEmpty(inputStr))        
            return null;      
        
        while (!int.TryParse(inputStr,out inputInt))
        {
            Console.WriteLine("Please write a whole number.");
            Console.Write(prompt + ": ");
            inputStr=Console.ReadLine()??"".Trim();
            if (string.IsNullOrEmpty(inputStr))        
                return null;             
        }
        return inputInt;
    }
}