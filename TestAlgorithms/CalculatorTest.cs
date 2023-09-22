using KlasseTaschenrechner;

namespace TestAlgorithms
{
    public class CalculatorTest
    {
        [Fact]
        public void TestCheckNumberIsPrime()
        {
            var number1 = 5;
            Assert.Equal(true, Calculator.CheckNumberIsPrime(number1));
        }
        [Fact]
        public void TestCheckNumberIsNotPrime()
        {
            var number1 = 6;
            Assert.Equal(true, Calculator.CheckNumberIsPrime(number1));
        }
    }
}
