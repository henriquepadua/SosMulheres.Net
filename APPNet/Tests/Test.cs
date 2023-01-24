using Stripe;

namespace Tests
{
    [TestClass]
    public class BankAccount
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            // Create an instance to test:
            // Define a test input and output value:
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            // Run the method under test:
            // Verify the result:
            Assert.AreEqual(expectedResult, input, delta: expectedResult / 100);
        }
    }
}