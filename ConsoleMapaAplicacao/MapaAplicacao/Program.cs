using MapaAplicacao.Classe;
using MapaAplicacao.Classe.app;
using MapaDeAplicacoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaAplicacao
{    
    class Program
    {
        static void Main(string[] args)
        {
            //IncluirRepositorio();
            EditarRepositorio();
            //IncluirTecnologia();
           // IncluirObjeto();
        }

        private static void EditarRepositorio()
        {
            RepositorioApp repositorioApp = new RepositorioApp();
            ObjetoApp objetoApp = new ObjetoApp();
            RepositorioModels repositorio = repositorioApp.Listar(1);

            //RepositorioObjetoModels repositorioObjetoModels = new RepositorioObjetoModels();
            //repositorioObjetoModels.Objeto = objetoApp.Listar(2);
            //repositorioObjetoModels.Repositorio = repositorio;
            //repositorio.RepositorioObjeto.Add(repositorioObjetoModels);
            //repositorioApp.Alterar();

        }

        private static void IncluirRepositorio()
        {
            RepositorioApp repositorioApp = new RepositorioApp();           
            RepositorioModels repositorio = new RepositorioModels();

            repositorio.Descricao = "Sistema de comrpas";
            repositorio.Nome = "COM_CsmCompras_VBNET";
            repositorio.DataCriacao = DateTime.Now;
            repositorioApp.Incluir(repositorio);
        }

        private static void IncluirObjeto()
        {
            ObjetoApp objetoApp = new ObjetoApp();
            TecnologiaApp tecnologiaApp = new TecnologiaApp();
            ObjetoModels objeto = new ObjetoModels();
            objeto.Nome = "CsmDistribuicaoVB6.exe";
            objeto.Descricao = "Sistema para Distribuição";
            objeto.DataCriacaoObjeto = DateTime.Now;
            objetoApp.Incluir(objeto);

            IEnumerable<TecnologiaModels> listaTecnologia = tecnologiaApp.Listar();


            foreach (var item in listaTecnologia)
            {
                ObjetoTecnologiaModels objetoTecnologiaModels = new ObjetoTecnologiaModels();
                objetoTecnologiaModels.Objeto = objeto;
                objetoTecnologiaModels.Tecnologia = item;
                objeto.ObjetoTecnologias.Add(objetoTecnologiaModels);
            }            
            
            
        }

        private static void IncluirTecnologia()
        {
            TecnologiaApp tecnologiaApp = new TecnologiaApp();
            TecnologiaModels tecnologia = new TecnologiaModels();
            tecnologia.Nome = "VB6";
            tecnologiaApp.Incluir(tecnologia);
        }

    }
}
