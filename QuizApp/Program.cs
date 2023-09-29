namespace QuizApp;
internal class Program
{
    static void Main(string[] args)
    {
        var playerName = "1";
        var points = 0;

        Console.WriteLine("Willkommen bei der QuizApp! Wie heißt du?");
        playerName = Console.ReadLine();
        // Prompts.UpdatePlayerName(inputName, ref playerName);
        Console.WriteLine(playerName);
    }
}
