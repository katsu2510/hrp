namespace HRP;

public class BatchRec<T> where T: DataRec
{
    public int DataRecId { get; set; }
    public T Item { get; set; }=null!;
    public int LocationId { get; set; }
    public float Quantity { get; set; }
    public DateTime ExpiryDate { get; set; }
    public bool IsOpen { get; set; }
    
}