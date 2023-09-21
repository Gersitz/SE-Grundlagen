## Alice und Bob spielen Karten

**Aufgabenstellung**

Alice hat einige Karten mit Zahlen darauf. Sie sortiert die Karten in aufsteigender Reihenfolge und legt sie mit der Schrift nach unten in einer Reihe auf den Tisch. Nun soll Bob die Karte mit einer von Alice vorgegebenen Zahl finden und dabei so wenig falsche Karten wie möglich aufdecken. Schreibe eine Helfer-Funktion für den armen Bob.

## Methodik

1. Definiere das Problem
2. Beispielinputs/-outputs ausdenken
3. Pseudo-Code Lösung konzeptionieren
4. Implementierung der konzeptionierten Lösung in den Code
5. Optimiere und iteriere den Algorithmus

## Problem definieren

Karten = 1,2,3,4,5
Gesuchte Karte = 3

Position = ?

```csharp
int[] cards = { 1, 2, 3, 4, 5 };
int query = 3;

var position = FindCardLocation(cards, query); // sollte 2 zurück geben
```

```csharp
int FindCardLocation(int[] cards, int query)
{

}
```

## 2. Beispiel Input/Output

**TestCases:**

- Wenn `query` mehrmals in `cards` vorkommt, dann geben wir die Position des ersten Ergebnisses zurück
- Wenn `cards` leer, dann geben wir `-1` zurück
- Wenn `query` nicht in `cards` vorhanden, dann geben wir `-1` zurück


## 3. Pseudocode-Implementierung

### Was ist Pseudocode?

```text
Schleife (solange x kleiner als 0):
    mache x
    mache y
Schleife Ende
```

```text
Wenn x gleich y:
    Wahr: Setze den Wert von z auf den Wert von x
    Falsch: Weise z den Wert von y zu
mache x
```

```text
Initialisiere Variable num mit dem Wert 0
Initialisiere Variable checkNumber mit dem Wert false

Solange checkNumber gleich false, wiederhole:
    Frage Nutzer nach einer Zahl und speichere diese in Variable Input
    Wandle Input in eine Zahl um
    Wenn Input nicht in Zahl umgewandelt werden kann:
        Wahr: Gebe Fehlermeldung aus
Wiederhole Ende
```

### Unsere Pseudocode-Implementierung

```csharp
int FindCardLocation(int[] cards, int query)
{

}
```

```text
Parameter: Zahlenliste cards
Parameter: Zahl query

Initialisiere Variable index mit Wert 0
Schleife bis index gleich Länge der cards Liste:
    Wenn Zahl von cards an index gleich query:
        Wahr: gebe index zurück
    Inkrementiere index um 1

```