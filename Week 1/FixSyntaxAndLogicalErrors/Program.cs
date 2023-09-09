namespace FixSyntaxAndLogicalErrors;

class Program
{
    public static void Main(string[] args)
    {
        double discount = 0.1;
        int price = 55;
        double discountPrice = price * (1 - discount);

        Console.WriteLine($"The discount price is {discountPrice}");
    }
}