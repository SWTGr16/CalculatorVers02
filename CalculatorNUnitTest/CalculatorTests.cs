using NUnit.Framework;
using CalculatorVers02;

namespace CalculatorNUnitTest
{
    public class CalculatorTests
    {
        public Calc uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calc();
        }

        [Test]
        public void Add2and4Returns6()
        {
            Assert.That(uut.Add(2, 4), Is.EqualTo(6));
        }

        [Test]
        public void Subtract4and2Returns2()
        {
            Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));
        }

        [Test]
        public void Multiply2and3Returns6()
        {
            Assert.That(uut.Multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void Power4and2Returns16()
        {
            Assert.That(uut.Power(4, 2), Is.EqualTo(16));
        }

        
    }
}