namespace Project_RPG;

public class Prompts
{
    public static void IntroText()
    {
        Console.WriteLine("╔══════════════════════════════════════════════════════╗");
        Console.WriteLine("║ Welcome to the world of Lutzundgrubia!               ║");
        Console.WriteLine("║ You woke up in the mysterious lands of Lutzundgrubia ║");
        Console.WriteLine("║ without any memories.                                ║");
        Console.WriteLine("║ The last thing you remembered was you waking up.     ║");
        Console.WriteLine("║ An old man sits next to your bed.                    ║");
        Console.WriteLine("║ \"You're finally awake...\", he says.                  ║");
        Console.WriteLine("║                                                      ║");
        Console.WriteLine("║ Are you ready to play? If yes, press Enter.          ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════╝");
        Console.ReadLine();
        Console.Clear();
    }

    public static string CreatePlayer()
    {
        Console.WriteLine("\"I am Baldur. I rescued you, you almost drowned in the sea.\"");
        Console.WriteLine("Baldur looked at you. \"What is your name?\"");
        Console.Write("Please enter your name: ");
        string playerName = Console.ReadLine();

        return playerName;
    }
}
