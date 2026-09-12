namespace HRP;

///The inventory items have quantity and are consumable, adds the consume function 
public abstract class ConsumableDataRec<TBatch> : PhysDataRec<TBatch>
    where TBatch:ConsumableBatchRec
{
    //How many days does the product last closed or not openable.
    public int? OpenLifespanDays {get;set;}
    public bool IsExpirable {get; set;}
    public float TotalQuantity
    {
        get
        {
            float sum=0;
            foreach (var batch in Batches)
            {
                sum+=batch.Quantity;
            }
            return sum;
        }
    }
}