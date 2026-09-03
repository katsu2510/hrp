namespace HRP;

public class DataRecCollection<T> where T : DataRec
{
    private string _connectionString="";
    private string _tableName="";
    public readonly List<T> Items = new();

    public void Load()
    {
        
    }

    public void Save(T item)
    {
        
    }

    public void New(T item)
    {
    }
    public void Delete(T item)
    {
        
    }
}