using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.FactoryMethod
{
    public interface IAnimal
    {
        void falar();
        void agir();
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ConsoleApp2.Padrões_de_Projeto.FactoryMethod;


//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            FabricaAnimal fabricaTigres = new FabricaTigre();
//            IAnimal tigre = fabricaTigres.criarAnimal();
//            tigre.falar();
//            tigre.agir();


//            FabricaAnimal fabricaCachorro = new FabricaCachorro();
//            IAnimal cachorro = fabricaCachorro.criarAnimal();
//            cachorro.falar();
//            cachorro.agir();



//            Console.ReadLine();
//        }
//    }
//}
