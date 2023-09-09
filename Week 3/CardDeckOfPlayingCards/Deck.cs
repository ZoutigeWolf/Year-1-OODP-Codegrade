class Deck
{
    public readonly List<string> Suits = new List<string>()
    {
        "Diamonds",
        "Clubs",
        "Hearts",
        "Spades"
    };

    public readonly List<string> Ranks = new List<string>()
    {
        "Ace",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "Jack",
        "Queen",
        "King"
    };
    
    public readonly List<Card> Cards;
    public readonly bool AreJokersIncluded;

    public Deck(bool areJokersIncluded)
    {
        this.AreJokersIncluded = areJokersIncluded;
        this.Cards = GenerateCards();
    }

    public List<Card> GenerateCards()
    {
        List<Card> cards = new List<Card>();
        
        Suits.ForEach(s => Ranks.ForEach(r => cards.Add(new Card(s, r))));

        if (AreJokersIncluded)
        {
            cards.Add(new Card("Joker", "Red"));
            cards.Add(new Card("Joker", "Black"));
        }

        return cards;
    }

    public void Shuffle()
    {
        Random random = new Random();
        
        for (int i = 0; i < Cards.Count; i++)
        {
            Card card = Cards[i];
            
            int swapIndex = random.Next(0, Cards.Count);

            Card temp = Cards[swapIndex];

            Cards[swapIndex] = card;
            Cards[i] = temp;
        }
    }

    public Card? Draw()
    {
        if (Cards.Count == 0)
            return null;

        Card card = Cards[^1];

        Cards.Remove(card);

        return card;
    }
}
