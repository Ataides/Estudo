using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRomano
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Convert("I");
            Assert.AreEqual(1, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Convert("V");
            Assert.AreEqual(5, numero);
        }

        [TestMethod]
        public void DeveEntenderDoisSimbolosComoII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Convert("II");
            Assert.AreEqual(2, numero);
        }

        [TestMethod]
        public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Convert("XXII");
            Assert.AreEqual(22, numero);
        }

        [TestMethod]
        public void DeveEntenderNumerosComoIX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Convert("IX");
            Assert.AreEqual(9, numero);
        }

        [TestMethod]
        public void DeveEntenderNumerosComplexosComoXXIV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Convert("XXIV");
            Assert.AreEqual(24, numero);
        }
    }
}