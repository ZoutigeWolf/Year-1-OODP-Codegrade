namespace FieldsConstructor;
public class Person
{
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string Introduce() => $"I am {FirstName} {LastName}";
}