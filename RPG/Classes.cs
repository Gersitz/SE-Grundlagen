namespace RPG;
public static class Classes
{
    public class Warrior : Character
    {
        public int Rage { get; private set; }
        public const int MaxRage = 100;
        public Warrior(string name, string gender) : base(name, gender, level: 1, health: 200, attack: 35, magicattack: 10, defense: 10, magicdefense: 5, speed: 100, dodge: 2, experience: 0, gold: 0)
        {
            Rage = 0;
        }

        public List<string> WarriorSkills { get; } = new List<string>();


        public override int CalculateDamage(Character target)
        {
            int baseDamage = base.CalculateDamage(target);
            if (Rage > MaxRage)
            {
                Rage = MaxRage;
            }
            double rageMultiplier = 1.0 + (Rage * 0.005);
            int calculatedDamage = (int)((baseDamage * rageMultiplier) - target.Defense);
            Console.WriteLine($"{Name} attacked {target.Name}!");
            return calculatedDamage;
        }
        public override int CalculateSkillDamage(Character target, int dmg)
        {
            int baseDamage = base.CalculateSkillDamage(target, dmg);
            if (Rage > MaxRage)
            {
                Rage = MaxRage;
            }
            double rageMultiplier = 1.0 + (Rage * 0.005);
            int calculatedDamage = (int)(((baseDamage + dmg) * rageMultiplier) - target.Defense);
            return calculatedDamage;
        }
        public override int CalculateSkillDamagePercent(Character target, double multiplier)
        {
            int baseDamage = base.CalculateSkillDamagePercent(target, multiplier);
            if (Rage > MaxRage)
            {
                Rage = MaxRage;
            }
            double rageMultiplier = 1.0 + (Rage * 0.005);
            int calculatedDamage = (int)(baseDamage * rageMultiplier * multiplier - target.Defense);
            return calculatedDamage;
        }
        public void BasicAttack(Character target)
        {
            Attack(target, "basic", "", 0, 1.0);
            Rage += 5;
        }
        public void Berserk()
        {
            int attackChange = (int)(AttackPower * 0.15);
            int defenseChange = (int)(Defense * 0.05);
            AttackPower += attackChange;
            Defense -= defenseChange;
            Rage += 10;
            Console.WriteLine($"{Name} used Berserk!\nAttack: + {attackChange}\nDefense: - {defenseChange}\nRage: + 10");
        }
        public void Ragefist(Character target)
        {
            int damage = CalculateSkillDamagePercent(target, 10);
            target.Defend(damage);
            target.Defense -= 5;
            Rage -= 20;
            Console.WriteLine($"{Name} used Ragefist!\nDamage dealt: {damage}\n{target.Name}s Defense: -5");
        }
    }


    public class Mage : Character
    {
        public int Mana { get; set; }
        public Mage(string name, string gender) : base(name, gender, level: 1, health: 100, attack: 10, magicattack: 35, defense: 5, magicdefense: 10, speed: 100, dodge: 2, experience: 0, gold: 0)
        {
            Mana = 0;
        }

        public override int CalculateMagicDamage(Character target, int dmg)
        {
            int baseDamage = base.CalculateSkillDamage(target, dmg);
            double mAttackMultiplier = 1.0 + (Mana * 0.001);
            int calculatedDamage = (int)(((baseDamage + dmg) * mAttackMultiplier) - target.Defense);
            return calculatedDamage;
        }
        public override int CalculateMagicDamagePercent(Character target, double multiplier)
        {
            int baseDamage = base.CalculateMagicDamagePercent(target, multiplier);
            double mAttackMultiplier = 1.0 + (Mana * 0.005);
            int calculatedDamage = (int)(baseDamage * mAttackMultiplier * multiplier - target.Defense);
            return calculatedDamage;
        }
        public override int Defend(int damage)
        {
            double mDefenseMultiplier = 1.0 + (Mana * 0.002);
            int finalDefense = (int)(base.Defend(damage) * mDefenseMultiplier);
            base.Defend(finalDefense);
            return finalDefense;
        }
        public void CastMagicShield()
        {
            if (Mana >= 30)
            {
            int defenseChange = (int)(Defense * 0.1);
            int magicDefenseChange = (int)(MagicDefense * 0.25);
            Defense += defenseChange;
            MagicDefense += magicDefenseChange;
            Mana -= 30;
            Console.WriteLine($"{Name} casts a magical shield!\nDefense: + {defenseChange}\nMagic Defense: + {magicDefenseChange}");
            }
            else
            {
                MissingRessources("Mana");
            }
        }
        public void CastFireball(Character target)
        {
            if (Mana >= 15)
            {
                Console.WriteLine($"{Name} casts Fireball on {target.Name}!");
                Attack(target, "magic", "multiplicative", 0, 1.5);
                Mana -= 15;

                if (RandomChance(0.10))
                {
                    ApplyBurn(target);
                    Console.WriteLine($"{target} started to burn!");
                }
            }
            else
            {
                MissingRessources("Mana");
            }

        }
        public void ApplyBurn(Character target)
        {
            int damage = (int)(target.Health * 0.05);
            target.Health -= damage;
            Console.WriteLine($"{target.Name} loses {damage} HP due to the burning effect!");
        }
    }


    public class Rogue : Character
    {
        public bool activeStealth = false;
        public int Shadowforce { get; set; }
        public Rogue(string name, string gender) : base(name, gender, playerClass: "Rogue", level: 1, health: 150, attack: 20, magicattack: 10, defense: 10, magicdefense: 5, speed: 120, dodge: 2, experience: 0, gold: 0)
        {
            Shadowforce = 0;
        }

        public override int Defend(int damage)
        {
            if (activeStealth)
            {
                if (RandomChance(0.75))
                {
                    Console.WriteLine($"{Name} dodged the attack!");
                    damage = 0;
                }
                else
                {
                    Console.WriteLine($"{Name} was hit and the stealth stance ended.");
                    base.Defend(damage);
                    activeStealth = false;
                }
            }
            return damage;
        }
        public override int CalculateDamage(Character target)
        {
            int baseDamage = base.CalculateDamage(target);

            if (activeStealth)
            {
                int damage = (int)(AttackPower * 1.2) - target.Defense;
                Console.WriteLine($"{Name} attacked {target.Name}!\n{Name} left the Stealth stance.\nDamage dealt: {damage}");
                return damage > 0 ? damage : 0;
            }
            return baseDamage;
        }
        public override int CalculateSkillDamage(Character target, int dmg)
        {
            int baseDamage = base.CalculateSkillDamage(target, dmg);

            if (activeStealth)
            {
                int damage = (int)((AttackPower + dmg) * 1.2) - target.Defense;
                return damage > 0 ? damage : 0;
            }
            return baseDamage;
        }
        public override int CalculateSkillDamagePercent(Character target, double multiplier)
        {
            int baseDamage = base.CalculateSkillDamagePercent(target, multiplier);

            if (activeStealth)
            {
                int damage = (int)(AttackPower * 1.2) - target.Defense;
                return damage > 0 ? damage : 0;
            }
            return baseDamage;
        }

        public void CastStealth()
        {
            if (Shadowforce >= 45)
            {
                Console.WriteLine($"{Name} used Stealth and became hard to see!");
                activeStealth = true;
                Shadowforce -= 45;
            }
            else
            {
                MissingRessources("Shadowforce");
            }
        }
        public void CastBackstab(Character target)
        {
            if (activeStealth)
            {
                int CurrentAttackPower = AttackPower;
                CalculateSkillDamagePercent(target, 1.5);
                AttackPower = CurrentAttackPower;
            }
            else
            {
                base.CalculateDamage(target);
            }
        }
    }
    public static bool RandomChance(double chance)
    {
        Random random = new Random();
        return random.NextDouble() < chance;
    }
}