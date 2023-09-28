/*
 * Programmstart:
 * 
 * Definiere solutionWord als das zu erratende Wort
 * 
 * Schleife:
 *     Definiere guess und speicher das vom User eingegebene Wort
 *     Schleife für jeden Buchstaben in guess:
 *         Schleife für jeden Buchstaben in solutionWord:
 *             Prüfe Buchstabe aus guess gleich Buchstabe in solutionWord:
 *                 Wahr: 
 */
using System.Runtime.CompilerServices;

var solutionWordList = new List<string>();
using (var reader = new StreamReader(@"C:\\Users\\KevinGersitz\\Documents\\Anwendungsentwicklung\\Source\\SE-Grundlagen\\Wordle\\words\\valid_solutions.csv"))
{
    while (reader.EndOfStream == false)
    {
        var line = reader.ReadLine();
        solutionWordList.Add(line);
    }
}

Random rng = new Random();
var nextSolutionIndex = rng.Next(0, solutionWordList.Count);

var solutionWord = solutionWordList[nextSolutionIndex];
solutionWord = solutionWord.ToUpper();

string guess;

while (true)
{
    Console.WriteLine("Guess the word");
    guess = Console.ReadLine();
    guess = guess.ToUpper();
    if (guess.Length != 5) continue;

    // foreach (char c in guess)
    // {
    //     if (solutionWord.Contains(c))
    //         Console.BackgroundColor = ConsoleColor.Yellow;
    //     if (/*...*/)
    //         Console.BackgroundColor = ConsoleColor.Green;
    //     Console.WriteLine($"{c}");
    // }

    /* ToDo:
     * Groß- und Kleinschreibung
     */

    Console.ForegroundColor = ConsoleColor.Black;
    for (int i = 0; i < guess.Length; i++)
    {
        Console.BackgroundColor = ConsoleColor.White;
        if (solutionWord.Contains(guess[i]))
            Console.BackgroundColor = ConsoleColor.Yellow;
        if (solutionWord[i] == guess[i])
            Console.BackgroundColor = ConsoleColor.Green;
        Console.Write($"{guess[i]}");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine();
}