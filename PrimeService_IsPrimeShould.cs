// https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit?source=recommendations

// using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService = new PrimeService();

        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void IsPrime_InputIsNotPrime_ReturnFalse()
        {
            var resultNeg10 = _primeService.IsPrime(-10);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(resultNeg10, "-10 should not be prime");
        
            var result1 = _primeService.IsPrime(1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result1, "1 should not be prime");

            var result9 = _primeService.IsPrime(9);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result9, "9 is NOT a prime number");
        
            var result21 = _primeService.IsPrime(21);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result21, "21 is NOT a prime number div by 2");

            var result561 = _primeService.IsPrime(561);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result561, "561 is NOT a prime number");

            var result41041 = _primeService.IsPrime(41041);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result41041, "41041 is NOT a prime number");        
        } 

        [TestMethod]
        public void IsPrime_InputIsPrime_ReturnTrue()
        {
            var result2 = _primeService.IsPrime(2);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result2, "2 is a prime number div by 2");

            var result23 = _primeService.IsPrime(23);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result23, "23 is a prime number");

            var result31 = _primeService.IsPrime(31);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result31, "31 is a prime number");

            var result569 = _primeService.IsPrime(569);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result569, "569 is a prime number");
        
            var result23209 = _primeService.IsPrime(23209);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result23209, "23209 is a prime number");
        }

        [TestMethod]
        public void PrimeStatement_InputIsNotPrime_ReturnNegationString()
        {
            int number1 = 1;
            string result1 = _primeService.PrimeStatement(number1);
            Assert.AreEqual($"{number1} is not a prime number.", result1);

            int number21 = 21;
            string resultPS21 = _primeService.PrimeStatement(number21);
            Assert.AreEqual($"{number21} is not a prime number.", resultPS21);
            
            int number561 = 561;
            string result561 = _primeService.PrimeStatement(number561);
            Assert.AreNotEqual($"{number561} is, in fact, a prime number.", result561);
        }

        [TestMethod]
        public void PrimeStatement_InputIsPrime_ReturnAffirmativeString()
        {
            int number23 = 23;
            string result23 = _primeService.PrimeStatement(number23);
            Assert.AreNotEqual($"{number23} is not a prime number.", result23);

            int number811 = 811;
            string resultPS811 = _primeService.PrimeStatement(number811);
            Assert.AreEqual($"{number811} is, in fact, a prime number.", resultPS811);
            
            int number224737 = 224737;
            string result224737 = _primeService.PrimeStatement(number224737);
            Assert.AreEqual($"{number224737} is, in fact, a prime number.", result224737);
        }
    }
}