namespace FieldsConstructor;
class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("Bruce", "Wayne");
        Person person2 = new Person("Clark", "Kent");
        Person person3 = new Person("Diana", "Prince");

        var personList = new List<Person>() { person1, person2, person3 };

        foreach (var person in personList)
            Console.WriteLine(person.Introduce());
    }
}