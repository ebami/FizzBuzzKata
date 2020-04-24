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

        [Test]
        public void GivenNumber3_ThenItshoudOutputFizz()
        {
            Assert.That(_sut.Fizz(3), Is.EqualTo("Fizz"));
        }

    }
}