using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Math
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
            return System.Math.Pow(basis, exponent);
        }

        public double Sqrt(double basis, double exponent)
        {
            if (basis < 0)
                return Double.NaN;
            if (exponent == 0)
                return (System.Math.Sqrt(basis));
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

            double result = factorial;
            for (double i = 1; i < factorial; i++)
                result = result * (factorial - i);
            return result;
        }


        ///////////////
        ///PROFILING
        ///////////////
        /*
        public double Sum_Arr(double[] arr)
        {
            ///SUM
            double counter = 0;
            for (int i = 0; i < arr.Length; i++)
                counter = counter + arr[i];
            return counter;
        }*/

        public double X_count(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum = sum + arr[i];
            double result = (1 / Convert.ToDouble(arr.Length)) * sum;
            return result;
        }

        public double S_count(double x, double[] arr)
        {
            double counter = 0;
            ///SUM
            for(int i = 0; i<arr.Length;i++)
            {
                counter = counter + (System.Math.Pow(arr[i],2) - (Convert.ToDouble(arr.Length) * System.Math.Pow(x,2)));
            }
            double result = System.Math.Sqrt((1 / (Convert.ToDouble(arr.Length) - 1)) * counter);
            return result;
        }

    }
}
