using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace RPG;
public class Character
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int MagicAttackPower { get; set; }
    public int Defense { get; set; }
    public int MagicDefense { get; set; }
    public int Speed { get; set; }
    public int Dodge { get; set; }

    public Character(string name, string gender, int level, int health, int attack, int magicattack, int defense, int magicdefense, int speed, int dodge)
    {
        Name = name;
        Gender = gender;
        Level = level;
        Health = health;
        AttackPower = attack;
        MagicAttackPower = magicattack;
        Defense = defense;
        MagicDefense = magicdefense;
        Speed = speed;
        Dodge = dodge;
    }
    public void Attack(Character target, string skillType, string damageCalc, int dmg, double multiplier)
    {
        if (skillType == "basic")
        {
            int damage = CalculateDamage(target);
            target.Defend(damage);
            Console.WriteLine($"Damage dealt: {damage}");
        }
        else if (skillType == "physical")
        {
            if (damageCalc == "additive")
            {
                int damage = CalculateSkillDamage(target, dmg);
                target.Defend(damage);
                Console.WriteLine($"Damage dealt: {damage}");
            }
            else if (damageCalc == "multiplicative")
            {
                int damage = CalculateSkillDamagePercent(target, multiplier);
                target.Defend(damage);
                Console.WriteLine($"Damage dealt: {damage}");
            }
        }
        else if (skillType == "magic")
        {
            if (damageCalc == "additive")
            {
                int damage = CalculateMagicDamage(target, dmg);
                target.Defend(damage);
                Console.WriteLine($"Damage dealt: {damage}");
            }
            else if (damageCalc == "multiplicative")
            {
                int damage = CalculateMagicDamagePercent(target, multiplier);
                target.Defend(damage);
                Console.WriteLine($"Damage dealt: {damage}");
            }
        }
    }
    public virtual int Defend(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
        return damage;
    }
    public virtual int CalculateDamage(Character target)
    {
        int damage = AttackPower - target.Defense;
        Console.WriteLine($"{Name} attacked {target.Name}!");
        return damage > 0 ? damage : 0;

    }
    public virtual int CalculateSkillDamage(Character target, int dmg)
    {
        int damage = AttackPower + dmg - target.Defense;
        return damage > 0 ? damage : 0;
    }
    public virtual int CalculateSkillDamagePercent(Character target, double multiplier)
    {
        int damage = (int)(AttackPower * multiplier) - target.Defense;
        return damage > 0 ? damage : 0;
    }
    public virtual int CalculateMagicDamage(Character target, int dmg)
    {
        int damage = MagicAttackPower + dmg - target.MagicDefense;
        return damage > 0 ? damage : 0;
    }
    public virtual int CalculateMagicDamagePercent(Character target, double multiplier)
    {
        int damage = (int)(MagicAttackPower * multiplier) - target.MagicDefense;
        return damage > 0 ? damage : 0;

    }
    protected string MissingRessources(string ressource)
    {
        string prompt = $"Not enough {ressource}!";
        return prompt;
    }
    public void IncreaseLevel()
    {
        if (Level < 10)
        {
            Level += 1;
            Health += 10;
            AttackPower += 2;
            MagicAttackPower += 2;
            Defense += 1;
            MagicDefense += 1;
        }
        else if (Level < 30)
        {
            Level += 1;
            Health += 15;
            AttackPower += 3;
            MagicAttackPower += 3;
            Defense += 2;
            MagicDefense += 2;
        }
        else if (Level < 50)
        {
            Level += 1;
            Health += 20;
            AttackPower += 4;
            MagicAttackPower += 4;
            Defense += 2;
            MagicDefense += 2;
        }
        else
        {
            Level += 1;
            Health += 25;
            AttackPower += 5;
            MagicAttackPower += 5;
            Defense += 3;
            MagicDefense += 3;
        }
    }
}