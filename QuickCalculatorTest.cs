// https://learn.microsoft.com/en-us/training/modules/visual-studio-test-tools/2-create-test
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit_testing_using_mstest;

namespace PrimeService.Tests
{
    public class QuickCalculatorTest
    {

        public void SetCalcualtor()
        {
            QuickCalculator calculator = new QuickCalculator();
        }

        [TestMethod]

        public void QuickAdd_SimpleTest() 
        {
            // to add tests for methods
        }
    }
}
