using System;
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
        [TestCase(5, 1, 5)]
        [TestCase(9, 3, 3)]
        public void Dividea_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(c));
        }

        [TestCase(4,0)]
        [TestCase(5, 0)]
        [TestCase(10, 0)]
        public void TestThatThrowsException3(double a, double b)
        {
            Assert.That(() => uut.Divide(a,b), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(0)] // Tilføjet test af Exception med én parameter 
        public void TestThatThrowsExceptionOneParameter(double a)
        {
            Assert.That(() => uut.Divide(a), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(4, 2, 16)]
        [TestCase(5, 3, 125)]
        [TestCase(6, 4, 1296)]
        public void Powera_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(c));
        }


        [Test]
        public void TestThatAccumulatorEqualsZero()
        {
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        


        [TestCase(5, 2, 7)]
        [TestCase(4,5,9)]
        [TestCase(1, 7, 8)]
        public void AccumulatorAdd_OneParameter_SetToValue_b(int acc, int a, int b)
        {
            uut.Accumulator = acc;
            uut.Add(a);
            Assert.That(uut.Accumulator, Is.EqualTo(b));
        }

        [TestCase(5, 2, 3)]
        [TestCase(9, 5, 4)]
        [TestCase(8, 7, 1)]
        public void AccumulatorSubstract_OneParameter_SetToValue_b(int acc, int a, int b)
        {
            uut.Accumulator = acc;
            uut.Subtract(a);
            Assert.That(uut.Accumulator, Is.EqualTo(b));
        }

        [TestCase(5, 5, 1)]
        [TestCase(10, 2, 5)]
        [TestCase(40, 10, 4)]
        public void AccumulatorDivide_OneParameter_SetToValue_b(int acc, int a, int b)
        {
            uut.Accumulator = acc;
            uut.Divide(a);
            Assert.That(uut.Accumulator, Is.EqualTo(b));
        }

        [TestCase(5, 2, 10)]
        [TestCase(4, 5, 20)]
        [TestCase(3, 9, 27)]
        public void AccumulatorMultiply_OneParameter_SetToValue_b(int acc, int a, int b)
        {
            uut.Accumulator = acc;
            uut.Multiply(a);
            Assert.That(uut.Accumulator, Is.EqualTo(b));
        }

        [TestCase(5, 2, 25)]
        [TestCase(4, 2, 16)]
        [TestCase(3, 2, 9)]
        public void AccumulatorPow_OneParameter_SetToValue_c(int acc, int a, int b)
        {
            uut.Accumulator = acc;
            uut.Power(a);
            Assert.That(uut.Accumulator, Is.EqualTo(b));
        }


        [TestCase(5, 2, 7)]
        [TestCase(4, 5, 9)]
        [TestCase(4, 5, 9)]
        public void AccumulatorAdd_TwoParameters_SetToValue_c(int a, int b, int c)
        {
            uut.Add(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }

       

        [TestCase(7, 2, 5)]
        [TestCase(9, 5, 4)]
        [TestCase(8, 7, 1)]
        public void AccumulatorSubstract_TwoParameters_SetToValue_c(int a, int b, int c)
        {
            uut.Subtract(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }

        [TestCase(5, 5, 1)]
        [TestCase(10, 2, 5)]
        [TestCase(40, 10, 4)]
        public void AccumulatorDivide_TwoParameters_SetToValue_c(int a, int b, int c)
        {
            uut.Divide(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }

        [TestCase(5, 2, 10)]
        [TestCase(4, 5, 20)]
        [TestCase(3, 9, 27)]
        public void AccumulatorMultiply_TwoParameters_SetToValue_c(int a, int b, int c)
        {
            uut.Multiply(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }

        [TestCase(5, 2, 25)]
        [TestCase(4, 2, 16)]
        [TestCase(3, 2, 9)]
        public void AccumulatorPow_TwoParameters_SetToValue_c(int a, int b, int c)
        {
            uut.Power(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }

        [TestCase(5,4,9)]
        [TestCase(5, 5, 10)]
        [TestCase(3, 9, 12)]
        public void AccumulateAddMethod_accumulutor_plus_a_equals_b(double acc,double a, double b)
        {
            uut.Accumulator = acc;
            Assert.That(uut.Add(a),Is.EqualTo(b));
        }

        [TestCase(9, 4, 5)]
        [TestCase(5, 5, 0)]
        [TestCase(13, 9, 4)]
        public void AccumulateSubtractMethod_accumulutor_minus_a_equals_b(double acc, double a, double b)
        {
            uut.Accumulator = acc;
            Assert.That(uut.Subtract(a), Is.EqualTo(b));
        }

        [TestCase(5, 5, 1)]
        [TestCase(20, 5, 4)]
        [TestCase(27, 3, 9)]
        public void AccumulateDivideMethod_accumulutor_divide_a_equals_b(double acc, double a, double b)
        {
            uut.Accumulator = acc;
            Assert.That(uut.Divide(a), Is.EqualTo(b));
        }

        [TestCase(5, 4, 20)]
        [TestCase(10, 5, 50)]
        [TestCase(3, 9, 27)]
        public void AccumulateMultiplyMethod_accumulutor_multiply_a_equals_b(double acc, double a, double b)
        {
            uut.Accumulator = acc;
            Assert.That(uut.Multiply(a), Is.EqualTo(b));
        }

        [TestCase(5, 2, 25)]
        [TestCase(4, 2, 16)]
        [TestCase(3, 3, 27)]
        public void AccumulateAddMethod_accumulutor_power_a_equals_b(double acc, double a, double b)
        {
            uut.Accumulator = acc;
            Assert.That(uut.Power(a), Is.EqualTo(b));
        }
    }
}