public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public void UpdateEmployee(Action<Employee> act) => act(this);

    public override string ToString() => $"{Name} ({Salary})";
}