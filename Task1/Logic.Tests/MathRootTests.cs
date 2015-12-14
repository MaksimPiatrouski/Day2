using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class MathRootTests
    {
        //posiive
        [TestCase(100, 2, 0.001, Result = true)]
        [TestCase(0, 2, 0.001, Result = true)]

        //negative
        [TestCase(100, -2, 0.001, ExpectedException = typeof(ArgumentException))]
        [TestCase(100, 2, 1, ExpectedException = typeof(ArgumentException))]
        [TestCase(100, 0, 0.001, ExpectedException = typeof(ArgumentException))]
        [TestCase(100, 2, -1, ExpectedException = typeof(ArgumentException))]
        [TestCase(100, 2, 0, ExpectedException = typeof(ArgumentException))]
        [TestCase(-100, 2, 0.001, ExpectedException = typeof(ArgumentException))]

        public bool GetRoot_Bool(double number, int n, double p)
        {
            double result;
            MathRoot.GetRoot(number, n, p, out result);
            return ((result - Math.Pow(number, 1.0 / n)) < p);
        }

        [TestCase(16, 2, 1e-15, Result = 4.0)]
        [TestCase(16, 4, 1e-15, Result = 2.0)]
        [TestCase(27, 3, 1e-15, Result = 3.0)]
        [TestCase(-27, 3, 1e-15, Result = -3.0)]

        public double GetRoot_Result(double number, int n, double p)
        {
            double result;
            MathRoot.GetRoot(number, n, p, out result);
            return result;
        }



    }
}
