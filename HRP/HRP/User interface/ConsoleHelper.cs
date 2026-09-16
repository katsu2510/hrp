namespace HRP.User_interface;

public class ConsoleHelper
{
    static public string ReadString(string prompt, out bool cancelledByUser)
    {
        cancelledByUser=false;
        string input;
        Console.Write(prompt+": ");
        input=Console.ReadLine()??"" .Trim();
        if (input.ToLower() == "q")
        {
             cancelledByUser=true;
        }
        return input;  
    }

    static public bool ReadYN(string prompt, out bool cancelledByUser)
    {
        cancelledByUser=false;
        Console.Write(prompt+" (y/n): ");
        string input=Console.ReadLine()??"".Trim().ToLower();
        if (input == "q")
        {
             cancelledByUser=true;
             return false;
        }
        while (input!="y" && input!="n")
        {
            Console.WriteLine("Please write only 'y' or 'n'.");
            Console.Write(prompt+" (y/n): ");
            input=Console.ReadLine()??"".Trim().ToLower();     
        }           
        
        return input=="y";      
    }

    static public int? ReadIntNull(string prompt,out bool cancelledByUser)
    { 
        string inputStr;
        int inputInt;
        cancelledByUser=false;

        Console.Write(prompt + ": ");
        inputStr=Console.ReadLine()??"".Trim();
        if (inputStr.ToLower() == "q")
        {
             cancelledByUser=true;
             return null;
        }
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