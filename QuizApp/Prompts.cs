namespace QuizApp;
public static class Prompts
{
    public static void UpdatePlayerName(string input, ref string playerName)
    {
        playerName = input;
    }
    public static void IntroMessage(string name)
    {
        Console.WriteLine($"\nHallo, {name}! Ich erkläre dir kurz die QuizApp." +
            $"\nDu fängst mit einfachen Fragen an. Du wirst aufgefordert, eine Kategorie auszuwählen." +
            $"\nIn dieser Kategorie wirst du 3 Fragen gestellt bekommen. Nach Abschluss dieser" +
            $"\nKategorie wird diese für die nächste Runde gesperrt und du wählst deine nächste" +
            $"\nKategorie. Für jede richtige Frage sammelst du Punkte. Je mehr Punkte du hast, desto" +
            $"\nschwieriger werden die Fragen. Du startest mit 3 Leben, kannst allerdings im Laufe des" +
            $"\nSpiels mehr Leben dazugewinnen.");
        Console.WriteLine("\n******************************\n");
        Console.WriteLine("Zum Einstieg eine Testfrage. Bitte antworte auf alle Fragen mit dem" +
            "\njeweiligen Buchstaben A, B, C oder D.");
    }
    public static void SelectCategory(int points)
    {
        Console.WriteLine($"Punkte: {points}");
        Console.WriteLine("Bitte wähle die Kategorie für deine nächsten 3 Fragen.");
        Console.WriteLine("\nAllgemeinwissen | Rechtschreibung | Tiere | Lebensmittel | Geschichte" +
            "\nVideospiele | Musik | Filme | Computer | Geografie | Deutschland");
    }
}

