using ContaTempo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestContaTempo
{
    [TestClass]
    public class UnitTest1
    {
        ContadorPeriodo periodo = new ContadorPeriodo();
        [TestMethod]
        public void UmAnoPorEscrito()
        {
            DateTime dataInformada = new DateTime(2020, 05, 18);
            //Assert.AreEqual(1, periodo.AnosPassados(dataInformada));
            Assert.AreEqual("um ano", periodo.AnosPassadosPorEscrito(dataInformada));
        }
        [TestMethod]
        public void VaziuAnoPorEscrito()
        {
            DateTime dataInformada = new DateTime(2020, 05, 29);
            Assert.AreEqual(0, periodo.AnosPassados(dataInformada));
            Assert.AreEqual("", periodo.AnosPassadosPorEscrito(dataInformada));
        }
        [TestMethod]
        public void UmAnoPorEscritoDias()
        {
            DateTime dataInformada = new DateTime(2020, 05, 19);
            Assert.AreEqual(1, periodo.AnosPassados(dataInformada));
            Assert.AreEqual("um ano", periodo.AnosPassadosPorEscrito(dataInformada));
        }
        [TestMethod]
        public void ZeroMes()
        {
            DateTime dataInformada = new DateTime(2021, 05, 18);
            Assert.AreEqual(0, periodo.MesPassados(dataInformada));
        }
        [TestMethod]
        public void ZeroAno()
        {
            DateTime dataInformada = new DateTime(2021, 05, 18);
            Assert.AreEqual(0, periodo.AnosPassados(dataInformada));
        }
        [TestMethod]
        public void ZeroAnoAnteriorMes()
        {
            DateTime dataInformada = new DateTime(2021, 06, 18);
            Assert.AreEqual(0, periodo.AnosPassados(dataInformada));
        }
        [TestMethod]
        public void ZeroAnoAnteriorDias()
        {
            DateTime dataInformada = new DateTime(2021, 05, 29);
            Assert.AreEqual(0, periodo.AnosPassados(dataInformada));
        }
        [TestMethod]
        public void UmAno()
        {
            DateTime dataInformada = new DateTime(2020, 05, 18);
            Assert.AreEqual(1, periodo.AnosPassados(dataInformada));
        }
        [TestMethod]
        public void DezAnos()
        {
            DateTime dataInformada = new DateTime(2011, 05, 18);
            Assert.AreEqual(10, periodo.AnosPassados(dataInformada));
        }
        [TestMethod]
        public void NoveAnos()
        {
            DateTime dataInformada = new DateTime(2011, 05, 28);
            Assert.AreEqual(9, periodo.AnosPassados(dataInformada));
        }

    }
}
