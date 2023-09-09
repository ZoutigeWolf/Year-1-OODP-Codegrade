class Person
{
    public string Name;
    public Animal? Pet;

    public Person(string name, Animal? pet)
    {
        Name = name;
        Pet = pet;
    }

    public string Info() => Pet != null ? $"{Name} has a pet that makes the sound {Pet.MakeSound()}" : $"{Name} has no pet";
}