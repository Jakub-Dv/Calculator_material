///-------------------------------------------------------------------------------------------------
// file:	Program.cs
//
// summary:	Implements the program class
///-------------------------------------------------------------------------------------------------

using System;
using Mathematics;

namespace Profiling
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> A program.</summary>
    ///-------------------------------------------------------------------------------------------------

    class Program
    {
        /// <summary> The mathematics.</summary>
        static Mathematics.Math Math = new Mathematics.Math();

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Main entry-point for this application.</summary>
        ///
        /// <param name="args"> An array of command-line argument strings.</param>
        ///-------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            double s = 0;
            double[] arr = new double[args.Length];

            if (arr.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                    arr[i] = Convert.ToDouble(args[i]);
                double x = Math.X_count(arr);
                s = Math.S_count(x, arr);
            }
            else
                s = 0;
            Console.WriteLine(s);
        }
    }
}
