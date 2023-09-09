class Person
{
    public string Name;
    public Job? DayJob;

    public Person(string name, Job? job)
    {
        this.Name = name;
        this.DayJob = job;
    }

    public string Info() => Name + (DayJob != null ? $" works as a {DayJob.Name}" : $" is in between jobs");
}