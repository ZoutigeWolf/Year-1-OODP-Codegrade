class ListWrapper<T>
{
    private List<T> _myList;

    public int Count
    {
        get => _myList.Count;
    }
    
    public ListWrapper()
    {
        this._myList = new List<T>();
    }

    public void Add(T elem) => _myList.Add(elem);

    public T Get(int index) => _myList[index];
}