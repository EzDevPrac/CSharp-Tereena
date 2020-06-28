using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbers
{
    class ComplexNumber
    {
        private double real, imaginary;
        public ComplexNumber()
        {

        }
        public ComplexNumber(double _real, double _imaginary)
        {
            real = _real;
            imaginary = _imaginary;
        }
        public double GetReal()
        {
            return real;
        }
        public void SetReal(double _real)
        {
            this.real = _real;
        }
        public double GetImaginary()
        {
            return imaginary;
        }
        public void SetImaginary(double _imaginary)
        {
            this.imaginary = _imaginary;
        }

        public override string ToString()
        {
            return "(" + real + "," + imaginary + ")";
        }
        public double GetMagnitude()
        {
            double mag = Math.Sqrt((real * real) + (imaginary * imaginary));
            return mag;
        }
        public void Add(ComplexNumber c)
        {
            real += c.GetReal();
            imaginary += c.GetImaginary();
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.real = c1.GetReal() + c2.GetReal();
            complex.imaginary = c1.GetImaginary() + c2.GetImaginary();
            return complex;
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.real = c1.GetReal() - c2.GetReal();
            complex.imaginary = c1.GetImaginary() - c2.GetImaginary();
            return complex;
        }
    }
}
