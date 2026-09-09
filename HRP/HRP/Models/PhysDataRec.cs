namespace HRP;

///Has the of batches representing the physical inventory of the items

public abstract class PhysDataRec : DataRec
{
}

public class PhysDataRec<TBatch> : DataRec 
    where TBatch:BatchRec
{
    public List<TBatch> Batches { get; set; } = new();
}