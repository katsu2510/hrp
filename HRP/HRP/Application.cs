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

        foreach(Food food in _foods.Items)
        {
          Console.WriteLine(food.Name);  
        }

        
        
    }
}