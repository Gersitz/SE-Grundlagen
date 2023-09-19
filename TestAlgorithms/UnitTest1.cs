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
    }
}