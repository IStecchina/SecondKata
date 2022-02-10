using KataFizzBuzz;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace TestProjectFizzBuzz
{
    public class Tests
    {

        IFizzBuzzCounter _sut;


        [SetUp]
        public void Setup()
        {
            _sut = new FizzBuzzCounter();
        }

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(17, ExpectedResult = "17")]
        [TestCase(30, ExpectedResult = "FizzBuzz")]
        public string TestFizzBuzz(int input) => _sut.Translate(input);

        [Test]
        public void TestFizzBuzzCounter()
        {
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz" };
            var actual = _sut.Counter(6);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFizzBuzzCounter2()
        {
            var actual = _sut.Counter(300);
            Assert.IsTrue(actual.FindAll(s =>s.Contains("Fizz")).Count == 100);
            Assert.IsTrue(actual.FindAll(s => s.Contains("Buzz")).Count == 60);
            Assert.IsTrue(actual.FindAll(s => s.Equals("FizzBuzz")).Count == 20);
        }


    }
}
