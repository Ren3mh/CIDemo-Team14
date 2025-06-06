﻿using Lommeregner;

namespace Lommeregner
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Denominator cannot be zero.");
            return (double)a / b;
        }

        public double Power(double a, double b) => Math.Pow(a, b);

        public double SquareRoot(double a)
        {
            if (a < 0)
                throw new ArgumentException("Ikke med minus du");
                        
            return Math.Sqrt(a);
        } 



    }

}
