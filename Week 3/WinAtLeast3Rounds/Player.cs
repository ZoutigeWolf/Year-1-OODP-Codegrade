class Player
{
    public string Name;
    public int Points = 0;
    public int Skill;
    public int Intelligence;
    public int Knowledge;

    public Player(string name, int skill, int intelligence, int knowledge)
    {
        this.Name = name;
        this.Skill = skill;
        this.Intelligence = intelligence;
        this.Knowledge = knowledge;
    }

    public void Score()
    {
        Points++;
    }

    public static Player? WhoIsWinning(Player a, Player b)
    {
        if (a.Points == b.Points)
            return null;

        return a.Points > b.Points ? a : b;
    }
}