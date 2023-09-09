static class Program
{
    public static void Main(string[] args)
    {
        Pet[] pets = new Pet[3]
        {
            new Pet("Dog", "Nugent"),
            new Pet("Cat", "Steve"),
            new Pet("Goldfish", "Brutus")
        };

        foreach (Pet pet in pets)
        {
            Console.WriteLine($"I have a {pet.WhatAmI} named {pet.Name}");
        }
    }
}