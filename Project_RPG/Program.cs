namespace Project_RPG;

internal class Program
{
    static void Main(string[] args)
    {

        Prompts.IntroText();
        string playerName = Prompts.CreatePlayer();

        Player player = new Player(playerName, 100, 20, 5);
        Enemy enemy = new Enemy("Spider", 50, 10, 5);

        bool gameOver = false;
        string[] options = { "Attack", "Skill", "Defend", "Item", "Run away" };
        int selectedOptionIndex = 0;

        while (!gameOver)
        {
            Console.Clear();

            string healthbar = healthbar()
            Console.WriteLine($"Player: {player.Name} | HP: {player.Health} ║{healthbar}║" );
            Console.WriteLine($"Enemy: {enemy.Name} | HP: {enemy.Health} | Attack: {enemy.AttackPower}");

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

            ConsoleKeyInfo keyInfo = Console.ReadKey();

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
                        player.AttackTarget(enemy);
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
                    break;
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("You lost!");
                gameOver = true;
            }
            else if (enemy.Health <= 0)
            {
                Console.WriteLine("You won!");
                gameOver = true;
            }

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadLine();
            }
        }

        Console.WriteLine("You reached the end of the game. Thank you for playing!");
    }
}