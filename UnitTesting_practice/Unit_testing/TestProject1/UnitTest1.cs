using NUnit.Framework;
using CalculatorApp;
using System;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalled_ReturnsCorrectSum()
        {
            int result = calculator.Add(10, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsCorrectResult()
        {
            int result = calculator.Subtract(10, 3);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsCorrectResult()
        {
            int result = calculator.Multiply(4, 5);
            Assert.AreEqual(20, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}