namespace HRP;

public class BatchRec:DataRec
{
    public int PhysDataRecId { get; set; }
    public PhysDataRec Item {get;set;}=null!;
    public int LocationId { get; set; }
    
}

