using Algorithms;
namespace TestAlgorithms
{
    public class UnitTest1
    {
        [Fact]
        public void TestLocateCard_DefaultCase()
        {
            int[] cards = { 1, 2, 3, 4, 5 };
            int query = 3;

            Assert.Equal(2, CardAlgorithms.FindCardLocation(cards, query));
        }

        [Fact]
        public void TestLocateCard_QueryNotInCards()
        {
            int[] cards = { -1, 1 };
            int query = 0;

            Assert.Equal(-1, CardAlgorithms.FindCardLocation(cards, query));
        }

        [Fact]
        public void TestLocateCard_DuplicateQueryInCards()
        {
            int[] cards = { 0, 1, 2, 3, 21, 21, 42, 69, 420 };
            int query = 21;

            Assert.Equal(4, CardAlgorithms.FindCardLocation(cards, query));
        }

        [Fact]
        public void TestLocateCard_CardsIsEmpty()
        {
            int[] cards = { };
            int query = 69;

            Assert.Equal(-1, CardAlgorithms.FindCardLocation(cards, query));
        }

        [Fact]
        public void TestLocateCard_BigArray()
        {
            Random rand = new Random();
            int[] cards = new int[10_000_000];

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = rand.Next();
            }

            cards[1336] = 420;
            Array.Sort(cards);

            int query = 420;

            var expectedPosition = cards.ToList().FindIndex(x => x == query);

            Assert.Equal(expectedPosition, CardAlgorithms.FindCardLocation(cards, query));
        }

        [Fact]
        public void TestLocateCard_BigArrayBinarySearch()
        {
            Random rand = new Random();
            int[] cards = new int[10_000_000];

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = rand.Next();
            }

            cards[1336] = 420;
            Array.Sort(cards);

            int query = 420;

            var expectedPosition = cards.ToList().FindIndex(x => x == query);

            Assert.Equal(expectedPosition, CardAlgorithms.BinaryFindCardLocation(cards, query));
        }
    }
}