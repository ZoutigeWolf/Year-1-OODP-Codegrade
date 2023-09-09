class Consultant : IPayable
{
    public string Name { get; set; }
    public string Info
    {
        get => $"{Name}; {HourlyRate}/hour";
    }
    
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Consultant(string name, double hourlyRate)
    {
        Name = name;
        HourlyRate = hourlyRate;
    }

    public double GetPaymentAmount() => HoursWorked * HourlyRate;
}