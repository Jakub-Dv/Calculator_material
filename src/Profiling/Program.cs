using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Mathematics;

namespace Profiling
{
    class Program
    {
        static Mathematics.Math Math = new Mathematics.Math();

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
            Console.ReadLine();
        }
    }
}
