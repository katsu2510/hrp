using Microsoft.EntityFrameworkCore;

namespace HRP;

public class PhysDataRecCollection<T>:DataRecCollection<T>
            where T: PhysDataRec
{
    public PhysDataRecCollection(AppDbContext db)
        : base(db)
    {
    }
    
    public override void Load()
    {
        Items.Clear();

        Items.AddRange(
            Db.Set<T>()
                .Include(x=>x.Batches)
                .ToList()
        );

    }
} 