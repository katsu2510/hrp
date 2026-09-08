namespace HRP;

 public abstract class DataRecCollection<T> where T : DataRec,new()
{
    protected readonly AppDbContext Db;
    public List<T> Items {get;} = new();

    public DataRecCollection(AppDbContext db)
    {
        Db=db;
    }

    public virtual void Load()
    {
        Items.Clear();
        Items.AddRange(Db.Set<T>().ToList());
    }

    public void Save(T item)
    {
        
    }

    public void AddNewVisual()
    {
        T item = new T();
        
        foreach (var property in item.GetType().GetProperties())
        {
          if (property.Name=="Id") continue;
          if (!property.CanWrite) continue;
          
          Console.Write($"{property.Name}: ");
          string? input = Console.ReadLine();
          object? value = Convert.ChangeType(input, property.PropertyType);
          property.SetValue(item,value);
        }
    }

    public void New(T item)
    {
        Db.Set<T>().Add(item);
        Db.SaveChanges();
    }
    public void Delete(T item)
    {

        
    }
}