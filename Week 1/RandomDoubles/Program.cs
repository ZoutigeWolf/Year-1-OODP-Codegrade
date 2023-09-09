namespace RandomDoubles;
class Program
{
    public static void Main(string[] args)
    {
        int attack = 50;
        double critChance = 0.33;
        int bossHP = 1000;

        Random random = new Random();

        while (bossHP > 0)
        {
            bool crit = random.NextDouble() <= critChance;

            int damage =  crit ? attack * 2 : attack;

            Console.WriteLine($"Boss HP: {bossHP}");
            Console.WriteLine($"Damage: {damage}");

            bossHP -= damage;
        }

        Console.WriteLine("Boss defeated");
    }
}