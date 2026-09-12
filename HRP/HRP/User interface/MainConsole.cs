using HRP.User_interface;

namespace HRP; 

public class MainConsole
{
    private readonly FoodConsole _foodConsole;
    public MainConsole(FoodConsole foodConsole)
    {
        _foodConsole=foodConsole;    
    }

    public void Run()
    {
        MainMenu();   
    }

    protected void MainMenu()
    {
        WriteMainMenu();
        string? input=Console.ReadLine()??"";

        switch (input.Trim())
        {
            case "1":
                _foodConsole.Run();
                break;    
        }
    }       
        

    protected void WriteMainMenu()
    {
        Console.WriteLine("Choose a module (type number):");
        Console.WriteLine("1: Food");  
    }


}