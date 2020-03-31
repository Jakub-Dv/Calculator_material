///

using System;

namespace Calculator___material.Math
{
    class Math
    {
        public double Sum(double number1, double number2)
        {
            return (number1 + number2);
        }

        public double Sub(double minuend, double subtrahend)
        {
            return (minuend - subtrahend);
        }

        public double Mul(double multiplicant, double multiplier)
        {
            return (multiplicant * multiplier);
        }

        public double Floor(double floorize)
        {
            return System.Math.Floor(floorize);
        }

        public double Div(double divident, double divisor)
        {
            if (divisor == 0 && divident > 0)
                return Double.PositiveInfinity;
            if (divisor == 0 && divident < 0)
                return Double.NegativeInfinity;
            if (divisor == 0 && divident == 0)
                return Double.NaN;
            return (divident / divisor);
        }

        public double Mod(double divident, double divisor)
        {
            if (divisor == 0)
                return Double.NaN;
            return (divident % divisor);
        }

        public double Pow(double basis, double exponent)
        {
            return System.Math.Pow(basis,exponent);
        }

        public double Sqrt(double basis, double exponent)
        {
            if (basis < 0)
                return Double.NaN;
            if (exponent == 0)
                return Double.PositiveInfinity;
            else
            {
                exponent = 1 / exponent;
                return (System.Math.Pow(basis, exponent));
            }
        }

        public double Fac(double factorial)
        {
            if ((factorial % 1) != 0)
                return Double.NaN;
            if (factorial < 0)
                return Double.NaN;

            if (factorial == 0)
                return 1.0;

            for (int i = Convert.ToInt32(factorial); i > 0; i--)
                factorial = factorial * (factorial - i);
            return Convert.ToDouble(factorial);
        }
    }
}
