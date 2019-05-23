using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteUnitarioAutomatico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDoslados.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        Program teste = new Program();

        string espaco1 = "Ponta de Gôndola";
        string espaco2 = "Gancheira";
        string espaco3 = "Display de balcao";
        string espaco4 = "Display de balcao checkout";
        string espaco5 = "checkout";



       [TestMethod]
       public void validarItemAdicionado()
        {
            
            teste.AdicionarItemALista(espaco1);
            teste.AdicionarItemALista(espaco2);
            teste.AdicionarItemALista(espaco3);
            teste.AdicionarItemALista(espaco4);
            teste.AdicionarItemALista(espaco5);
            //teste.RemoverItemALista(espaco5);
           

            Assert.IsTrue(teste.ListaDeEspaco().Contains(espaco1));
            Assert.IsTrue(teste.ListaDeEspaco().Contains(espaco2));
            Assert.IsTrue(teste.ListaDeEspaco().Contains(espaco3));
            Assert.IsTrue(teste.ListaDeEspaco().Contains(espaco4));
            Assert.IsTrue(teste.ListaDeEspaco().Contains(espaco5));
           

        }


        [TestMethod]
        public void validarItemRemovido()
        {

            string item = "computador";

            teste.AdicionarItemALista(item);

            foreach (var ite in item)
            {

                System.Console.WriteLine(ite);
            }
            teste.RemoverItemALista(item);


            Assert.IsFalse(teste.ListaDeEspaco().Contains(item));

        }


        #region

        [TestMethod()]
        public void CalculaLados1Test()
        {

            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(700, 500, 300, 100));
            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(700, 500, 300, 100));
            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(1700, 1500, 1300, 1100));
            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(7000000000, 500000, 300000, 1000000));
            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(-100, -200, -300, -700));
            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(0888888888888700, 588888888, 300888888, 10088888888));
            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(70088888888, 50088888, 3088880, 100888888));
            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(700, 500, 300, 100));
            Assert.IsNotNull(teste.CalculaLados(1, 1, 1, 1));


            Assert.AreEqual("Lado 1 maioor de todos", teste.CalculaLados(9, 3, 5, 8));


        }

        [TestMethod()]
        public void CalculaLados2Test()
        {

            Assert.AreEqual("Lado 2 maioor de todos", teste.CalculaLados(-100, 900, 200, 300));

        }

        [TestMethod()]
        public void CalculaLados3Test()
        {

            Assert.AreEqual("Lado 3 maioor de todos", teste.CalculaLados(1000, 2000, 3000, 1000));

        }

        [TestMethod()]
        public void CalculaLados4Test()
        {

            Assert.AreEqual("Lado 4 maioor de todos", teste.CalculaLados(10000, 20000, 30000, 99999));
            Assert.AreEqual("Lado 4 maioor de todos", teste.CalculaLados(100000000000000000000000000.0, 700000000000000000000000.0, 8, 9999999999999999999999999999999999999999999.9));

        }


        [TestMethod()]
        public void CalculaLadosTodosOsLadosIguaisTest()
        {

            Assert.AreEqual("Todos os lados são iguais", teste.CalculaLados(0, 0, 0, 0));

        }


        [TestMethod()]
        public void subtracaoTest()
        {
            Assert.AreEqual(-6, teste.Subtracao(10, 9, 8));//-7

        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            Assert.AreEqual(-6, teste.Multiplicacao(2, 5, 8, 10));
            Assert.AreEqual(194, teste.Multiplicacao(12, 25, 28, 90));
            Assert.AreEqual(1072, teste.Multiplicacao(22, 52, 82, 12));//1072


        }

        [TestMethod()]
        public void DivisaoTest()
        {
            Assert.AreEqual(4, teste.Divisao(1, 2, 3, 2, 1));//4
            Assert.AreEqual(284, teste.Divisao(1, -2, 30, 2, 100));//28
         
        }

        #endregion




    }
}
