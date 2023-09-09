class Job
{
    public string Name;
    public double Salary;

    public Job(string name, double salary)
    {
        this.Name = name;
        this.Salary = salary;
    }

    public Job BiggestSalary(Job that) => this.Salary > that.Salary ? this : that;
}