using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using NUnit.Framework;


namespace Logic.Tests
{
    [TestFixture]
    public class NodAlgoritmTests
    {
        Stopwatch sw = new Stopwatch();

        [TestCase(100, 35, Result = 5)]
        [TestCase(100, -35, Result = 5)]
        [TestCase(-100, 35, Result = 5)]
        [TestCase(0, 100, Result = 100)]
        [TestCase(100, 0, Result = 100)]
        [TestCase(0, 0, ExpectedException = typeof(ArgumentException))]

        public int EuclideanAlgoritm_2Elements(int a, int b)
        {
            int Result = NodAlgoritm.EuclideanAlgoritm(ref sw, a, b);
            return Result;
        }


        [TestCase(100, 35, 70, Result = 5)]
        [TestCase(100, 35, -70, Result = 5)]
        [TestCase(100, 50, 0, Result = 50)]
        [TestCase(0, 100, 50, Result = 50)]
        [TestCase(100, 0, 0, Result = 100)]
        [TestCase(0, 100, 0, Result = 100)]
        [TestCase(0, 0, 100, ExpectedException = typeof(ArgumentException))]
        [TestCase(0, 0, 0, ExpectedException = typeof(ArgumentException))]

        public int EuclideanAlgoritm_3Elements(int a, int b, int c)
        {
            Stopwatch sw = new Stopwatch();
            int Result = NodAlgoritm.EuclideanAlgoritm(ref sw, a, b, c);
            return Result;
        }

        [TestCase(100, 35, 70, 55, Result = 5)]
        [TestCase(100, 35, 70, -55, Result = 5)]
        [TestCase(50, 100, 0, 75, Result = 25)]
        [TestCase(0, 100, 50, 75, Result = 25)]
        [TestCase(100, 0, 0, 0, Result = 100)]
        [TestCase(0, 100, 0, 0, Result = 100)]
        [TestCase(0, 0, 100, 500, ExpectedException = typeof(ArgumentException))]
        [TestCase(0, 0, 0, 500, ExpectedException = typeof(ArgumentException))]

        public int EuclideanAlgoritm_4Elements(int a, int b, int c, int d)
        {
            Stopwatch sw = new Stopwatch();
            int Result = NodAlgoritm.EuclideanAlgoritm(ref sw, a, b, c, d);
            return Result;
        }

        [TestCase(100, 35, Result = 5)]
        [TestCase(100, -35, Result = 5)]
        [TestCase(-100, 35, Result = 5)]
        [TestCase(0, 100, Result = 100)]
        [TestCase(100, 0, Result = 100)]
        [TestCase(0, 0, ExpectedException = typeof(ArgumentException))]

        public int BinaryAlgoritm_2Elements(int a, int b)
        {
            int Result = NodAlgoritm.BinaryAlgorithm(ref sw, a, b);
            return Result;
        }

        [TestCase(100, 35, 70, Result = 5)]
        [TestCase(100, 35, -70, Result = 5)]
        [TestCase(100, 50, 0, Result = 50)]
        [TestCase(0, 100, 50, Result = 50)]
        [TestCase(100, 0, 0, Result = 100)]
        [TestCase(0, 100, 0, Result = 100)]
        [TestCase(0, 0, 100, ExpectedException = typeof(ArgumentException))]
        [TestCase(0, 0, 0, ExpectedException = typeof(ArgumentException))]

        public int BinaryAlgoritm_3Elements(int a, int b, int c)
        {
            Stopwatch sw = new Stopwatch();
            int Result = NodAlgoritm.BinaryAlgorithm(ref sw, a, b, c);
            return Result;
        }

        [TestCase(100, 35, 70, 55, Result = 5)]
        [TestCase(100, 35, 70, -55, Result = 5)]
        [TestCase(50, 100, 0, 75, Result = 25)]
        [TestCase(0, 100, 50, 75, Result = 25)]
        [TestCase(100, 0, 0, 0, Result = 100)]
        [TestCase(0, 100, 0, 0, Result = 100)]
        [TestCase(0, 0, 100, 500, ExpectedException = typeof(ArgumentException))]
        [TestCase(0, 0, 0, 500, ExpectedException = typeof(ArgumentException))]

        public int BinaryAlgoritm_4Elements(int a, int b, int c, int d)
        {
            Stopwatch sw = new Stopwatch();
            int Result = NodAlgoritm.BinaryAlgorithm(ref sw, a, b, c, d);
            return Result;
        }
    }
}
