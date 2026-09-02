namespace HRP;

public class DataRecCollection<T> where T : DataRec
{
    private readonly List<T> _items;
    public IEnumerable<T> VisibleItems  => _items;
    
}