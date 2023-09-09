class Monster
{
    public string Name;
    public int HP;
    public int Strength;
    public int Experience;
    
    public bool IsAlive
    {
        get
        {
            return HP > 0;
        }
    }

    public Monster(string name, int health, int strength, int experience)
    {
        this.Name = name;
        this.HP = health;
        this.Strength = strength;
        this.Experience = experience;
    }

    public void Attack(Player player)
    {
        player.TakeDamage(Strength);
    }

    public void TakeDamage(int damage) => HP -= damage;

}