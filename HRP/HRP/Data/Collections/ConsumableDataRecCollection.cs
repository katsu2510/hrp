using Microsoft.EntityFrameworkCore;

namespace HRP;

public abstract class ConsumableDataRecCollection<TData,TBatch>
    :PhysDataRecCollection<TData,TBatch>
    where TData: ConsumableDataRec<TBatch>
    where TBatch : ConsumableBatchRec
{
    public ConsumableDataRecCollection(AppDbContext db): base(db)
    {        
    }

    public override void Load()
    {
        Items.Clear();
        Items.AddRange(
            Db.Set<TData>()
                .Include(x=>x.Batches.Where(b=>b.Quantity>0))
                .ToList()
        );
    } 
}