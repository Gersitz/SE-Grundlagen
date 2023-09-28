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
var projectPath = Directory.GetCurrentDirectory();
var csvPath = Path.GetRelativePath(projectPath, @"..\..\..\words\valid_solutions.csv");
var solutionWordList = GetSolutionFromFile(csvPath);

var solutionWord = PickSolution(solutionWordList);

string guess;
while (true)
{
    guess = GetGuess("Guess the 5-letter-word");

    Console.ForegroundColor = ConsoleColor.Black;
    for (int i = 0; i < guess.Length; i++)
    {
        Console.BackgroundColor = ConsoleColor.White;
        if (solutionWord.Contains(guess[i]))
            Console.BackgroundColor = ConsoleColor.DarkYellow;
        if (solutionWord[i] == guess[i])
            Console.BackgroundColor = ConsoleColor.Green;
        Console.Write($"{guess[i]}");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    if (solutionWord == guess)
    {
        Console.WriteLine("\nYou got it!");
    }
    Console.WriteLine();
}

List<string> GetSolutionFromFile(string path)
{
    var solutions = new List<string>();
    using (var reader = new StreamReader(path))
    {
        while (reader.EndOfStream == false)
        {
            var line = reader.ReadLine();
            solutions.Add(line);
        }
    }
    return solutions;
}

string PickSolution(List<string> solutionWordList)
{
    Random rng = new Random();
    var nextSolutionIndex = rng.Next(0, solutionWordList.Count);

    var solutionWord = solutionWordList[nextSolutionIndex];
    solutionWord = solutionWord.ToUpper();
    return solutionWord;
}

string GetGuess(string prompt)
{
    Console.WriteLine(prompt);
    guess = Console.ReadLine();
    guess = guess.ToUpper();
    if (guess.Length != 5) GetGuess(prompt);
    return guess;
}