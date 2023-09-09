class Person
{
    public readonly string Name;
    public int Age;

    public Person(string name)
    {
        this.Name = name;
        this.Age = 0;
    }

    public void GrowOlder() => Age++;
}