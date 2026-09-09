namespace HRP;

public class FoodService
{
    private readonly FoodCollection _foods;

    public FoodService(FoodCollection foods)
    {
        _foods=foods;
    }

    public IReadOnlyList<Food> GetItems()
    {
        return _foods.Items;
    }
}