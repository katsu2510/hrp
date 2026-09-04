namespace HRP;

///Has the of batches representing the physical inventory of the items
public class PhysDataRec : DataRec 
{
    public List<BatchRec> Batches { get; set; } = new();
}