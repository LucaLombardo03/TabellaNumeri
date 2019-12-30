using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetodoNumeri;

namespace TestNumeri
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Max1()
        {
            double n = MethodNumeri.Max(8, 4);
            Assert.AreEqual(n, 8);
        }
        [TestMethod]
        public void Max2()
        {
            double n = MethodNumeri.Max(4, 8);
            Assert.AreEqual(n, 8);
        }
        [TestMethod]
        public void Max3()
        {
            double n = MethodNumeri.Max(4, 4);
            Assert.AreEqual(n, 4);
        }
        [TestMethod]
        public void Min1()
        {
            double n = MethodNumeri.Min(4, 1);
            Assert.AreEqual(n, 1);
        }
        [TestMethod]
        public void Min2()
        {
            double n = MethodNumeri.Min(2, 9);
            Assert.AreEqual(n, 2);
        }
        [TestMethod]
        public void Min3()
        {
            double n = MethodNumeri.Min(3, 3);
            Assert.AreEqual(n, 3);
        }
        [TestMethod]
        public void Media1()
        {
            double n = MethodNumeri.Media(7, 2);
            Assert.AreEqual(n, 4.5);
        }
        [TestMethod]
        public void Media2()
        {
            double n = MethodNumeri.Media(2, 6);
            Assert.AreEqual(n, 4);
        }
        [TestMethod]
        public void Media3()
        {
            double n = MethodNumeri.Media(2, 2);
            Assert.AreEqual(n, 2);
        }
    }
}
