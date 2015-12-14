using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MathRoot
    {
        public static bool GetRoot(double number, int n, double p, out double result)
        {
            if ((number < 0 && n % 2 == 0) || p <= 0 || p >= 1 || n <= 0)
            {
                throw new ArgumentException();
            }

            double[] x = new double[2];
            x[0] = number;
            x[1] = number / (double)n;
            while (Math.Abs(x[0] - x[1]) > p)
            {
                x[1] = x[0];
                x[0] = (1.0 / n) * (((n - 1) * x[1]) + (number / Math.Pow(x[1], n - 1)));
            }
            result = x[0];
            return true;
        }
    }
}