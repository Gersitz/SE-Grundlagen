namespace RPG;

public class Player : Character
{
    public List<Skill> Skills {  get; set; }
    public Player(string name, string gender, string playerClass, int level, int health, int attack, int magicattack, int defense, int magicdefense, int speed, int dodge) : base(name, gender, playerClass, level, health, attack, magicattack, defense, magicdefense, speed, dodge, experience: 0, gold: 0)
    {
        Skills = new List<Skill>();
    }

    public void AddSkill(Skill skillName)
    {
        Skills.Add(skillName);
    }

    public void DisplaySkills()
    {
        Console.WriteLine("Available Skills:");
        for (int i = 0; i < Skills.Count; i++)
        {
            Console.WriteLine($"{i + 1} {Skills[i]}");
        }
    }
}
