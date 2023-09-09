namespace TheyllOnlySpeakOfHowYouCodedInCSharp;
public class Player
{
    public string Name;
    public int HealthPoints;
    public int Power;

    public Player(string name, int power)
    {
        this.Name = name;
        this.Power = power;

        this.HealthPoints = 100;
    }

    public bool IsAlive() => HealthPoints > 0;

    public void TakeDamage(int damage) => HealthPoints -= damage <= HealthPoints ? damage : HealthPoints;
}