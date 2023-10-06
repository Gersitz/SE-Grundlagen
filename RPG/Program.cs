namespace RPG;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Lutzundgrubia!");

        string playerName = "";
        string gender = "";
        string playerClass = "";

        Console.WriteLine("Please enter your name!");
        while (string.IsNullOrWhiteSpace(playerName))
        {

            playerName = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(playerName))
            {
                Console.WriteLine("Please enter a valid name!");
            }
        }

        Console.WriteLine("Are you male or female? (m/f)");
        while (string.IsNullOrWhiteSpace(gender) || (gender.ToLower() != "m" && gender.ToLower() != "f"))
        {
            gender = Console.ReadLine().Trim().ToLower();
            if (string.IsNullOrWhiteSpace(gender) || (gender.ToLower() != "m" && gender.ToLower() != "f"))
            {
                Console.WriteLine("Please enter your gender!");
            }
        }
        if (gender == "m")
        {
            gender = "male";
        }
        else if (gender == "f")
        {
            gender = "female";
        }

        Console.WriteLine("Which class do you prefer?");
        Console.WriteLine("1: Warrior");
        Console.WriteLine("2: Mage");
        Console.WriteLine("3: Rogue");
        Console.Write("Please enter the number of your desired class.\n");

        int classChoice;

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out classChoice) && classChoice >= 1 && classChoice <= 3)
            {
                switch (classChoice)
                {
                    case 1:
                        playerClass = "Warrior";
                        break;
                    case 2:
                        playerClass = "Mage";
                        break;
                    case 3:
                        playerClass = "Rogue";
                        break;
                }
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter the number corresponding to your desired class.");
            }
        }

        Console.WriteLine("\nCharacter created!");
        Console.WriteLine("Name: " + playerName);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Class: " + playerClass);
    }
}