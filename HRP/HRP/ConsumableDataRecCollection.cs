using Microsoft.EntityFrameworkCore;

namespace HRP;

public class ConsumableDataRecCollection<T>:PhysDataRecCollection<T,ConsumableBatchRec>
    where T : ConsumableDataRec
{
    public ConsumableDataRecCollection(AppDbContext db): base(db)
    {        
    }

    public override void Load()
    {
        Items.Clear();
        Items.AddRange(
            Db.Set<T>()
                .Include(x=>x.Batches.Where(b=>b.Quantity>0))
                .ToList()
        );
    } 


}