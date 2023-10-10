namespace Kapselung_Vererbung;

internal class Person 
{
    /* In C# (und anderen Sprachen) kann statt mit Get- und Set-Methoden auch mit Eigenschaften gearbeitet
     * werden. Dies erleichtert Verwendung und Zugriff.
     * 
     * Um die Eigenschaften zu erstellen, markiert man die Member-Variablen, führt einen Rechtsklick aus,
     * und wählt dann "Schnellaktion und Refactorings" aus.
     * Dann "Felder kapseln (und Eigenschaften verwenden)" auswählen.
     */

    string name; // Member-Variable
    string vorname; // Member-Variable
    string geburtstag; // Member-Variable
    string anschrift; // Member-Variable
    string plz; // Member-Variable
    string ort; // Member-Variable

    public Person()
    {

    }

    public Person(string name, string vorname, string geburtstag, string anschrift, string plz, string ort) // Konstruktor
    {
        Name = name;
        Vorname = vorname;
        Geburtstag = geburtstag;
        Anschrift = anschrift;
        Plz = plz;
        Ort = ort;
    }

    // Aus den Eigenschaften lässt sich auch der Konstruktor erzeugen.
    // Hierfür markiert man wieder alle Eigenschaften, führt einen Rechtsklick aus und wählt wieder
    // "Schnellaktionen und Refactorings" aus.
    // Mit "Konstruktor generieren" wird dann mit den Eigenschaften, die wir ausgewählt haben, ein
    // Konstruktor erstellt.

    public string Name { get => name; set => name = value; } // Eigenschaften
    public string Vorname { get => vorname; set => vorname = value; } // Eigenschaften
    public string Geburtstag { get => geburtstag; set => geburtstag = value; } // Eigenschaften
    public string Anschrift { get => anschrift; set => anschrift = value; } // Eigenschaften
    public string Plz { get => plz; set => plz = value; } // Eigenschaften
    public string Ort { get => ort; set => ort = value; } // Eigenschaften
}