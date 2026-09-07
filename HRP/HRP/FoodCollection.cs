namespace HRP;

public class FoodCollection:ConsumableDataRecCollection<Food>
{
    public FoodCollection(AppDbContext db): base(db)
    {
        
    }
}