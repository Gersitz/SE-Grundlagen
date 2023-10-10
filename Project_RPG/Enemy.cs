namespace Project_RPG;

internal class Enemy : Character
{
    public Enemy(string name, int health, int attackPower, int defense)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        Defense = defense;
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
}
