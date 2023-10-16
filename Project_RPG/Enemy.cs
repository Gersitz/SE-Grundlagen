namespace Project_RPG;

public class Enemy : Character
{
    public int GoldValue {  get; set; }
    public int Experience { get; set; }

    public Enemy(string name, int level, int health, int attackPower, int magicAttackPower, int defense, int magicDefense, int speed, int dodge, int goldValue, int experience) : base(name, level, health, attackPower, magicAttackPower, defense, magicDefense, speed, dodge)
    {
        GoldValue = goldValue;
        Experience = experience;
    }


    public int AttackPlayer()
    {
        // Angriffslogik
        return AttackPower;
    }

    public int TakeDamage(int damage)
    {
        // Logik für Schadenserleidung
        Health -= damage;
        return Health;
    }

    private static Enemy[] enemies = new Enemy[]
    {
    new Enemy("Spider", 1, 50, 10, 2, 5, 2, 100, 2, 5, 10),
    new Enemy("Wolf", 3, 80, 15, 2, 8, 2, 105, 2, 12, 18),
    };

    public static Enemy GetRandomEnemy()
    {
        Random random = new Random();
        int randomNumber = random.Next(enemies.Length);

        Enemy selectedEnemy = enemies[randomNumber];
        return new Enemy(
        selectedEnemy.Name,
        selectedEnemy.Level,
        selectedEnemy.Health,
        selectedEnemy.AttackPower,
        selectedEnemy.MagicAttackPower,
        selectedEnemy.Defense,
        selectedEnemy.MagicDefense,
        selectedEnemy.Speed,
        selectedEnemy.Dodge,
        selectedEnemy.GoldValue,
        selectedEnemy.Experience
    );
    }
}
