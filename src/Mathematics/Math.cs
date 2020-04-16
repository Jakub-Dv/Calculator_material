///-------------------------------------------------------------------------------------------------
// file:	Math.cs
//
// summary:	Implements the mathematics class
///-------------------------------------------------------------------------------------------------

using System;

namespace Mathematics
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> A mathematics.</summary>
    ///-------------------------------------------------------------------------------------------------

    public class Math
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary> Sums.</summary>
        ///
        /// <param name="number1"> Number of 1s.</param>
        /// <param name="number2"> Number of 2s.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

        public double Sum(double number1, double number2)
        {
            return (number1 + number2);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Subs.</summary>
        ///
        /// <param name="minuend">    The minuend.</param>
        /// <param name="subtrahend"> The subtrahend.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

        public double Sub(double minuend, double subtrahend)
        {
            return (minuend - subtrahend);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Muls.</summary>
        ///
        /// <param name="multiplicant"> The multiplicant.</param>
        /// <param name="multiplier">   The multiplier.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

        public double Mul(double multiplicant, double multiplier)
        {
            return (multiplicant * multiplier);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Floors.</summary>
        ///
        /// <param name="floorize"> The floorize.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

        public double Floor(double floorize)
        {
            return System.Math.Floor(floorize);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Divs.</summary>
        ///
        /// <param name="divident"> The divident.</param>
        /// <param name="divisor">  The divisor.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Mods.</summary>
        ///
        /// <param name="divident"> The divident.</param>
        /// <param name="divisor">  The divisor.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

        public double Mod(double divident, double divisor)
        {
            if (divisor == 0)
                return Double.NaN;
            return (divident % divisor);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Pows.</summary>
        ///
        /// <param name="basis">    The basis.</param>
        /// <param name="exponent"> The exponent.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

        public double Pow(double basis, double exponent)
        {
            return System.Math.Pow(basis, exponent);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Sqrts.</summary>
        ///
        /// <param name="basis">    The basis.</param>
        /// <param name="exponent"> The exponent.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Facs.</summary>
        ///
        /// <param name="factorial"> The factorial.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Counts the given array.</summary>
        ///
        /// <param name="arr"> The array.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

        public double X_count(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum = sum + arr[i];
            double result = (1 / Convert.ToDouble(arr.Length)) * sum;
            return result;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Counts.</summary>
        ///
        /// <param name="x">   The x coordinate.</param>
        /// <param name="arr"> The array.</param>
        ///
        /// <returns> A double.</returns>
        ///-------------------------------------------------------------------------------------------------

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
