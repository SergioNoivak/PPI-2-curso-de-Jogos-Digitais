using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Builder
{
    class Motocicleta:IBuilder
    { 
        private Produto produto;
        private string modelo;
        
        public Motocicleta(string modelo)
        {
            this.modelo = modelo;
            this.produto = new Produto();
        }
        public void comecarOperacoes()
        {

        }
        public void construirCorpo()
        {
            this.produto.Add("O Corpo contém: Chassi, e motor");
        }
        public void inserirRodas()
        {
            this.produto.Add("Contém 2 rodas");

        }
        public void inserirLuzDeFrente()
        {
            this.produto.Add("Apenas 1 luz");

        }
        public void terminarOperacoes()
        {
            this.produto.Add(string.Format("Motocicleta modelo:{0}", this.modelo));

        }
        public Produto GetProduto()
        { 
            return this.produto;

        }
    }
}
