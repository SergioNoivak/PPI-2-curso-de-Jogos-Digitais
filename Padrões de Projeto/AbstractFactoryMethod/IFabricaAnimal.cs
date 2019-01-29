using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.AbstractFactoryMethod
{
    interface IFabricaAnimal
    {
        ICachorro GetCachorro();
        ITigre GetTigre();

    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ConsoleApp2.Padrões_de_Projeto.AbstractFactoryMethod;


//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IFabricaAnimal fabricaAnimalNatural = new FabricaAnimalNatural();
//            ICachorro cachorroNatural = fabricaAnimalNatural.GetCachorro();
//            cachorroNatural.falar();
//            cachorroNatural.agir();

//            ITigre tigreNatural = fabricaAnimalNatural.GetTigre();
//            tigreNatural.falar();
//            tigreNatural.agir();


//            IFabricaAnimal fabricaAnimalDomestico = new FabricaAnimalDomestico();
//            ICachorro cachorroDomestico = fabricaAnimalDomestico.GetCachorro();
//            cachorroDomestico.falar();
//            cachorroDomestico.agir();

//            ITigre tigreDomestico = fabricaAnimalDomestico.GetTigre();
//            tigreDomestico.falar();
//            tigreDomestico.agir();

//            Console.ReadLine();
//        }
//    }
//}
