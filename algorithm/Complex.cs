using System;

namespace algorithm
{
    internal class Complex
    {
        public double real;
        public double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public Complex(int degree)
        {
            double radian = degree * Math.PI / 180;
            real = Math.Round(Math.Cos(radian), 2);
            imaginary = Math.Round(Math.Sin(radian), 2);
        }

        public static Complex operator +(Complex a, Complex b) => new Complex(a.real + b.real, a.imaginary + b.imaginary);

        public static Complex operator -(Complex a, Complex b) => new Complex(a.real - b.real, a.imaginary - b.imaginary);

        public static Complex operator *(Complex a, Complex b) => new Complex(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + a.imaginary * b.real);

        public override string ToString()
        {
            return $"{real} {(imaginary < 0 ? "-" : "+")} {Math.Abs(imaginary)}j";
        }
    }
}
