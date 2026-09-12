namespace HRP;

public abstract class PhysDataRecCollection<TData, TBatch>
    : DataRecCollection<TData>
    where TData : PhysDataRec<TBatch>
    where TBatch : BatchRec
{
    public PhysDataRecCollection(AppDbContext db)
        : base(db)
    {
    }
    
    public override void Load()
    {
        Items.Clear();

        Items.AddRange(
            Db.Set<TData>()
                .Include(x=>x.Batches)
                .ToList()
        );

    }
} 