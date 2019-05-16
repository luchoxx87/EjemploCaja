using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploCaja;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        CajaForte caja;       

        [TestMethod]
        public void pruebasCaja()
        {
            caja = new CajaForte();
            Assert.AreEqual(0, caja.Saldo);
            Assert.AreEqual(0, caja.Aperturas);
            caja.acreditar(5000);
            Assert.AreEqual(5000, caja.Saldo);
            Assert.AreEqual(1, caja.Aperturas);
            caja.retirar(7500);
            Assert.AreEqual(1, caja.Aperturas);
            Assert.AreEqual(5000, caja.Saldo, 0.1);
        }
    }
}
