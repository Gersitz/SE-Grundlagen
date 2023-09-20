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
                index++;
            }
            return -1;
            
           // initialisiere Variable index mit Wert 0
           // Schleife bis index gleich Länge der cards Liste
           //     Wenn Zahl von Cards an index gleich query:
           //         Wahr: Gebe index zurück
           //     Inkrement index um 1
        }
        public static int BinaryFindCardLocation(int[] cards, int query)
        {
            int left = 0;
            int right = cards.Length - 1;
            
            if (cards.Length == 0)
            {
                return -1;
            }

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (cards[middle] == query)
                {
                    return middle;
                }
                else if (query < cards[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
            // Setze Variable left auf Wert 0
            // Setze Variable right auf Wert Länge von cards minus 1

            // Wenn Länge von cards gleich 0
            //    Wahr: Gebe -1 zurück

            // Schleife solange left kleiner gleich right:
            //    Setze Variable middle auf den Wert (left + right) / 2
            //    Wenn middle gleich query:
            //        Wahr: Gebe middle zurück
            //    Wenn query kleiner als cards an middle
            //        Wahr: Setze right auf den Wert von middle - 1
            //        Falsch: Setze left auf den Wert von middle + 1
        }
    }
}