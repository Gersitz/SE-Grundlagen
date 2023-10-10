namespace Project_RPG;

internal class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    public Character()
    {

    }

    public Character(string name, int health, int attackPower, int defense)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        Defense = defense;
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
        Console.WriteLine($"{Name} attacked {target.Name}! {damageTaken} damage dealt.");
    }
}
