using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Builder
{
    interface IBuilder
    {
        void comecarOperacoes();
        void construirCorpo();
        void inserirRodas();
        void inserirLuzDeFrente();
        void terminarOperacoes();
        Produto GetProduto();
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ConsoleApp2.Padrões_de_Projeto.Builder;


//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //O diretor é o elemento que constroi os objetos segundo um builder
//            Diretor diretor = new Diretor();
//            IBuilder b1 = new Carro("Ford");
//            IBuilder b2 = new Motocicleta("Honda");

//            //fazendo um carro
//            diretor.Construir(b1);
//            Produto p1 = b1.GetProduto();
//            p1.Show();

//            //fazendo uma motocicleta
//            diretor.Construir(b2);
//            Produto p2 = b2.GetProduto();
//            p2.Show();

//            Console.ReadLine();

//        }



//    }
//}
