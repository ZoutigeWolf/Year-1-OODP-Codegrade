class Scale
{
    public bool UseKg = true;

    public static double ConvertKgToLbs(double value) => value * 2.2;

    public string DisplayWeight(double value) => UseKg ? $"{value} kg" : $"{ConvertKgToLbs(value)} lbs";
}