using System;

namespace OOP04
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            int realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            int imaginaryPart = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new Complex(realPart, imaginaryPart);
        }

        public static Complex operator +(Complex c)
        {
            return new Complex(+c.Real, +c.Imaginary);
        }

        public static Complex operator -(Complex c)
        {
            return new Complex(-c.Real, -c.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}