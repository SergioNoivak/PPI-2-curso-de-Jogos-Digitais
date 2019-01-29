using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Builder
{
    //Classe concreta Carro
    class Carro:IBuilder
    {
        string modelo;
        private Produto produto;
        public Carro(string modelo)
        {
            this.produto = new Produto();
            this.modelo = modelo;
        }
        public void comecarOperacoes()
        {
            this.produto.Add(string.Format("Modelo de produto : {0}", this.modelo));
        }
        public void construirCorpo()
        {
            this.produto.Add("O Corpo contem : Carcaça e eixos");
        }
        public void inserirRodas()
        {
            this.produto.Add("O Corpo contem : 4 rodas");

        }
        public void inserirLuzDeFrente()
        {

            this.produto.Add("O Produto contem : 2 luz da frente");

        }
        public void terminarOperacoes()
        {
   
            //NADA
        }

        public Produto GetProduto()
        {
            return this.produto;
        }
    }
}
