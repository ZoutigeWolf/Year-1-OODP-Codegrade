class MyBoolList : MyGenericList<bool>
{
    public MyBoolList(List<bool> elems) : base(elems)
    {
        
    }

    public override bool Combine() => Elems.All(x => x);
}