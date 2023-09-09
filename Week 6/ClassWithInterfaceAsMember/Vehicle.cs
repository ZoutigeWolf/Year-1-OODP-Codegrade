class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    
    public IEngine Engine { get; set; }

    public Vehicle(string make, string model, IEngine engine)
    {
        this.Make = make;
        this.Model = model;
        this.Engine = engine;
    }
}