namespace HRP;

public class DataRecCollection<T> where T : DataRec
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

    public void New(T item)
    {
        Db.Set<T>().Add(item);
        Db.SaveChanges();
    }
    public void Delete(T item)
    {

        
    }
}