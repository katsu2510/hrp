namespace HRP.Services;

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

    public ServiceResponse Validate(Food food)
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

        return new ServiceResponse(errors.Any(), errors);

    }

    public ServiceResponse AddNew(Food food)
    {
        var serviceResponse = Validate(food);
        
        var success=_foods.New(
            new Food
            {
                Name = food.Name,
                IsExpirable=food.IsExpirable,
                OpenLifespanDays=food.OpenLifespanDays                
            }               
        );

        if (!success)
        {
            serviceResponse.Errors.Add(new ValidationError(null,"Item could not be added."));
        }
        return serviceResponse;
    }

}