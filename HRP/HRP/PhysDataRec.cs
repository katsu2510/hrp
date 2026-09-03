namespace HRP;

///SQL row representing a physical item with the stock property. 
public class PhysDataRec : DataRec
{
    public List<BatchRec<DataRec>> Batches { get; set; } = new();
}