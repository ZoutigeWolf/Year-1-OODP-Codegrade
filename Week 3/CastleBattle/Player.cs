class Player
{
    public string Name;
    public int MaxHP;
    public int CurrentHP;
    public int Strength;
    public int Experience = 0;

    public bool IsAlive
    {
        get
        {
            return CurrentHP > 0;
        }
    }

    public Player(string name, int baseHealth, int baseStrength)
    {
        this.Name = name;
        this.MaxHP = baseHealth;
        this.CurrentHP = baseHealth;
        this.Strength = baseStrength;
    }

    public void Attack(Monster monster)
    {
        monster.TakeDamage(Strength);

        if (!monster.IsAlive)
        {
            int oldLevel = GetLevel();
            
            Experience += monster.Experience;

            int newLevel = GetLevel();

            if (newLevel > oldLevel)
            {
                MaxHP += 10;
                Strength += 3;
            }
        }
    }

    public void TakeDamage(int damage) => CurrentHP -= (damage - Strength / 4);

    public int GetLevel()
    {
        for (int i = 0; i < World.ExperienceChart.Count; i++)
        {
            if (Experience < World.ExperienceChart[i])
                return i;
        }

        return World.ExperienceChart.Count;
    }
}