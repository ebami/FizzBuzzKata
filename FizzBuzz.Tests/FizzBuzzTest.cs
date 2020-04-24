using System;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        private FizzBuzz _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new FizzBuzz();
        }

        [TestCase(3)]
        [TestCase(21)]
        [TestCase(63)]
        [TestCase(87)]
        public void GivenMultipleOf3_ThenShouldOutputFIzz(int number)
        {
            Assert.That(_sut.Fizz(number), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        [TestCase(35)]
        [TestCase(70)]
        public void GivenMultipleOf5_ThenShouldOutputFIzz(int number)
        {
            Assert.That(_sut.Fizz(number), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(90)]
        [TestCase(75)]
        public void GivenMultipleOf3And5_ThenShouldOutputFIzz(int number)
        {
            Assert.That(_sut.Fizz(number), Is.EqualTo("FizzBuzz"));
        }

        [TestCase(-29)]
        [TestCase(101)]
        [TestCase(550)]
        [TestCase(-200)]
        public void GivenNumberOutsideRange_ThenShouldThrowException(int number)
        {
            Assert.That(_sut.Fizz(number), Is.EqualTo(new ArgumentException().ToString()));
        }

        [TestCase(13)]
        [TestCase(23)]
        [TestCase(33)]
        [TestCase(53)]
        [TestCase(73)]
        public void GivenRangeofNumbersWith3_ThenShouldOutputFizz(int number)
        {
            Assert.That(_sut.Fizz(number), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GivenNumberWith5_ThenShouldOutputBuzz()
        {
            Assert.That(_sut.Fizz(52), Is.EqualTo("Buzz"));
        }
    }
}