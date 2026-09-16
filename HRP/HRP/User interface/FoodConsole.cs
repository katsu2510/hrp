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
            ? "Press 1 to add new item, 2 to edit an item, 3 to delete an item, 0 to exit." 
            : "Press 1 to add new item, 4 to exit.");
        Console.WriteLine("=================");
        Console.Write("Choose an option:");
    }

    private void ResolveErrors(ServiceResponse response)
    {
        if (response.Errors.Count()==0)
        {
            return;
        }

        //TODO 
    }

    private void AddNewItem()
    {
        bool cancelled=false;
        var food=new Food();
        food.Name=ConsoleHelper.ReadString("Name of the food", out cancelled);                  
        food.IsExpirable=ConsoleHelper.ReadYN("Is the food expirable closed?", out cancelled);
        food.OpenLifespanDays =
            ConsoleHelper.ReadIntNull("Open lifespan days (how long does the food last after being opened)",
                                        out cancelled);
        
        var response=_foodService.AddNew(food);
        if (response.Success)
        {
            Console.WriteLine("Added new item successfully.");
        }
        else
        {
            ResolveErrors(response);
        }
    }

    private void EditItem()
    {
        
    }

    private void DeleteItem()
    {
        
    }
}