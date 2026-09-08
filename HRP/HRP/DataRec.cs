namespace HRP;
//Base class for table rows in SQL 
public abstract class DataRec
{
   public int Id { get; set; }
   public string Name { get;  set; }= "";

   public DataRec()
   {
      
   }
}