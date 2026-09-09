using Microsoft.EntityFrameworkCore;

namespace HRP;

public class Application: IDisposable
{
    private readonly AppDbContext _db;
    private readonly FoodConsole _foodConsole;

    public Application()
    {
        _db=new AppDbContext();
        
        var foods=new FoodCollection(_db);
        var foodService=new FoodService(foods);
        _foodConsole = new FoodConsole(foodService);
    }

    public void Dispose()
    {
        _db.Dispose();
    }

    public void Run()
    {
        _db.Database.Migrate();
        _foodConsole.Run();
        
    }
}