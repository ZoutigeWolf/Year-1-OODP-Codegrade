static class Program
{
    public static void Main()
    {
        Employee johnDoe = new Employee("John", "Doe", "john.doe@example.com");
        Manager janeDoe = new Manager("Jane", "Doe", "jane.doe@example.com", "Sales");
        SalesPerson bobSmith = new SalesPerson("Bob", "Smith", "bob.smith@example.com", 100000);

        johnDoe.PrintEmployeeInfo();
        (janeDoe as Employee).PrintEmployeeInfo();
        (bobSmith as Employee).PrintEmployeeInfo();
        
        johnDoe.PrintEmployeeInfo();
        janeDoe.PrintEmployeeInfo();
        bobSmith.PrintEmployeeInfo();
    }
}