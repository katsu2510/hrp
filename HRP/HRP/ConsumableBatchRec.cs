namespace HRP;

public class ConsumableBatchRec:BatchRec
{
    public bool isOpen{get; set;}

    public DateTime OpenedDate{get;set;}
    public DateTime ExpiryDate{get;set;}
    
    public bool Consume(float quantity)
    {
      return false;  
    }
} 