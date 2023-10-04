/* To-Do:
 * [x] Begrüße Nutzer
 * [x] Erkläre Nutzer, wie das Quiz funktioniert
 * [] Mind. 10 Fragen erstellen
 * [] 
 */

var points = 0;
var hp = 3;

Console.WriteLine("Willkommen zur Quiz-App!");
Console.WriteLine("Du bekommst zufällig Fragen aus einem Katalog gestellt, die du beantworten musst.");
Console.WriteLine("\nWas ist das Ergebnis aus 5 + 5?");
Console.WriteLine("A: 11 | B: 10 | C: 25 | D: 50");
var input = Console.ReadLine();
var answer = input.ToUpper();
do
{
    if (answer == "B")
    {
        Console.WriteLine("Korrekt! Gut gemacht!");
        points = points + 1;
        Console.WriteLine($"Punkte: {points}\nHP: {hp}");
    }
    else if (answer == "A" || answer == "C" || answer == "D")
    {
        Console.WriteLine("Leider falsch!");
        hp--;
        Console.WriteLine($"Punkte: {points}\nHP: {hp}");
    }
    else
    {
        Console.WriteLine("Bitte mit A, B, C oder D antworten!");
    }
} while (answer != "A" || answer != "B" || answer != "C" || answer != "D");