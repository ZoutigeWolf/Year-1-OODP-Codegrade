class Team
{
    public string Name;
    public List<Driver> Drivers = new List<Driver>();

    public Team(string name)
    {
        this.Name = name;
    }

    public void ContractDriver(Driver driver)
    {
        Drivers.Add(driver);
        driver.Team = this;
    }
}