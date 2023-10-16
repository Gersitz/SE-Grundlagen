using AbstrakteKlasse;

namespace AbstrakteKlassen;

internal class Program
{
    static void Main(string[] args)
    {
        // Wir gehen zur Tier.cs

        // Initialisierung eines Objekts der Klasse Hund und Methodenaufruf durch das Objekt.
        Hund hund = new Hund("MarleyKevin", 4, "Grau");

        hund.AlterAbfrage();
        hund.Tierlaut();
    }
}