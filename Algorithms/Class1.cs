namespace Algorithms
{
    public static class CardAlgorithms
    {
        public static int FindCardLocation(int[] cards, int query)
        {
            if (query > cards.Length/2)
            {
                cards.
            }
            int index = 0;
            while (index < cards.Length)
            {
                if (cards[index] == query)
                {
                    return index;
                }
                index++;
            }
            return -1;
            
           // initialisiere Variable index mit Wert 0
           // Schleife bis index gleich Länge der cards Liste
           //     Wenn Zahl von Cards an index gleich query:
           //         Wahr: Gebe index zurück
           //     Inkrement index um 1
        }
    }
}

// initialisiere Variable index mit Wert 0
// initialisiere Variable current mit Wert 0
// Schleife bis index gleich Länge der cards Liste
//    Wenn Zahl von index kleiner als Hälfte der cards Liste
//        Wahr: Entferne erste Hälfte von cards
//        Falsch: Entferne zweite Hälfte von cards