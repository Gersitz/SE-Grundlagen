namespace AbstrakteKlasse;

// Eine abstrakte Klasse verfügt über alle Merkmale einer normalen Klasse.
// Jedoch können keine Objekte einer abstrakten Klasse erstellt werden.
// Nur durch Klassen, die von dieser erben, kann auf deren Member-Variablen zugegriffen werden.
// 
// abstract class <Klassenname>
abstract class Tier
{
    string name;
    int alter;

    public string Name { get => name; set => name = value; }
    public int Alter { get => alter; set => alter = value; }

    public void AlterAbfrage()
    {
        Console.WriteLine($"Das Alter dieses Tieres ist {Alter} Jahre.");
    }

    // Es kann auch eine abstrakte Methode erstellt werden.
    // Dies erfolgt mit folgender Syntax:
    //
    // <Zugriffsmodifikator> abstract <Rückgabewert> <Methodenname>();
    //
    // Eine abstrakte Methode hat keinen Body (Codeblock). Dieser wird erst in den Kindklassen initialisiert.

    public abstract void Tierlaut();

    // Wir wechseln in die Hund.cs
}
