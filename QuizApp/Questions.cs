namespace QuizApp;
public static class Questions
{
    public static void SampleQuestion()
    {
        Console.WriteLine("Was ist das Ergebnis von 5 + 5?");
        Console.WriteLine("A: 11 | B: 10 | C: 15 | D: 50");
        var input = Console.ReadLine();
        var answer = input.ToUpper();
        do
        {
            if (answer == "B")
            {
                Console.WriteLine("Richtig! Du hast die Testfrage bestanden!" +
                    "\n\n******************************\n");
            }
            else if (answer == "A" || answer == "C" || answer == "D")
            {
                Console.WriteLine("Leider falsch! Versuche eine andere Antwort.");
                input = Console.ReadLine();
                answer = input.ToUpper();
                if (answer == "B")
                {
                    Console.WriteLine("Richtig! Du hast die Testfrage bestanden!" +
                        "\n\n******************************\n");
                }
            }
            else
            {
                Console.WriteLine("Bitte antworte mit A, B, C oder D!");
                input = Console.ReadLine();
                answer = input.ToUpper();
                if (answer == "B")
                {
                    Console.WriteLine("Richtig! Du hast die Testfrage bestanden!" +
                        "\n\n******************************\n");
                }
            }
        } while (answer != "B");

    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string category { get; set; }
    }
    public class QuestionList
    {
        private List<Questions> questions = new List<Questions>();
        private Dictionary<string, List<Questions>> QuestionCategories = new Dictionary<string, List<Questions>>();
        private Random rng = new Random();

        public void AddQuestion(Question)
    }
}
Frage