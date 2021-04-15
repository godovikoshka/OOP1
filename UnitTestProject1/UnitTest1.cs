using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sort = new Sort();
            int[] arr = { 3, 7, 9, 10, 2 };
            int[] res = sort.QuickSort(arr, 0, 4);
            int[] exp = { 2, 3, 7, 9, 10 };

            int n = 0;
            while (n < 5)
            {
                Assert.AreEqual(res[n], exp[n]);
                n++;
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sort = new Sort();
            int[] arr = { 5 };
            int[] res = sort.QuickSort(arr, 0, 0);
            int[] exp = { 5 };
            Assert.AreEqual(res[0], exp[0]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var sort = new Sort();
            int[] arr = { 49, 37, 86, 2, 7, 16, 30, 27, 33, 22, 18, 19, 87, 11, 1, 63, 14, 4, 20 };
            int[] res = sort.QuickSort(arr, 0, 18);
            int[] exp = { 1, 2, 4, 7, 11, 14, 16, 18, 19, 20, 22, 27, 30, 33, 37, 49, 63, 86, 87 };
            int n = 0;
            while (n < 18)
            {
                Assert.AreEqual(res[n], exp[n]);
                n++;
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            var sort = new Sort();
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] res = sort.QuickSort(arr, 0, 8);
            int[] exp = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = 0;
            while (n < 8)
            {
                Assert.AreEqual(res[n], exp[n]);
                n++;
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            var sort = new Sort();
            int[] arr = { 1, 4, 1, 2, 90, 1, 4, 2 };
            int[] res = sort.QuickSort(arr, 0, 7);
            int[] exp = { 1, 1, 1, 2, 2, 4, 4, 90 };
            int n = 0;
            while (n < 7)
            {
                Assert.AreEqual(res[n], exp[n]);
                n++;
            }
        }
    }
}
