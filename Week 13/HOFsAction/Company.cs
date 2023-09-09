public class Company
{
    private List<Employee> _employees { get; } = new();
    public void HireEmployee(Employee emp) => _employees.Add(emp);

    public List<Employee> FilterEmployees(Func<Employee, bool> act) => _employees.Where(act).ToList();
}