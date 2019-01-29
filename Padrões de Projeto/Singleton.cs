using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto
{
    /* a classe é selada para nao ser possivel fazer herança*/
   public sealed class Singleton
    {
        private static readonly Singleton instance;
        private int numeroDeInstancias = 0;
        private Singleton()=> this.numeroDeInstancias++;
    
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }

}




//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Singleton s = Singleton.Instance;


//            Console.ReadLine();
//        }



//    }

