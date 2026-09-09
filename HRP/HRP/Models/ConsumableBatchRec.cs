namespace HRP;

public abstract class ConsumableBatchRec:BatchRec
{
    public bool isOpen{get; set;}

    //Date when something was opened
    public DateTime OpenedDate{get;set;}

    //Datum expiry date, nebo když je jídlo otvorené a perishable, tak se počítá  
    public DateTime ExpiryDate{get;set;}
    
} 