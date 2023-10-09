namespace RPG;

public class Skill
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string PlayerClass { get; set; }
    public string Type { get; set; }
    public string Target { get; set; }
    public int Damage { get; set; }
    public double DamageMultiplier { get; set; }
    public List<Effect> Effects { get; set; }
    public int Cooldown { get; set; }
    public int Cost { get; set; }

    public Skill(string name, string description, string playerClass, string type, string target, int damage, double damageMultiplier, string effect, int cooldown, int cost)
    {
        Name = name;
        Description = description;
        PlayerClass = playerClass;
        Type = type;
        Target = target;
        Damage = damage;
        DamageMultiplier = damageMultiplier;
        Effects = new List<Effect>();
        Cooldown = cooldown;
        Cost = cost;
    }

    public void AddEffect(Effect effect)
    {
        Effects.Add(effect);
    }
}
public class AttackSkill : Skill
{
    public AttackSkill(string name, string description, string playerClass, string type, string target, int damage, double damageMultiplier, string effect, int cooldown, int cost) : base(name, description, playerClass, type, target, damage, damageMultiplier, effect, cooldown, cost)
    {

    }
    AttackSkill fireOrb = new AttackSkill("Fire Orb", "Launches a burning projectile. Has a chance to burn the target.", "Mage", "Fire", "Enemy", 0, 1.2, "Burn", 0, 10);
    AttackSkill incinerate = new AttackSkill("Incinerate", "Incinerates the target, causing it to burn for 5 rounds", "Mage", "Fire", "Enemy", 0, 1.0, "Burn", 2, 25);
}

public class BuffSkill : Skill
{
    public BuffSkill(string name, string description, string playerClass, string type, string target, string effect, int cooldown, int cost) : base(name, description, playerClass, type, target, damage: 0, damageMultiplier: 0.0, effect, cooldown, cost)
    {

    }
}

public class Effect
{
    public string Name { get; set; }
    public double Chance { get; set; }
    public int Duration { get; set; }

    public Effect(string name, double chance, int duration)
    {
        Name = name;
        Chance = chance;
        Duration = duration;
    }
    Effect fireorbBurn = new Burn(3, 0.10);
    Effect incinerateBurn = new Burn(5, 1.0);
}

public class Burn : Effect
{
    public Burn(int duration, double chance) : base("Burn", chance, duration)
    {
    }

    public void ApplyBurn(Character target)
    {
        int maxHealthPercent = target.Health / 100;
        int damage = new Random().Next(1, 6) * maxHealthPercent;

        Console.WriteLine($"{target.Name} burns!");

        target.TakeDamage(damage);
    }
}