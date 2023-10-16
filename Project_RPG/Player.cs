namespace Project_RPG;

public class Player : Character
{
    public int Gold { get; set; }

    public Player (string name, int level, int health, int attackPower, int magicAttackPower, int defense, int magicDefense, int speed, int dodge, int gold) : base(name, level, health, attackPower, magicAttackPower, defense, magicDefense, speed, dodge)
    {
        Gold = gold;
    }

    public int AttackEnemy()
    {
        return AttackPower;
    }

    public int TakeDamage(int damage)
    {
        Health -= damage;
        return Health;
    }

    public void AddGold(int amount)
    {
        Gold += amount;
    }
}