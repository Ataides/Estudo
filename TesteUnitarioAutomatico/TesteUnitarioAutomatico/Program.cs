using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitarioAutomatico
{
    public class Program
    {


                                       
        public string CalculaLados(double lado1, double lado2, double lado3, double lado4)
        {
            

            if (lado1 > lado2 && lado1 > lado3 && lado1 >lado4) return "Lado 1 maioor de todos";
           

            if (lado2 > lado1 && lado2 > lado3 && lado2 > lado4) return "Lado 2 maioor de todos";
            

            if (lado3 > lado2 && lado3 > lado1 &&lado3 > lado4) return "Lado 3 maioor de todos";
            

            if (lado4 > lado1 && lado4 > lado2 && lado4 > lado3) return "Lado 4 maioor de todos";


            if (lado1 == lado2 && lado2 == lado3 && lado3 == lado4) return "Todos os lados são iguais";

            else return "Todos os lados são diferentes";
           
        }

        public int Soma(int a, int b)
        {
            int resutado = a + b;
             
            return resutado;

        }

        public int Subtracao(int a , int b , int c)
        {
            
            int resultado = ((a - b) - c);
            return resultado;


        }

        public double Multiplicacao(int a, int b, int c, int d)
        {

            int resultado = ((a * b) + a - Soma(c, d));
            return resultado;

        }

        public int Divisao(int a ,int b , int c ,int d, int e)
        {
                                                                     
            int resultado = (Soma(a, b)) / Convert.ToInt32( Multiplicacao(a, b, c, d)) +( e - Subtracao(e,b,c));

            return resultado;

        }

     

        List<string> listaDeEspaco = new List<string>();

        public List<string> ListaDeEspaco()
        {      

            return listaDeEspaco;

        }

        public string AdicionarItemALista(string produto)
        {


            listaDeEspaco.Add(produto);
           

            return produto;

        }

        public string RemoverItemALista(string produto)
        {


            listaDeEspaco.Remove(produto);


            return produto;

        }




        static void Main(string[] args)
        {
            List<string> listaDeCompras = new List<string>();

            listaDeCompras.Add("Maquina de lavar");
            listaDeCompras.Add("Liquidificador");
            listaDeCompras.Add("Fogão");
            listaDeCompras.Add("Televisão");
            listaDeCompras.Add("Batedeira");
            listaDeCompras.Add("Geladeira");

            listaDeCompras.Sort();

            for (int i = 0; i < listaDeCompras.Count; i++)
            {
                Console.WriteLine(listaDeCompras[i]);
            }
                                   
            Console.ReadKey();



        }
    }
}
