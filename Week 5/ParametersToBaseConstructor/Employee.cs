class Employee : Person
{
    public double Salary;

    public Employee(string name, double salary) : base(name)
    {
        this.Salary = salary;
    }
}