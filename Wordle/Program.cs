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

var solutionWord = "HOTEL";

string guess;

while (true)
{
    Console.WriteLine("Errate das 5-stellige Wort");
    guess = Console.ReadLine();
    if (guess.Length != 5) continue;

    // foreach (char c in guess)
    // {
    //     if (solutionWord.Contains(c))
    //         Console.BackgroundColor = ConsoleColor.Yellow;
    //     if (/*...*/)
    //         Console.BackgroundColor = ConsoleColor.Green;
    //     Console.WriteLine($"{c}");
    // }

    for (int i = 0; i < guess.Length; i++)
    {
        if (solutionWord.Contains(guess[i]))
            Console.BackgroundColor = ConsoleColor.Yellow;
        if (solutionWord[i] == guess[i])
            Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine($"{guess[i]}");
    }
}