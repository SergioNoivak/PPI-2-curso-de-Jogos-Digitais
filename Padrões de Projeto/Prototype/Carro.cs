using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Prototype
{
 
        public abstract class Carro
        {
            public string modelo{ get; set; }
            public int preco { get; set; }
            public static int SetPreco()
            {
                int preco = 0;
                Random r = new Random();
                int p = r.Next(200000, 5000000);
                preco = p;
                return preco;
            }
        /* Se clone for abstrato todas as classes deverao implementa-lo */
            public abstract Carro clone();
        }

}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ConsoleApp2.Padrões_de_Projeto.Prototype;


//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Carro nano = new Nano("Nano Verde");
//            Carro ford = new Ford("Ford Ka");

//            Carro basico;
//            basico = nano.clone();


//            Carro basico2;
//            basico2 = ford.clone();

//            Console.ReadLine();
//        }



//    }
//}
