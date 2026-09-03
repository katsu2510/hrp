namespace HRP;

//represents SQL table 
public class DataRecCollection<T> where T : DataRec
{
    private readonly List<T> _items= new();
    private readonly string _dbConnection; 
    private readonly string _tableName; 

    public IEnumerable<T> VisibleItems  => _items;

    public void Load(){

    }
    
}