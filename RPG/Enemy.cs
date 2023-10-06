using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace RPG;

public class Enemy
{ 
    public class ForestSpider : Character
    {
        public ForestSpider(string name) : base(name, gender: "None", level: 1, health: 40, attack: 5, magicattack: 2, defense: 5, magicdefense: 2, speed: 105, dodge: 2, experience: 2, gold: 1)
        {
            
        }
        public void BasicAttack(Character target)
        {
            Attack(target, "basic", "", 0, 1.0);
        }
        public void Bite(Character target)
        {
            Attack(target, "physical", "multiplicative", 0, 1.1);
        }
    }
}
