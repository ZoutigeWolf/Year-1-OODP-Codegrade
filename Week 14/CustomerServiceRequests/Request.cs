public class Request
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string CustomerName { get; set; }

    public Request(string name, string description, string customerName)
    {
        this.Name = name;
        this.Description = description;
        this.CustomerName = customerName;
    }

    public override string ToString() => $"Name: {Name}\n" +
                                         $"Description: {Description}\n" +
                                         $"Customer Name: {CustomerName}";
}