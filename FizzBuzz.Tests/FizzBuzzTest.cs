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

        [Test]
        public void GivenNumber5_ThenShouldOutputBuzz()
        {
            Assert.That(_sut.Fizz(5), Is.EqualTo("Buzz"));
        }

        [TestCase(10)]
        [TestCase(25)]
        [TestCase(35)]
        [TestCase(75)]
        public void GivenMultipleOf5_ThenShouldOutputFIzz(int number)
        {
            Assert.That(_sut.Fizz(number), Is.EqualTo("Buzz"));
        }
    }
}