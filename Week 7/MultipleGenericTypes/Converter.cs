static class Converter
{
    public static TOut ConvertVariables<TIn, TOut>(TIn obj)
    {
        return (TOut)Convert.ChangeType(obj, typeof(TOut));
    }
}