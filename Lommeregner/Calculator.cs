﻿using Lommeregner;

namespace Lommeregner
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Denominator cannot be zero.");
            return (double)a / b;
        }
    }

}
