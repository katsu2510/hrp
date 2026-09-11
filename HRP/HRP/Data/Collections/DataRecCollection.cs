using Microsoft.EntityFrameworkCore;

namespace HRP;

 public abstract class DataRecCollection<T> where T : DataRec
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

    public virtual void Save(T item)
    {
        
    }

    public virtual bool New(T item)
    {
        try
        {
            Db.Set<T>().Add(item);
            Db.SaveChanges();
            return true;    
        }
        catch (DbUpdateException)
        {
            return false;
        }
        
    }
    public virtual void Delete(T item)
    {

        
    }
}