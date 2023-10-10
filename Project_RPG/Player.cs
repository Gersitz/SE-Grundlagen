namespace Project_RPG;

internal class Player : Character
{
    public Player (string name, int health, int attackPower, int defense)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        Defense = defense;
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
}