var inputAge = Console.ReadLine();

var age = int.Parse(inputAge);

if (age < 18) // Bedingung ist ein Ausdruck, der True oder False ergibt.
{
    Console.WriteLine("NEIN!");
}
else if (age < 16)
{
    Console.WriteLine("Vielleicht?");
}
else
{
    Console.WriteLine("Willkommen!");
}

Console.WriteLine("Done!");

Console.WriteLine("Bitte gebe eine Zahl für den aktuellen Wochentag ein");
var inputWeekday = Console.ReadLine();

var weekday = int.Parse(inputWeekday);
switch (weekday)
{
    case 1:
        Console.WriteLine("Montag");
        break;
    case 2:
        Console.WriteLine("Dienstag");
        break;
    case 3:
        Console.WriteLine("Mittwoch");
        break;
    case 4:
        Console.WriteLine("Donnerstag");
        break;
    case 5:
        Console.WriteLine("Freitag");
        break;
    case 6:
        Console.WriteLine("Samstag");
        break;
    case 7:
        Console.WriteLine("Sonntag");
        break;
}