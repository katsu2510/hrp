using Microsoft.EntityFrameworkCore;

namespace HRP;

public class Application: IDisposable
{
    private readonly AppDbContext _db;
    private readonly FoodCollection _foods;

    public Application()
    {
        _db=new AppDbContext();
        _foods=new FoodCollection(_db);
    }

    public void Dispose()
    {
        _db.Dispose();
    }

    public void Run()
    {
        _db.Database.Migrate();
        _foods.Load();

        while (true)
        {
            foreach(Food food in _foods.Items)
            {
                Console.WriteLine(food.Name);  
            } 
            
            Console.WriteLine("Type add to add new item, edit [id] to edit an item, exit to exit");
            string? input;
            while ((input = Console.ReadLine())==null);
            
            switch (input.ToLower())
            {
                case "add":
                    _foods.AddNewVisual();
                    break;
            }
            
        }
        
    }
}