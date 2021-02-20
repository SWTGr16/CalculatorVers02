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
            if (a != 0)
                return Accumulator /= a;
            
            {
                Console.WriteLine("Division of {0} by zero not possible.", Accumulator);
                throw new DivideByZeroException();
            }

            

        }

        public double Divide(double a, double b)
        {
            if (b != 0)
                return Accumulator = a / b;
            
            {
                Console.WriteLine("Division of {0} by zero not possible.", a);
                throw new DivideByZeroException();
            }

            

        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}

