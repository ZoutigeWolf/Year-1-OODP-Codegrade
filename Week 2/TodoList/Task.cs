class Task
{
    public string Name;
    public bool IsDone = false;

    public Task(string name)
    {
        this.Name = name;
    }

    public void Done()
    {
        IsDone = true;
    }

    public string Info() => $"Task: {Name}, Status: "+ (IsDone ? "Done" : "Pending");
}