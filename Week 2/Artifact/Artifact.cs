public class Artifact
{
    public double Rarity;
    public double Condition;

    public Artifact(double rarity, double condition)
    {
        this.Rarity = rarity;
        this.Condition = condition;
    }

    public double GetValue() => Rarity * Condition;

    public string Appraise() => $"Value: {GetValue()}";

    public bool isEqualTo(Artifact other) => this.Rarity == other.Rarity && this.Condition == other.Condition;
}