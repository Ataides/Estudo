using MapaAplicacao.Classe;
using MapaAplicacao.Classe.app;
using MapaDeAplicacoes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            IncluirRepositorioMultiObjetos();

            //EditarRepositorio();
            //IncluirTecnologia();
           // IncluirObjeto();
        }

        private static void IncluirRepositorioMultiObjetos()
        {
            RepositorioApp repositorioApp = new RepositorioApp();
            RepositorioModels repositorio = new RepositorioModels();
            repositorio.Descricao = "Sistema Tabelas basicas";

            repositorio.Objeto = new Collection<ObjetoModels>();


            repositorio.Nome = "RT_TabelasBasicas_VB";
            ObjetoModels objeto = new ObjetoModels();
            objeto.ObjetoTecnologias = new Collection<ObjetoTecnologiaModels>();
            objeto.SubObjetos = new Collection<ObjetoModels>();

            objeto.Nome = "CsmTabelasBasicas.exe";
            objeto.Descricao = "tabelas basicas";
            objeto.RepositorioModels = repositorio;
            objeto.DataCriacaoObjeto = DateTime.Now;

            ObjetoModels objeto2 = new ObjetoModels();
            objeto2.ObjetoTecnologias = new Collection<ObjetoTecnologiaModels>();
            objeto2.Nome = "TabelasBasicas.dll";
            objeto2.Descricao = "tabelas basicas dll";
            objeto2.RepositorioModels = repositorio;
            objeto2.DataCriacaoObjeto = DateTime.Now;

            objeto.SubObjetos.Add(objeto2);

            repositorio.Objeto.Add(objeto);            

            repositorioApp.Incluir(repositorio);
        }

        private static void EditarRepositorio()
        {
            
        }

        private static void IncluirRepositorio()
        {
            RepositorioApp repositorioApp = new RepositorioApp();
            RepositorioModels repositorio = new RepositorioModels();
            repositorio.Descricao = "Sistema devolução mercadoria";

            repositorio.Objeto = new Collection<ObjetoModels>();
            

            repositorio.Nome = "RT_Devolucao_VB";
            ObjetoModels objeto = new ObjetoModels();
            objeto.ObjetoTecnologias = new Collection<ObjetoTecnologiaModels>();
            objeto.Nome = "CsmDevelocao.exe";
            objeto.Descricao = "devolucao";
            objeto.RepositorioModels = repositorio;
            objeto.DataCriacaoObjeto = DateTime.Now;

            ObjetoModels objeto2 = new ObjetoModels();
            objeto2.ObjetoTecnologias = new Collection<ObjetoTecnologiaModels>();
            objeto2.Nome = "Devolucao.dll";
            objeto2.Descricao = "devolucao";
            objeto2.RepositorioModels = repositorio;
            objeto2.DataCriacaoObjeto = DateTime.Now;           
            
            repositorio.Objeto.Add(objeto);
            repositorio.Objeto.Add(objeto2);

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
