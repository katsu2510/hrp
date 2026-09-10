namespace HRP;

public class FoodConsole
{
    private readonly FoodService _foodService;
    public FoodConsole(FoodService foodService)
    {
        _foodService=foodService;
    }

    public void Run()
    {
        bool hasItems;
        hasItems=ShowItems();
        ShowActionMenu(hasItems);
        string? input=Console.ReadLine();
        
        switch (input)
        {
            case "1":
                AddNewItem();
                break;

        }
             
    }

    //returns false if the Collection doesn't contain any visible items for the user
    protected bool ShowItems()
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

    protected void ShowActionMenu(bool isEmpty)
    {
        if (isEmpty)
        {
            Console.WriteLine("Press 1 to add new item, 4 to exit.");
        }
        else
        {
            Console.WriteLine("Press 1 to add new item, 2 to delete an item, 3 to edit an item, 4 to exit.");    
        }
        
    }

    protected void AddNewItem()
    {
        var newFood= new Food();
        Console.Write("Food name: ");
        newFood.Name=(Console.ReadLine()??"").Trim();
        
        Console.Write("Is article expirable? (y/n): ");
        newFood.isExpirable= (Console.ReadLine()?.Trim()=="y");
        
        if (newFood.isExpirable)
        Console.Write("Life ");
        
    }
}