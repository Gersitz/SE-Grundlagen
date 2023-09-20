namespace Algorithms
{
    public static class CardAlgorithms
    {
        public static int FindCardLocation(int[] cards, int query)
        {
            int index = 0;
            while (index < cards.Length)
            {
                if (cards[index] == query)
                {
                    return index;
                }
                else if (query == 0)
                { 
                    break;
                }
                index++;
            }
            return index -1;
           // initialisiere Variable index mit Wert 0
           // Schleife bis index gleich Länge der cards Liste
           //     Wenn Zahl von Cards an index gleich query:
           //         Wahr: Gebe index zurück
           //     Inkrement index um 1
        }
    }
}