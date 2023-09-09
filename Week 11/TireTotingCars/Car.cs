public class Car
{
    public readonly string Make;
    public readonly string Model;

    public readonly Tire[] Tires;

    public Car(string make, string model, string tireBrand)
    {
        this.Make = make;
        this.Model = model;

        this.Tires = new Tire[4]
        {
            new Tire(tireBrand),
            new Tire(tireBrand),
            new Tire(tireBrand),
            new Tire(tireBrand),
        };
    }

    public bool TryDrive()
    {
        bool canDrive = Tires
            .Select(t => t.Durability > 0)
            .All(t => t);

        if (canDrive)
        {
            foreach (Tire tire in Tires)
            {
                tire.Durability--;
            }
        }

        return canDrive;
    }

    public void ReplaceTire(Tire tire, int index) => Tires[index] = tire;

    public void ReplaceTire(string tireBrand, int index) => ReplaceTire(new Tire(tireBrand), index);

    public void GetTireInfo()
    {
        for (int i = 0; i < Tires.Length; i++)
        {
            Tire tire = Tires[i];
            Console.WriteLine($"Tire {i + 1}: Brand: {tire.Brand}, Durability: {tire.Durability}");
        }
    }
}