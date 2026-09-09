namespace HRP;

///The inventory items have quantity and are consumable, adds the consume function 
public abstract class ConsumableDataRec<TBatch> : PhysDataRec<TBatch>
    where TBatch:ConsumableBatchRec
{
    //How many days does the product last when opened 
    public int LifespanDays {get;set;}

    public bool isExpirable {get; set;}

    //primarily will consume 
    public void ConsumeFromDataRec()
    {
        
    }
   
}