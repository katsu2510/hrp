using System.Diagnostics;

namespace HRP; 

public class MainConsole
{
    private readonly FoodService _foodService;
    public MainConsole(FoodService foodService)
    {
        _foodService=foodService;    
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
                _foodService.Run();
                break;    
        }
    }       
        

    protected void WriteMainMenu()
    {
        Console.WriteLine("Choose a module (type number):");
        Console.WriteLine("1: Food");  
    }


}