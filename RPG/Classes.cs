namespace RPG;
public static class Classes
{
    public class Warrior : Character
    {
        public int Rage { get; private set; }
        public Warrior(string name, string gender) : base(name, gender, level: 1, health: 200, attack: 35, magicattack: 10, defense: 10, magicdefense: 5, speed: 100, dodge: 2)
        {
            Rage = 0;
        }
        public void BasicAttack(Character target)
        {
            Console.WriteLine($"{Name} casts attacks {target.Name}!");
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
        public Mage(string name, string gender) : base(name, gender, level: 1, health: 100, attack: 10, magicattack: 35, defense: 5, magicdefense: 10, speed: 100, dodge: 2)
        {
            Mana = 0;
        }
        private void CastMagicShield()
        {
            int defenseChange = (int)(Defense * 0.1);
            int magicDefenseChange = (int)(MagicDefense * 0.25);
            Defense += defenseChange;
            MagicDefense += magicDefenseChange;
            Mana -= 30;
            Console.WriteLine($"{Name} casts a magical shield!\nDefense: + {defenseChange}\nMagic Defense: + {magicDefenseChange}");
        }
        public void CastFireball(Character target)
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
        private void ApplyBurn(Character target)
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
        public Rogue(string name, string gender) : base(name, gender, level: 1, health: 150, attack: 20, magicattack: 10, defense: 10, magicdefense: 5, speed: 120, dodge: 2)
        {
            Shadowforce = 0;
        }
        public override void Attack(Character target, string skillType, string damageCalc, int dmg, int multiplier)
        {
            if (activeStealth)
            {
                AttackPower *= (int)1.3;
                int damage = CalculateDamage(target);
                activeStealth = false;
                Console.WriteLine($"{Name} attacked {target.Name} out of the shadows! Stealth ended.\nDamage dealt: {damage}");
            }
            else
            {
                base.Attack(target, skillType, damageCalc, dmg, multiplier);
            }
        }
        public override void Defend(int damage)
        {
            if (activeStealth)
            {
                if (RandomChance(0.75))
                {
                    Console.WriteLine($"{Name} dodged the attack!");
                }
                else
                {
                    Console.WriteLine($"{Name} was hit and the stealth stance ended.");
                    base.Defend(damage);
                    activeStealth = false;
                }
            }
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
                AttackPower = (int)(AttackPower * 1.5);
                int damage = CalculateDamage(target);
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