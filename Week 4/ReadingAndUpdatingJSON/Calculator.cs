using Newtonsoft.Json;

static class Calculator
{
    private const string FileName = "Memory.json";
    
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b) => a / b;
    public static double Modulo(double a, double b) => a % b;

    public static void StoreInMemory(double value)
    {
        using (StreamWriter stream = new StreamWriter(FileName))
        {
            stream.Write(JsonConvert.SerializeObject(value));
        }
    }

    public static double RestoreFromMemory()
    {
        using (StreamReader stream = new StreamReader(FileName))
        {
            return JsonConvert.DeserializeObject<double>(stream.ReadToEnd())!;
        }
    }
}