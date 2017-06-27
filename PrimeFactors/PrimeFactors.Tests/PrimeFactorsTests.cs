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

        [TestMethod]
        public void FactorsOfFour_AreTwoAndTwo()
        {
            // Setup
            var expected = new List<int>() { 2, 2 };

            // Act
            var factors = finder.Find(4);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }

        [TestMethod]
        public void FactorsOfFive_AreFive()
        {
            // Setup
            var expected = new List<int>() { 5 };

            // Act
            var factors = finder.Find(5);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }

        [TestMethod]
        public void FactorsOfSix_AreThreeAndTwo()
        {
            // Setup
            var expected = new List<int>() { 2, 3 };

            // Act
            var factors = finder.Find(6);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }

        [TestMethod]
        public void FactorsOfSeven_AreSeven()
        {
            // Setup
            var expected = new List<int>() { 7 };

            // Act
            var factors = finder.Find(7);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }

        [TestMethod]
        public void FactorsOfEight_AreTwoAndTwoAndTwo()
        {
            // Setup
            var expected = new List<int>() { 2, 2, 2 };

            // Act
            var factors = finder.Find(8);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }

        [TestMethod]
        public void FactorsOfNine_AreThreeAndThree()
        {
            // Setup
            var expected = new List<int>() { 3, 3 };

            // Act
            var factors = finder.Find(9);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }

        [TestMethod]
        public void FactorsOf360_Are2n2n2n3n3n5()
        {
            // Setup
            var expected = new List<int>() { 2, 2, 2, 3, 3, 5 };

            // Act
            var factors = finder.Find(360);

            // Assert
            CollectionAssert.AreEqual(expected, factors);
        }
    }
}
