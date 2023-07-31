using MethodsForTest;

namespace MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var price = 20;
            var foiz = 10;
            var result = 18;

            var method = new PriceCalculator();

            var natija = method.GetCorrectPrice(price, foiz);

            Assert.IsNotNull(method);
            Assert.IsNotNull(natija);
            Assert.AreEqual(result, natija);
        }
    }
}