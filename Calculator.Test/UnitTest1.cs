using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var s = Suma.Sum(1, 2);
            Assert.AreEqual(3, s);
        }

        [TestMethod]
        public void TestSumaFail()
        {
            var s = Suma.Sum(1, 2);
            Assert.AreNotEqual(6, s);
        }

        [TestMethod]
        public void TestDivision()
        {
            var d = Division.Div(21, 3);            
            Assert.AreEqual(7, d);
        }

        [TestMethod]
        public void TestDivisionFail()
        {
            var d = Division.Div(21, 3);
            Assert.AreNotEqual(1, d);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            var m = Multiplicacion.Mult(3, 5);
            Assert.AreEqual(15, m);
        }

        [TestMethod]
        public void TestMultiplicacionFail()
        {
            var m = Multiplicacion.Mult(3, 5);
            Assert.AreNotEqual(5, m);
        }

        [TestMethod]
        public void TestResta()
        {
            var s = Resta.Rest(10, 11);
            Assert.AreEqual(-1, s);
        }

        [TestMethod]
        public void TestRestaFail()
        {
            var s = Resta.Rest(10, 11);
            Assert.AreNotEqual(1, s);
        }
    }
}
