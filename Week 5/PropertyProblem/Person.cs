class Person
{
    public Person(string name, int age)
    {
        Name = name;
        _age = (age >= 0 && age <= 130) ? age : 0;
    }

    public string Name { get; set; }
    
    private int _age;
    public int Age
    {
        get => _age;
        set => _age = (value >= 0 && value <= 130) ? value : 0;
    }

    public string Info { get => $"{Name} is {Age} years old"; }
}