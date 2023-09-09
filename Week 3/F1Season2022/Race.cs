class Race
{
    public string Location;
    public List<Driver> Results = new List<Driver>();

    public Race(string location)
    {
        this.Location = location;
    }

    public void Simulate(List<Team> teams)
    {
        List<Driver> drivers = new List<Driver>();
        
        teams.ForEach(t => t.Drivers.ForEach(d => drivers.Add(d)));

        Random random = new Random();

        for (int i = 0; i < drivers.Count; i++)
        {
            int j = random.Next(drivers.Count);

            (drivers[i], drivers[j]) = (drivers[j], drivers[i]);
        }

        Results = drivers;
    }
}