using System.Net.Http.Headers;
using System.Numerics;

decimal GetNumber()
{
    decimal num = 0;
    bool checkParse = false;
    do
    {
        Console.WriteLine("Bitte gebe eine Zahl an:");
        string input = Console.ReadLine();
        checkParse = decimal.TryParse(input, out num);

        if (checkParse == false)
        {
            Console.WriteLine("Ungültige Eingabe: Nur Ganzzahlen sind erlaubt");
        }
    } while (checkParse == false);
    return num;
}

string GetOperator()
{
    string mathoperator;
    bool validOperation;

    do
    {
        Console.WriteLine("Wähle eine Operation ( + - * / ):");
        mathoperator = Console.ReadLine();

        validOperation = mathoperator == "+" || mathoperator == "-" || mathoperator == "*" || mathoperator == "/";

        if (validOperation == false)
        {
            Console.WriteLine("Ungültige Operation, versuche es erneut.");
        }
    } while (validOperation == false);

    return mathoperator;
}

decimal Calculate(decimal num1, decimal num2, string mathoperator)
{
    switch (mathoperator)
    {
        case "+":
            return num1 + num2;
        case "-":
            return num1 - num2;
        case "*":
            return num1 * num2;
        case "/":
            return num1 / num2;
        default:
            Console.WriteLine("Fehlerhafte Eingabe, mögliche Werte: + - * /");
            return 0;
    }
}

Console.WriteLine("Willkommen beim Taschenrechner 3000");
bool restartCalc = false;

do
{
    restartCalc = false;
    var num1 = GetNumber();
    var num2 = GetNumber();
    var operation = GetOperator();

    while (num2 == 0 && operation == "/")
    {
        Console.WriteLine("Teilen durch 0 nicht möglich! Bitte wähle die zweite Zahl und den Operator erneut.");
        num2 = GetNumber();
        operation = GetOperator();
    }
        var result = Calculate(num1, num2, operation);
        Console.WriteLine($"{num1} {operation} {num2} = {result}");

    Console.WriteLine("Noch eine Berechnung durchführen? (J/N)");
    var retry = Console.ReadLine();
    do
    {
        if (retry == "J")
        {
            Console.WriteLine("Taschenrechner wird neu gestartet...");
            restartCalc = true;
            break;
        }
        else if (retry == "N")
        {
            Console.WriteLine("Taschenrechner wird beendet...");
            restartCalc = false;
            break;
        }
        else
        {
            Console.WriteLine("Bitte J oder N eingeben.");
            retry = Console.ReadLine();
        }
    } while (retry != "J" || retry != "N");
} while (restartCalc == true);