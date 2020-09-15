using NUnit.Framework;
using PrimeNumberApp.BLL.Managers;

namespace PrimeNumberApp.Tests.BLL.Managers
{
    public class PrimeNumberManagerTests
    {
        private PrimeNumberManager primeNumberManager;

        [OneTimeSetUp]
        public void Setup()
        {
            primeNumberManager = new PrimeNumberManager();
        }

        /// <summary>
        /// Test IsPrime(int value) when value is not prime and greater than 2
        /// </summary>
        [TestCase(4)]
        [TestCase(21)]
        [TestCase(100)]
        [TestCase(2152)]
        public void IsPrime_ValueGreaterThan2AndNotPrime_ReturnsFalse(int value)
        {
            var result = primeNumberManager.IsPrime(value);
            Assert.IsFalse(result,$"{value} should not be prime.");
        }

        /// <summary>
        /// Test IsPrime(int value) when value is not prime and less than 2
        /// </summary>
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-100)]
        public void IsPrime_ValueLessThan2_ReturnsFalse(int value)
        {
            var result = primeNumberManager.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime.");
        }

        /// <summary>
        /// Test IsPrime(int value) when value is prime and greater or equal than 2
        /// </summary>
        [TestCase(2)]
        [TestCase(113)]
        [TestCase(997)]
        public void IsPrime_ValueGreaterOrEqualThan2AndPrime_ReturnsTrue(int value)
        {
            var result = primeNumberManager.IsPrime(value);
            Assert.IsTrue(result, $"{value} should be prime.");
        }

        /// <summary>
        /// Test NextPrime(int value) when value is less than 2
        /// </summary>
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-100)]
        public void NextPrime_ValueLessThan2_Expect_Returns2(int value)
        {
            var result = primeNumberManager.NextPrimeAfterGivenNumber(value);
            Assert.AreEqual(2, result, $"For {value} the next prime should be 2.");
        }

        /// <summary>
        /// Test NextPrime(int value) when value is 4 and we expect 5.
        /// </summary>
        [TestCase(4)]
        public void NextPrime_ValueIs4_Expect_Returns5(int value)
        {
            var result = primeNumberManager.NextPrimeAfterGivenNumber(value);
            Assert.AreEqual(5, result, $"For {value} the next prime should be 5.");
        }
    }
}