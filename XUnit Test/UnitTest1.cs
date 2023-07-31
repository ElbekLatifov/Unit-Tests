using MethodsForTest;

namespace XUnit_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var price = 20;
            var foiz = 10;
            var result = 18;

            var method = new PriceCalculator();

            var natija = method.GetCorrectPrice(price, foiz);

            Assert.True(result == natija);
        }
    }
}