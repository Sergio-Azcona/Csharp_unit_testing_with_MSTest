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
        public void IsPrime_InputIsneg1_ReturnFalse()
        {
            var result = _primeService.IsPrime(-1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result, "1 should not be prime");
        } 

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result, "1 should not be prime");
        } 

        [TestMethod]
        public void IsPrime_InputIs2_Returntrue()
        {
            var result = _primeService.IsPrime(2);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result, "2 is a prime number div by 2");
        }

        [TestMethod]
        public void IsPrime_InputIs9_Returntrue()
        {
            var result = _primeService.IsPrime(9);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result, "9 is NOT a prime number");
        }

        [TestMethod]
        public void IsPrime_InputIs21_Returntrue()
        {
            var result = _primeService.IsPrime(21);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result, "21 is NOT a prime number div by 2");
        }

        [TestMethod]
        public void IsPrime_InputIs23_Returntrue()
        {
            var result = _primeService.IsPrime(23);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result, "23 is a prime number");
        }

        [TestMethod]
        public void IsPrime_InputIs31_Returntrue()
        {
            var result = _primeService.IsPrime(31);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result, "31 is a prime number");
        }

        [TestMethod]
        public void IsPrime_InputIs561_Returntrue()
        {
            var result = _primeService.IsPrime(561);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result, "561 is NOT a prime number");
        }

        [TestMethod]
        public void IsPrime_InputIs41041_Returntrue()
        {
            var result = _primeService.IsPrime(41041);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(result, "41041 is NOT a prime number");
        }
        
        [TestMethod]
        public void IsPrime_InputIs23209_Returntrue()
        {
            var result = _primeService.IsPrime(23209);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(result, "23209 is a prime number");
        }
    }
}