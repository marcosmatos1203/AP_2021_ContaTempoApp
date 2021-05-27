using ContaTempo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestContaTempo
{
    [TestClass]
    public class UnitTest1
    {
        ContaDias contaDias = new ContaDias();
        [TestMethod]
        public void DeveRetornarNumeroSeDias()
        {
            DateTime dataInformada = new DateTime(2021,05,18);
            Assert.AreEqual(8, contaDias.DiasPassados(dataInformada));
        }
        [TestMethod]
        public void DeveRetornarNumeroDeSemanas()
        {
            DateTime dataInformada = new DateTime(2021, 05, 18);
            Assert.AreEqual(1, contaDias.SemanasPassados(dataInformada));
        }
        [TestMethod]
        public void DeveRetornarNumeroDeMeses()
        {
            DateTime dataInformada = new DateTime(2020, 12, 18);
            Assert.AreEqual(5, contaDias.MesesPassados(dataInformada));
        }
        [TestMethod]
        public void DeveRetornarNumeroDeAnos()
        {
            DateTime dataInformada = new DateTime(2019, 05, 18);
            Assert.AreEqual(2, contaDias.AnosPassados(dataInformada));
        }
       
        //[TestMethod]
        //public void DeveRetornarAnosPorEscritoMaisE()
        //{
        //    DateTime dataInformada = new DateTime(2019, 05, 18);
        //    Assert.AreEqual("Dois anos e", contaDias.escreveData(dataInformada));
        //}

        [TestMethod]
        public void DeveRetornarDoisAnoseDoisMeses()
        {
            DateTime dataInformada = new DateTime(2019, 02, 18);
            Assert.AreEqual("Dois anos e Dois meses ", contaDias.escreveData(dataInformada));
        }
    }
}
