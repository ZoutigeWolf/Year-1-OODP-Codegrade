class Season
{
    public readonly List<int> Points = new List<int>() { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };
    
    public int Year;
    public List<Race> Races;
    public List<Team> Teams;

    public Season(int year, List<Race> races, List<Team> teams)
    {
        this.Year = year;
        this.Races = races;
        this.Teams = teams;
    }

    public void RunSeason()
    {
        foreach (Race race in Races)
        {
            race.Simulate(Teams);

            for (int i = 0; i < 10; i++)
            {
                race.Results[i].Points += this.Points[i];
            }

            Driver winner = race.Results[0];
            
            Console.WriteLine($"{winner.Name} of {winner.Team.Name} has won the {race.Location} Grand Prix!");
        }
    }

    public void SeasonResults()
    {
        List<Driver> drivers = new List<Driver>();
        
        Teams.ForEach(t => t.Drivers.ForEach(d => drivers.Add(d)));

        drivers = drivers.OrderBy(d => d.Points).ToList();
        drivers.Reverse();

        for (int i = 0; i < drivers.Count; i++)
        {
            Driver driver = drivers[i];
            
            Console.WriteLine($"{i + 1}. {driver.Name}: {driver.Points}");
        }
    }
}