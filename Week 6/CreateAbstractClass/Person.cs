abstract class Person
{
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }
    public int Age { get; set; }

    protected Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public abstract string Greet();
    public virtual string GetFullName() => $"{FirstName} {LastName}";
}