namespace HRP;

public class FoodCollection:ConsumableDataRecCollection<Food,FoodBatch>
{
    public FoodCollection(AppDbContext db): base(db)
    {
        
    }

}