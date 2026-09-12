using HRP.Services;

namespace HRP.User_interface;

public class FoodConsole
{
    private readonly FoodService _foodService;
    public FoodConsole(FoodService foodService)
    {
        _foodService=foodService;
    }

    public void Run()
    {
        bool running=true;
        while (running)
        {
            ShowActionMenu(ShowItems());
            string input=Console.ReadLine()??"";
        
            switch (input.Trim())
            {
                case "1":
                    AddNewItem();
                    break;
            
                case "2":
                    EditItem();
                    break;

                case "3":
                    DeleteItem();
                    break;

                case "0" or "q":
                    Console.WriteLine("Exiting...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
            
    }
        

    //returns false if the Collection doesn't contain any visible items for the user
    private bool ShowItems()
    {
        var items=_foodService.GetItems();
        
        if (!items.Any()){ 
            Console.WriteLine("No items to show.");
        } 
        else
        {
            foreach(var item in items)
            {
                Console.WriteLine(item.Name);  
            }       
        }

        return items.Any();
           
    }

    private void ShowActionMenu(bool isNotEmpty)
    {
        Console.WriteLine("=================");
        Console.WriteLine(isNotEmpty
            ? "Press 1 to add new item, 4 to exit."
            : "Press 1 to add new item, 2 to edit an item, 3 to delete an item, 0 to exit.");
        Console.WriteLine("=================");
        Console.Write("Choose an option:");
    }

    private void AddNewItem()
    {
        var food=new Food();
        food.Name=ConsoleHelper.ReadString("Nameof the food:");                  
        food.IsExpirable=ConsoleHelper.ReadYN("Is the food expirable closed?");
        food.OpenLifespanDays =
            ConsoleHelper.ReadIntNull("Open lifespan days (how long does the food last after being opened):");
    }

    private void EditItem()
    {
        
    }

    private void DeleteItem()
    {
        
    }
}