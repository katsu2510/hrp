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

    public ServiceResponse AddNew(Food food)
    {
        List<ValidationError>errors=new();
        if (string.IsNullOrWhiteSpace(food.Name))
        {
            errors.Add(new ValidationError(nameof(food.Name),"Name cannot be empty."));
        }
        
        if (food.IsExpirable && food.OpenLifespanDays<1) 
        {
            errors.Add(new ValidationError(null,"If food is expirable, open lifespan must be greater than zero."));
        }

        var success=_foods.New(
            new Food
            {
                Name = food.Name,
                IsExpirable=food.IsExpirable,
                ClosedLifespanDays=food.ClosedLifespanDays,
                OpenLifespanDays=food.OpenLifespanDays                
            }               
        );

        if (!success)
        {
            errors.Add(new ValidationError(null,"If food is expirable, open lifespan must be greater than zero."));   
        }


        if (errors.Count()==0)  
            return new ServiceResponse(true,errors);
        else
            return new ServiceResponse(false,errors);    
    }


}