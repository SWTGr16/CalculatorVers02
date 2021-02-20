using System;

namespace CalculatorVers02
{
    public class Calc
    {
        public double Accumulator { get; private set; }

        public double Add(double a)
        {
            return Accumulator += a;
            // Property Accumulator tillægges værdien fra parameter a. 
        }

        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Subtract(double a)
        {
            return Accumulator -= a;
            
        }

        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Multiply(double a)
        {
            return Accumulator *= a;
            
        }
        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Power(double a)
        {
            return Math.Pow(Accumulator ,a);
             
        }
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double a)
        {
            try
            {
                Accumulator /= a;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero not possible.", Accumulator);
            }

            return Accumulator;

        }

        public double Divide(double a, double b)
        {
            try
            {
                Accumulator = a/b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero not possible.", a);
            }

            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
