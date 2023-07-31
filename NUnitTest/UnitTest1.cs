using MethodsForTest;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var price = 20;
            var foiz = 10;
            var result = 18;

            var method = new PriceCalculator();

            var natija = method.GetCorrectPrice(price, foiz);

            Assert.IsNotNull(method);
            Assert.IsNotNull(natija);
            Assert.That(natija, Is.EqualTo(result));
        }
    }
}