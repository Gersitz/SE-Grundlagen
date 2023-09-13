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

int GetOperation(int number1, int number2)
{
    var mathoperator = "";
    Console.WriteLine("Bitte einen Operator ( +, -, *, / ) angeben");
    mathoperator = Console.ReadLine();
    while (mathoperator != "+" && mathoperator != "-" && mathoperator != "*" && mathoperator!= "/")
    {
        Console.WriteLine("Operator ungültig. Bitte einen gültigen angeben: +, -, *, /");
    }
    switch(mathoperator)
    {
        case "+":
            return number1 + number2;
        case "-":
            return number1 - number2;   
        case "*":
            return number1 * number2;
        case "/":
            return number1 / number2;
    }

}

Console.WriteLine("Willkommen beim Taschenrechner 3000");
var num1 = GetNumber();
var num2 = GetNumber();
var operation = GetOperation(num1, num2);
var sum = num1, operation, num2;
Console.WriteLine($"{num1} {operation} {num2} = {sum}");