using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSiftingTests.Models
{
    [TestClass]
    public class PrimeSiftingTests
    {
        // Test 1: Test for constructor
        [TestMethod]
        public void PrimeDeterminerConstructor_ReturnsInstanceOfPrimeDeterminerClass_PrimeDeterminer()
        {
            // Arrange
            PrimeDeterminer newDeterminer = new PrimeDeterminer(5);

            // Assert
            Assert.AreEqual(typeof(PrimeDeterminer), newDeterminer.GetType());
        }

        
        // Test 2: Test to get the Number property of the class(PrimeDeterminer)
        [TestMethod]
        public void GetNumber_ReturnsNumberWewantToDetermineItsPrimeNumbers_Double()
        {
            // Arrange
            PrimeDeterminer newDeterminer = new PrimeDeterminer(25);
            double expectedNumber = 25;
            // Act

            double actualNumber = newDeterminer.Number;

            // Assert
            Assert.AreEqual(expectedNumber, actualNumber);

        }

        // Test 3: Test to set the Number property of the class(PrimeDeterminer)
        [TestMethod]
        public void SetNumber_SetsValueForNumberProperty_Void()
        {
            // Arrange
            PrimeDeterminer newDeterminer = new PrimeDeterminer(70);
            double setNumber = 2;

            // Act
            newDeterminer.Number = 2;

            // Assert
            Assert.AreEqual(setNumber, newDeterminer.Number);
        }

        // Test 3: Test on PrimeNumberDeterminer() method
        // Breaking the Test into chunks
        public void PrimeNumberDeterminerMethod_AListOfNumbersBelowNumber_List()
        {
            // Arrange
            PrimeDeterminer newDeterminer = new PrimeDeterminer(5);
            List<double> expectedListOfNumbers = new List<double>(){1, 2, 3, 4, 5};

            // Act
            List<double> actualListOfNumbers = newDeterminer.PrimeNumbersDeterminerMethod(5);

            // Assert
            CollectionAssert.AreEqual(expectedListOfNumbers, actualListOfNumbers);
        }
        // THe smallest solution I could think of has been implemented, moving on to actually determine the prime numbers

        // Test 4: Test on PrimeNumberDeterminer() method
        // Next, adding a condition for prime numbers
        [TestMethod]
        public void PrimeNumberDeterminerMethod_AListOfPrimeNumbersBelowNumber_List()
        {
            // Arrange
            PrimeDeterminer newDeterminer = new PrimeDeterminer(10);
            // Method returns a list of all prime numbers that can be found from 1-enterred num(e.g, the list of prime numbers that exist between 1 - 10 are 3, 5, 7)
            List<double> expectedListOfPrimeNums = new List<double>(){2, 3, 5, 7};

            // Act
            List<double> actualListOfPrimeNumbers = newDeterminer.PrimeNumbersDeterminerMethod(10);

            // Assert
            CollectionAssert.AreEqual(expectedListOfPrimeNums, actualListOfPrimeNumbers);
        }
    }    
}