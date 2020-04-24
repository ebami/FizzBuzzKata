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
        [TestCase(90)]
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
    }
}