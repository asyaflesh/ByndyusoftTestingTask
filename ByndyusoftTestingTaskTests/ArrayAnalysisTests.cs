using Microsoft.VisualStudio.TestTools.UnitTesting;
using ByndyusoftTestingTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ByndyusoftTestingTask.Tests
{
    [TestClass()]
    public class ArrayAnalysisTests
    {
        [TestMethod()]
        public void TestNullArray()
        {
            Assert.ThrowsException<ArgumentNullException>(() => { double res = ArrayAnalysis.SumOfTwoMins(null); });
        }

        [TestMethod()]
        public void TestEmptyArray()
        {
            ArrayList arr = new ArrayList();
            Assert.ThrowsException<ArgumentException>(() => { double res = ArrayAnalysis.SumOfTwoMins(arr); });
        }

        [TestMethod()]
        public void TestShortArray()
        {
            ArrayList arr = new ArrayList() { 1 };
            Assert.ThrowsException<ArgumentException>(() => { double res = ArrayAnalysis.SumOfTwoMins(arr); });
        }

        [TestMethod()]
        public void TestItemStr()
        {
            ArrayList arr = new ArrayList() { 1, 2, 3, 7, 2.6, "str", 6.6 };
            Assert.ThrowsException<ArgumentException>(() => { double res = ArrayAnalysis.SumOfTwoMins(arr); });
        }

        [TestMethod()]
        public void TestItemChar()
        {
            ArrayList arr = new ArrayList() { 1, 2, 3, 7, 2.6, 'a', 6.6 };
            Assert.ThrowsException<ArgumentException>(() => { double res = ArrayAnalysis.SumOfTwoMins(arr); });
        }

        [TestMethod()]
        public void TestItemBool()
        {
            ArrayList arr = new ArrayList() { 1, 2, 3, 7, 2.6, true, 6.6 };
            Assert.ThrowsException<ArgumentException>(() => { double res = ArrayAnalysis.SumOfTwoMins(arr); });
        }

        [TestMethod()]
        public void TestItemNull()
        {
            ArrayList arr = new ArrayList() { 1, 2, 3, 7, 2.6, null, 6.6 };
            Assert.ThrowsException<ArgumentException>(() => { double res = ArrayAnalysis.SumOfTwoMins(arr); });
        }

        [TestMethod()]
        public void TestCorrectResult()
        {
            ArrayList arr = new ArrayList() { -11, 2, 3, 7, -2.6, 4, 6.6 };
            double res = ArrayAnalysis.SumOfTwoMins(arr);
            Assert.AreEqual(-13.6, res);
        }

        [TestMethod()]
        public void TestALotOfElements()
        {
            Random rnd = new Random();
            ArrayList arr = new ArrayList();

            for (int i = 0; i < 100000000; i++)
                arr.Add(rnd.Next(0, 1000));
            arr.Add(-5);
            arr.Add(-5);

            double res = ArrayAnalysis.SumOfTwoMins(arr);
            Assert.AreEqual(-10, res);
        }
    }
}