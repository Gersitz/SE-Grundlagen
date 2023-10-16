namespace Project_RPG;

public class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int MagicAttackPower { get; set; }
    public int Defense { get; set; }
    public int MagicDefense { get; set; }
    public int Speed { get; set; }
    public int Dodge { get; set; }


    public Character(string name, int level, int health, int attackPower, int magicAttackPower, int defense, int magicDefense, int speed, int dodge)
    {
        Name = name;
        Level = level; 
        Health = health;
        AttackPower = attackPower;
        MagicAttackPower = magicAttackPower;
        Defense = defense;
        MagicDefense = magicDefense;
        Speed = speed;
        Dodge = dodge;
    }

    public virtual int CalculateDamage(Character target)
    {
        int damage = AttackPower;
        return damage > 0 ? damage : 0;
    }

    public virtual int CalculateSkillDamage(Character target, int skillDamage, double multiplier)
    {
        int damage = (int)((AttackPower + skillDamage) * multiplier);
        return damage > 0 ? damage : 0;
    }

    public virtual int Defend(int incomingDamage)
    {
        int damageTaken = incomingDamage - Defense;
        if (damageTaken < 1)
        {
            damageTaken = 1;
        }
        Health -= damageTaken;
        return damageTaken;
    }
    public virtual void AttackTarget(Character target)
    {
        int damage = CalculateDamage(target);
        int damageTaken = target.Defend(damage);
        if (target.Health < 0)
        {
            target.Health = 0;
        }
        Console.WriteLine($"{Name} attacked {target.Name}! {damageTaken} damage dealt.");
    }
}
