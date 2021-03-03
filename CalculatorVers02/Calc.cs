using System;

namespace CalculatorVers02
{
    public class Calc
    {
        public double Accumulator { get; set; }

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
            return Accumulator=Math.Pow(Accumulator ,a);
             
        }
        public double Power(double x, double exp)
        {
            return Accumulator =Math.Pow(x, exp);
        }

        public double Divide(double a)
        {
            if (a != 0)
            {
                Accumulator = Accumulator / a;
                return Accumulator;
            }
                //return Accumulator /= a;
            
            {
                throw new DivideByZeroException("Division by zero not possible.");
            } 
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
                return Accumulator = a / b;
            {
                throw new DivideByZeroException("Division by zero not possible.");
            }            
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}

