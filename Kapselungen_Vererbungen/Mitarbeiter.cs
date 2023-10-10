using Kapselung_Vererbung;

namespace Kapselungen_Vererbungen;

// Um eine Klasse von einer Basi- oder auch Elternklasse erben zu lassen, wird folgende
// Syntax verwendet:
//
// <Zugriffsmodifikator> class <Kindklassenname> : <Elternklassenname>
internal class Mitarbeiter : Person
{
    // Alle Member der Elternklasse, mit Ausnahme des Konstruktors, sind in der Kindklasse verfügbar.
    // Weitere Member können hinzugfügt werden.

    public int mitarbeiterNr;

    // Der Konstruktor der Kindklasse wird erstellt.
    // Die folgende Art ihn zu schreiben ist nur möglich, weil in der Elternklasse ein
    // leerer Konstruktor vorhanden ist.

    // Aufpassen, dass die Eigenschaften der Elternklasse hier auch großgeschrieben werden.

    public Mitarbeiter (string _name, string _vorname, string _geburtstag, string _anschrift, string _plz, string _ort, int _mitarbeiterNr)
    {
        Name = _name;
        Vorname = _vorname;
        Geburtstag = _geburtstag;
        Anschrift = _anschrift;
        Plz = _plz;
        Ort = _ort;
        mitarbeiterNr = _mitarbeiterNr;
    }

    // Wäre kein Default-Konstruktor vorhanden, müsste der Konstruktor der Kindklasse
    // folgendermaßen aussehen:

    // public Mitarbeiter (string _name, string _vorname, string _geburtstag, string _anschrift, string _plz, string _ort, int _mitarbeiterNr) : base(_name, _vorname, _geburtstag, _anschrift, _plz, _ort)
    // {
    //    mitarbeiterNr = _mitarbeiterNr;
    // }

}
