namespace AbstrakteKlasse;

internal class Hund : Tier
{
    string fellfarbe;

    public Hund (string name, int alter, string fellfarbe)
    {
        Name = name;
        Alter = alter;
        Fellfarbe = fellfarbe;
    }

    public string Fellfarbe { get => fellfarbe; set => fellfarbe = value; }

    // Eine abstrake Methode der Elternklasse muss zwingend in den ihr abgeleiteten
    // Klassen vorkommen und definiert werden.
    // Dies wird in folgendem Format gemacht:
    //
    // <Zugriffsmodifikator> override <Rückgabewert> <Methodenname>()
    // {
    //
    // }

    public override void Tierlaut()
    {
        Console.WriteLine("Der Hund macht \"WauWau\".");
    }
}
