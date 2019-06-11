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
            IncluirRepositorio();
            //EditarRepositorio();
            //IncluirTecnologia();
           // IncluirObjeto();
        }

        private static void EditarRepositorio()
        {
            
        }

        private static void IncluirRepositorio()
        {
            RepositorioApp repositorioApp = new RepositorioApp();
            RepositorioModels repositorio = new RepositorioModels();
            repositorio.Descricao = "Sistema entrada mercadoria";

            repositorio.Objeto = new Collection<ObjetoModels>();
            

            repositorio.Nome = "RT_Incineracao_VB";
            ObjetoModels objeto = new ObjetoModels();
            objeto.ObjetoTecnologias = new Collection<ObjetoTecnologiaModels>();
            objeto.Nome = "CsmIncineracao.exe";
            objeto.Descricao = "entrada";
            objeto.RepositorioModels = repositorio;
            objeto.DataCriacaoObjeto = DateTime.Now;

            ObjetoModels objeto2 = new ObjetoModels();
            objeto2.ObjetoTecnologias = new Collection<ObjetoTecnologiaModels>();
            objeto2.Nome = "Incineracao.dll";
            objeto2.Descricao = "entrada";
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
