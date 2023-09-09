class Card
{
    public readonly string Suit;
    public readonly string Rank;

    public Card(string suit, string rank)
    {
        this.Suit = suit;
        this.Rank = rank;
    }

    public string GetName() => Suit != "Joker" ? $"{Rank} of {Suit}" : $"{Rank} {Suit}";
}
