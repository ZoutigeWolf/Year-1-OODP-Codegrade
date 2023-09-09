class Game
{
    public Player Player1;
    public Player Player2;

    public Game(Player player1, Player player2)
    {
        this.Player1 = player1;
        this.Player2 = player2;
    }

    public Player Round1() => Player1.Skill >= Player2.Skill ? Player1 : Player2;
    public Player Round2() => Player1.Intelligence >= Player2.Intelligence ? Player1 : Player2;
    public Player Round3() => Player1.Knowledge >= Player2.Knowledge ? Player1 : Player2;

    public static string Instructions() => "Win at least 2 rounds to win!";
}