static class Program
{
    public static void Main(string[] args)
    {
        Person john = new Person("John", new List<Pet>()
        {
            new Pet("Dog", "Nugent"),
            new Pet("Cat", "Steve"),
            new Pet("Goldfish", "Brutus")
        });

        foreach (Pet pet in john.Pets)
        {
            Console.WriteLine($"{john.Name} has a {pet.WhatAmI} named {pet.Name}");
        }
    }
}