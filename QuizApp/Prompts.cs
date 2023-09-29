namespace QuizApp;
    public static class Prompts
{
    public static void UpdatePlayerName(string input, ref string playerName)
    {
        playerName = input;
    }
    public static string IntroMessage(string name)
    {
        string playerName = name;
        Console.WriteLine("Willkommen bei der QuizApp!\nWie heißt du?");
        var userInput = Console.ReadLine();
        if (name == null)
        {
            Console.WriteLine("Bitte nenne mir deinen Namen!");
            userInput = Console.ReadLine();
        }
        name = userInput;
        Console.WriteLine($"\nHallo, {name}! Ich erkläre dir kurz die QuizApp." +
            $"\nDu fängst mit einfachen Fragen an. Du wirst aufgefordert, eine Kategorie auszuwählen." +
            $"\nIn dieser Kategorie wirst du 3 Fragen gestellt bekommen. Nach Abschluss dieser" +
            $"\nKategorie wird diese für die nächste Runde gesperrt und du wählst deine nächste" +
            $"\nKategorie. Für jede richtige Frage sammelst du Punkte. Je mehr Punkte du hast, desto" +
            $"\nschwieriger werden die Fragen. Du startest mit 3 Leben, kannst allerdings im Laufe des" +
            $"\nSpiels mehr Leben dazugewinnen.");
        return name;
    }
}

