using System.Collections;

public class People : IEnumerable<Person>
{
    public List<Person> people = new List<Person>();

    public void Add(Person person) => people.Add(person);

    public IEnumerator<Person> GetEnumerator()
    {
        foreach (Person person in people)
        {
            yield return person;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}