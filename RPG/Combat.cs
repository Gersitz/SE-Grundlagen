namespace RPG;
using static Player;

public class Combat
{
    public enum CombatResult
    {
        PlayerVictory,
        EnemyVictory,
        Draw
    }

    public static void StartCombat(Player player, Enemy enemy)
    {
        Console.WriteLine($"You encountered a {enemy}!");

        Character currentCharacter = (player.Speed >= enemy.Speed) ? player : enemy;
        Character secondCharacter = (currentCharacter == player) ? enemy : player;

        while (player.IsAlive && enemy.IsAlive)
        {
            currentCharacter.IncrementSpeedCounter();

            if (currentCharacter.SpeedCounter >= 1000)
            {
                if (currentCharacter == player)
                {
                    GetCombatAction(player);
                }
                currentCharacter.SpeedCounter = 0;
            }

            Character temp = currentCharacter;
            currentCharacter = secondCharacter;
            secondCharacter = temp;



            int playerDamage = player.CalculateDamage(enemy);
            enemy.Defend(playerDamage);

            if (!enemy.IsAlive)
            {
                Console.WriteLine($"{enemy} has been defeated!");
                break;
            }
        }

    }

    public static CombatAction GetCombatAction(Player player)
    {
        Console.WriteLine($"{player.Name}'s turn. Choose your action.");
        Console.WriteLine("1) Attack");
        Console.WriteLine("2) Skill");
        Console.WriteLine("3) Use Item");
        Console.WriteLine("4) Wait");
        Console.WriteLine("5) Run away");

        int choice = 0;
        while (choice < 1 || choice > 5)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        switch (choice)
        {
            case 1:
                return CombatAction.BasicAttack;
            case 2:
                return CombatAction.Skill;
            case 3:
                return CombatAction.UseItem;
            case 4:
                return CombatAction.Wait;
            case 5:
                return CombatAction.RunAway;
            default:
                return CombatAction.Unknown;
        }
    }
    public static void PerformAction(Player player, Enemy enemy, CombatAction action)
    {
        int damage = 0;
        switch (action)
        {
            case CombatAction.BasicAttack:
                damage = player.CalculateDamage(enemy);
                break;
            case CombatAction.Skill:
                player.DisplaySkills();

                int skillChoice = 0;
                while (skillChoice < 1 || skillChoice > player.Skills.Count)
                {
                    Console.WriteLine("Choose a skill: ");
                    if (int.TryParse(Console.ReadLine(), out skillChoice))
                    {
                        if (skillChoice < 1 || skillChoice >= player.Skills.Count)
                        {
                            Console.WriteLine("Invalid choice. Please enter a number corresponding to the skill.");
                        }
                    }
                }

                string selectedSkill = player.Skills[skillChoice - 1].Name;

                break;
            case CombatAction.UseItem:
                // Inventar öffnen
                break;
            case CombatAction.Wait:
                Console.WriteLine($"{player.Name} decided to wait this turn out.");
                break;
            case CombatAction.RunAway:
                // Kampf beenden bzw. Chance auf Flucht
                Console.WriteLine($"{player.Name} attempted to run away!");
                break;
            case CombatAction.Unknown:
                Console.WriteLine($"{player.Name} chose an unknown action.");
                break;
            default:
                Console.WriteLine($"{player.Name} chose an unexpected action.");
                break;
        }
    }
}
