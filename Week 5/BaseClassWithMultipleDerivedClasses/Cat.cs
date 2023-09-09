class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        this.Sound = "Meow!";
    }
    
    public void Climb() => Console.WriteLine($"{Name} climbs the curtains");

}