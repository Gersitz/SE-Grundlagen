using System.Transactions;

namespace Project_RPG;

internal class Program
{
    static void Main(string[] args)
    {

        Prompts.IntroText();
        string playerName = Prompts.CreatePlayer();

        Player player = new Player(playerName, 1, 100, 20, 5, 5, 5, 100, 2, 0);

        Enemy selectedEnemy = Enemy.GetRandomEnemy();

        bool gameOver = false;
        bool activeCombat = true;
        string[] options = { "Attack", "Skill", "Defend", "Item", "Run away" };
        int selectedOptionIndex = 0;

        while (!gameOver)
        {
            while (activeCombat)
            {
                while (selectedEnemy.Health > 0)
                {

                    Console.Clear();

                    Console.WriteLine($"Player: {player.Name} | HP: {player.Health} | Gold: {player.Gold}");
                    Console.WriteLine($"Enemy: {selectedEnemy.Name} | HP: {selectedEnemy.Health}");

                    for (int i = 0; i < options.Length; i++)
                    {
                        Console.SetCursorPosition(0, 5 + i);
                        if (i == selectedOptionIndex)
                        {
                            Console.WriteLine("-> " + options[i]);
                        }
                        else
                        {
                            Console.WriteLine("   " + options[i]);
                        }
                    }

                    var keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            selectedOptionIndex = (selectedOptionIndex - 1 + options.Length) % options.Length;
                            break;
                        case ConsoleKey.DownArrow:
                            selectedOptionIndex = (selectedOptionIndex + 1) % options.Length;
                            break;
                        case ConsoleKey.Enter:
                            string selectedOption = options[selectedOptionIndex];
                            Console.SetCursorPosition(0, 5 + options.Length);
                            if (selectedOption == "Attack")
                            {
                                player.AttackTarget(selectedEnemy);
                            }
                            else if (selectedOption == "Skill")
                            {
                                Console.WriteLine("\nPlease select a skill.");
                            }
                            else if (selectedOption == "Defend")
                            {
                                Console.WriteLine("\nYou are defending yourself.");
                            }
                            else if (selectedOption == "Item")
                            {
                                Console.WriteLine("\nPlease select an item.");
                            }
                            else if (selectedOption == "Run away")
                            {
                                Console.WriteLine("\nYou tried to run away!");
                                Console.WriteLine("It failed!");
                            }

                            selectedEnemy.AttackTarget(player);

                            if (player.Health <= 0)
                            {
                                Console.WriteLine("You lost!");
                                activeCombat = false;
                                gameOver = true;
                                break;
                            }
                            else if (selectedEnemy.Health <= 0)
                            {
                                Console.WriteLine("You won!");

                                int goldFromEnemy = selectedEnemy.GoldValue;
                                Random random = new Random();
                                int goldAmount = random.Next((int)(0.75 * goldFromEnemy), (int)(1.25 * goldFromEnemy));

                                player.AddGold(goldAmount);

                                Console.WriteLine($"You received {goldAmount} Gold!");
                            }
                            Console.WriteLine("\nPress any key to continue.");
                            Console.ReadLine();
                            break;
                    }

                    //selectedEnemy.AttackTarget(player);

                    //if (player.Health <= 0)
                    //{
                    //    Console.WriteLine("You lost!");
                    //    activeCombat = false;
                    //    gameOver = true;
                    //    break;
                    //}
                    //else if (selectedEnemy.Health <= 0)
                    //{
                    //    Console.WriteLine("You won!");

                    //    int goldFromEnemy = selectedEnemy.GoldValue;
                    //    Random random = new Random();
                    //    int goldAmount = random.Next((int)(0.75 * goldFromEnemy), (int)(1.25 * goldFromEnemy));

                    //    player.AddGold(goldAmount);

                    //    Console.WriteLine($"You received {goldAmount} Gold!");
                    //}
                    //Console.WriteLine("\nPress any key to continue.");
                    //Console.ReadLine();
                }

                if (player.Health > 0)
                {
                    Console.WriteLine("Do you want to fight another enemy?");
                    string combatChoice = Console.ReadLine();
                    if (combatChoice == "y")
                    {
                        activeCombat = true;
                        selectedEnemy = Enemy.GetRandomEnemy();
                    }
                    else if (combatChoice == "n")
                    {
                        activeCombat = false;
                    }
                }
                else
                {
                    activeCombat = false;
                }
            }
        }
        Console.WriteLine("You reached the end of the game. Thank you for playing!");
    }
}