namespace RPG;
public class Character
{
    public string Name { get; protected set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int AttackPower { get; set; }
    public int MagicAttackPower { get; set; }
    public int Defense { get; set; }
    public int MagicDefense { get; set; }
    public int Speed { get; set; }

    public Character(string name, int level, int health, int mana, int attack, int magicattack, int defense, int magicdefense, int speed)
    {
        Name = name;
        Level = level;
        Health = health;
        Mana = mana;
        AttackPower = attack;
        MagicAttackPower = magicattack;
        Defense = defense;
        MagicDefense = magicdefense;
        Speed = speed;
    }
    public virtual void Attack(Character target)
    {
        int damage = CalculateDamage(target);
        target.Defend(damage);
        Console.WriteLine($"{Name} attacked {target.Name}! Damage dealt: {damage}");
    }
    public virtual void Defend(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
    protected int CalculateDamage(Character target)
    {
        int damage = AttackPower - target.Defense;
        return damage > 0 ? damage : 0;
    }
    protected int CalculateMagicDamage(Character target)
    {
        int damage = MagicAttackPower - target.MagicDefense;
        return damage > 0 ? damage : 0;
    }
}