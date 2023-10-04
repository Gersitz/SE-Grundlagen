namespace QuizApp;
internal class Program
{
    static void Main(string[] args)
    {
        var playerName = "";
        var points = 0;

        Console.WriteLine("Willkommen bei der QuizApp! Wie heißt du?");
        playerName = Console.ReadLine();
        while (playerName == "")
        {
            Console.WriteLine("Bitte gib deinen Namen an!");
            playerName = Console.ReadLine();
        }

        Prompts.IntroMessage(playerName);
        Questions.SampleQuestion();

        Prompts.SelectCategory(points);
    }
}
List<Questions> questions = new List<Questions>();

Question
