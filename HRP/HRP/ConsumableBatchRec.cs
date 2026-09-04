namespace HRP;

public class ConsumableBatchRec:BatchRec
{
    public bool isOpen{get; set;}

    //Date when something was opened
    public DateTime OpenedDate{get;set;}

    //Datum expiry date, nebo když je jídlo otvorené a perishable, tak se počítá  
    public DateTime ExpiryDate{get;set;}

    
    public void Open()
    {
        
    }

    //returns True if the item has been fully consumed and should be deleted from the stock
    public bool Consume(float quantity)
    {
      return false;  
    }
} 