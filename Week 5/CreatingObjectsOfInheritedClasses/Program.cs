static class Program
{
    public static void Main()
    {
        Person john = new Person("John Doe");
        Student jane = new Student("Jane Doe");
        
        Console.WriteLine(john.Introduce());
        Console.WriteLine(jane.Introduce());
        Console.WriteLine(jane.Status());
        
        jane.Graduate();
        
        Console.WriteLine(jane.Status());
    }
}