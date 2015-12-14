using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Logic
{
    public class NodAlgoritm
    {
        public static int EuclideanAlgoritm(ref Stopwatch sw, int a, int b)
        {
            sw.Start();

            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a == 0 && b == 0)
            {
                sw.Stop();
                throw new ArgumentException();
            }
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
            {
                sw.Stop();
                return b;
            }
            else
            {
                sw.Stop();
                return a;
            }
        }

        public static int EuclideanAlgoritm(ref Stopwatch sw, int a, int b, int c)
        {
            return EuclideanAlgoritm(ref sw, EuclideanAlgoritm(ref sw, a, b), c);
        }

        public static int EuclideanAlgoritm(ref Stopwatch sw, int a, int b, int c, int d)
        {
            return EuclideanAlgoritm(ref sw, EuclideanAlgoritm(ref sw, a, b, c), d);
        }

        public static int BinaryAlgorithm(ref Stopwatch sw, int a, int b)
        {
            sw.Start();

            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a == 0 && b == 0)
            {
                sw.Stop();
                throw new ArgumentException();
            }

            if (a == 0)
            {
                sw.Stop();
                return b;
            }
            if (b == 0)
            {
                sw.Stop();
                return a;
            }
            if (a == b)
            {
                sw.Stop();
                return a;
            }
            if (a == 1 || b == 1)
            {
                sw.Stop();
                return 1;
            }
            if (a % 2 == 0 && b % 2 == 0)
            {
                sw.Stop();
                return 2 * BinaryAlgorithm(ref sw, a / 2, b / 2);
            }
            if (a % 2 == 0 && b % 2 != 0)
            {
                sw.Stop();
                return BinaryAlgorithm(ref sw, a / 2, b);
            }
            if (a % 2 != 0 && b % 2 == 0)
            {
                sw.Stop();
                return BinaryAlgorithm(ref sw, a, b / 2);
            }
            if (a < b)
            {
                sw.Stop();
                return BinaryAlgorithm(ref sw, (b - a) / 2, a);
            }
            else
            {
                sw.Stop();
                return BinaryAlgorithm(ref sw, (a - b) / 2, b);
            }
        }

        public static int BinaryAlgorithm(ref Stopwatch sw, int a, int b, int c)
        {

            return BinaryAlgorithm(ref sw, BinaryAlgorithm(ref sw, a, b), c);
        }

        public static int BinaryAlgorithm(ref Stopwatch sw, int a, int b, int c, int d)
        {

            return BinaryAlgorithm(ref sw, BinaryAlgorithm(ref sw, a, b, c), d);
        }
    }
}