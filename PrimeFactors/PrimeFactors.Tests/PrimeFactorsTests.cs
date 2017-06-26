using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace PrimeFactors.Tests
{
    [TestClass]
    public class PrimeFactorsTests
    {
        private PrimeFactorsFinder finder;

        [TestInitialize]
        public void SetUp()
        {
            finder = new PrimeFactorsFinder();
        }


        [TestMethod]
        public void FactorsOfOne_AreNone()
        {
            var factors = finder.Find(1);

            Assert.IsTrue(!factors.Any());
        }

        [TestMethod]
        public void FactorsOfTwo_AreTwo()
        {
            // Setup
            var expected = new List<int>() { 2 };

            // Act
            var factors = finder.Find(2);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }

        [TestMethod]
        public void FactorsOfThree_AreThree()
        {
            // Setup
            var expected = new List<int>() { 3 };

            // Act
            var factors = finder.Find(3);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }
    }
}
