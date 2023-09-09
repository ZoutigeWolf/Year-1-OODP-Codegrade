class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        this.Sound = "Woof!";
    }

    public void Fetch() => Console.WriteLine($"{Name} fetches the stick");
}