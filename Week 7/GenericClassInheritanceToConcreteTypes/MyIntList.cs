class MyIntList : MyGenericList<int>
{
    public MyIntList(List<int> elems) : base(elems)
    {
        
    }

    public override int Combine() => Elems.Sum();
}