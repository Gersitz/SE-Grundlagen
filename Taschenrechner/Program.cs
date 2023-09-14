using System.Numerics;

int GetNumber()
{
    int num = 0;
    bool checkParse = false;
    do
    {
        Console.WriteLine("Bitte gebe eine Zahl an:");
        string input = Console.ReadLine();
        checkParse = int.TryParse(input, out num);

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

int Calculate(int num1, int num2, string mathoperator)
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
            if (num2 == 0)
            {
                Console.WriteLine("Durch 0 kann nicht geteilt werden");
                break;
            }
            return num1 / num2;
        default:
            Console.WriteLine("Fehlerhafte Eingabe, mögliche Werte: + - * /");
            return 0;
    }
}

Console.WriteLine("Willkommen beim Taschenrechner 3000");
var num1 = GetNumber();
var num2 = GetNumber();
var operation = GetOperator();

var result = Calculate(num1, num2, operation);
Console.WriteLine($"{num1} {operation} {num2} = {result}");