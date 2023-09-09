class Company
{
    public List<Employee> Employees;
    public int WhatIsConsideredDistant;
    public int ExtraTravelAllowanceBudget;
    public int MaxExtraTravelAllowance;
    public string LogLocation;
    public Company()
    {
        Employees = new List<Employee>();
        WhatIsConsideredDistant = 25;
        ExtraTravelAllowanceBudget = 300;
        MaxExtraTravelAllowance = 100;
        LogLocation = "./Log.txt";
    }

    public void Hire(Employee employee) => Employees.Add(employee);

    public void PayMonthlySalary()
    {
        foreach (var employee in Employees)
        {
            employee.SalaryEarned += employee.Salary + CalculateTravelAllowance(employee);
        }
    }

    private int CalculateTravelAllowance(Employee employee)
    {
        int distantEmployeeCount = HowManyDistantEmployees();
        int closeEmployeeCount = Employees.Count - distantEmployeeCount;
        
        int standardTravelAllowance = employee.DistanceFromCompany * 10;
        
        int extraTravelAllowanceDistant = distantEmployeeCount > 0 ? Math.Min(
            ExtraTravelAllowanceBudget / distantEmployeeCount,
            MaxExtraTravelAllowance) : 0;
        
        int extraTravelAllowanceClose = closeEmployeeCount > 0 ? Math.Min(
            (ExtraTravelAllowanceBudget - extraTravelAllowanceDistant * distantEmployeeCount) / closeEmployeeCount, 
            100) : 0;
        
        return standardTravelAllowance +
               (employee.DistanceFromCompany >= WhatIsConsideredDistant ?
                   extraTravelAllowanceDistant : extraTravelAllowanceClose);
    }

    private int HowManyDistantEmployees()
    {
        int howMany = 0;
        foreach (var employee in Employees)
        {
            if (employee.DistanceFromCompany >= WhatIsConsideredDistant)
                howMany++;
        }
        return howMany;
    }

    private List<Employee> GetDistantEmployees()
    {
        List<Employee> employees = new List<Employee>();
        
        foreach (var employee in Employees)
        {
            if (employee.DistanceFromCompany >= WhatIsConsideredDistant)
                employees.Add(employee);
        }

        return employees;
    }
}