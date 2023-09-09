using System.Text;

class ToDo
{
    public List<Task> TaskList = new List<Task>();

    public void AddTask(string name)
    {
        TaskList.Add(new Task(name));
    }

    public Task? GetTask(string name)
    { 
        Task[] res = TaskList.Where(t => t.Name == name).ToArray();

        return res.Length != 0 ? res[0] : null;
    }

    public string Report()
    {
        StringBuilder res = new StringBuilder();

        foreach (Task task in TaskList)
        {
            res.Append($"{task.Info()}\n");
        }

        return res.ToString();
    }
}