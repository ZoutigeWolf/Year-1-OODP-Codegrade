static class Program
{
    public static void Main(string[] args)
    {
        ToDo todo = new ToDo();
        
        todo.AddTask("Mow the lawn");
        todo.AddTask("Suck dick");
        
        todo.GetTask("Suck dick").Done();
        
        Console.WriteLine(todo.Report());
    }
}