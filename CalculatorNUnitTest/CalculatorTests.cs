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

        [TestCase(5, 10, 15)]
        [TestCase(22, 25, 47)]
        [TestCase(100, 11, 111)]
        public void Adda_tob_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(c));
        }

        [TestCase(5, 1, 4)]
        [TestCase(22, 20, 2)]
        [TestCase(100, 10, 90)]
        public void Subtracta_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(1, 1, 1)]
        [TestCase(2, 20, 40)]
        [TestCase(10, 10, 100)]
        public void Multiplya_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(4, 4, 1)]
        [TestCase(5, 0, 0)]
        [TestCase(9, 3, 3)]
        public void Dividea_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(c));
        }

        [TestCase(4, 2, 16)]
        [TestCase(5, 3, 125)]
        [TestCase(6, 4, 1296)]
        public void Powera_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(c));
        }

    }
}