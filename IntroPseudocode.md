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

- `query` nicht in `cards` => Gesuchte Karte ist nicht in der Liste
- Wenn `query` mehrmals in `cards` vorkommt, dann geben wir die Position des ersten Ergebnisses zurück