namespace RPG;
public class Classes
{
    public class Warrior : Character
    {
        public int Rage { get; private set; }
        public Warrior(string name) : base(name, level: 1, health: 200, mana: 100, attack: 35, magicattack: 10, defense: 10, magicdefense: 5, speed: 100)
        {
            Rage = 0;
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
        public void Ragepunch(Character target)
        {
            AttackPower += AttackPower * 110 / 100;
            int damage = CalculateDamage(target);
            target.Defend(damage);
            target.Defense -= 5;
            Rage -= 20;
            Console.WriteLine($"{Name} used Ragepunch!\nDamage dealt: {damage}\n{target.Name}s Defense: -5");
        }
        public override void Attack(Character target)
        {
            int damage = CalculateDamage(target);
            target.Defend(damage);
            Rage += 5;
            Console.WriteLine($"{Name} attacked {target.Name}! Damage dealt: {damage}\nRage: + 5");
        }
    }


    public class Mage : Character
    {
        public Mage(string name) : base(name, level: 1, health: 100, mana: 150, attack: 10, magicattack: 35, defense: 5, magicdefense: 10, speed: 100)
        {

        }
        private void CastMagicShield()
        {
            int defenseChange = (int)(Defense * 0.1);
            int mdefenseChange = (int)(MagicDefense * 0.25);
            Defense += defenseChange;
            MagicDefense += mdefenseChange;
            Mana -= 30;
            Console.WriteLine($"{Name} casts a magical shield!\nDefense: + {defenseChange}\nMagic Defense: + {mdefenseChange}");
        }
        public void CastFireball(Character target)
        {
            int damage = CalculateMagicDamage(target);
            target.Defend(damage);
            Mana -= 15;
            Console.WriteLine($"{Name} casts Fireball on {target.Name}!\nDamage dealt: {damage}");
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
        private bool activeStealth = false;
        public Rogue (string name) : base(name, level: 1, health: 150, mana: 100, attack: 20, magicattack: 10, defense: 10, magicdefense: 5, speed: 120)
        {

        }
        public override void Attack(Character target)
        {
            if (activeStealth)
            {
                int attackChange = (int)(AttackPower * 0.3);
                AttackPower += attackChange;
                int damage = CalculateDamage(target);
                activeStealth = false;
                Console.WriteLine($"{Name} attacked {target.Name} out of the shadows! Stealth ended.\nDamage dealt: {damage}");
            }
            else
            {
                base.Attack(target);
            }
        }
        public override void Defend(int damage)
        {
            if (activeStealth)
            {
                double randomValue = new Random().NextDouble();

                if (randomValue < 0.75)
                {
                    Console.WriteLine($"{Name} dodged the attack!");
                }
                else
                {
                    Console.WriteLine($"{Name} was hit and the Stealth stance ended.");
                    base.Defend(damage);
                    activeStealth = false;
                }
            }
        }
        public void CastStealth()
        {
            Console.WriteLine($"{Name} used Stealth and became hard to see!");
            activeStealth = true;
        }
    }
    public static bool RandomChance(double chance)
    {
        Random random = new Random();
        return random.NextDouble() < chance;
    }
}
