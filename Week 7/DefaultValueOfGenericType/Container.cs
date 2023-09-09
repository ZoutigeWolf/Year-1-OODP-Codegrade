class Container<T>
{
    public T Value { get; set; }

    public Container(T value)
    {
        this.Value = value;
    }

    public void ResetValue()
    {
        Value = default;
    }
}