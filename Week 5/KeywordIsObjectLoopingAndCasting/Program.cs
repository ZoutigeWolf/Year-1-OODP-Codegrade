static class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person("John Doe"),
            new Student("Jane Doe")
        };
        
        people.ForEach(p =>
        {
            Console.WriteLine(p.Introduce());
            
            if (p is Student s)
                Console.WriteLine(s.Status());
        });
    }
}