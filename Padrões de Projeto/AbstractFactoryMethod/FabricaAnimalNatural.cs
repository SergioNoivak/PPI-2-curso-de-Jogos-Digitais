using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.AbstractFactoryMethod
{
    class FabricaAnimalNatural : IFabricaAnimal
    {
        public ICachorro GetCachorro()
        {
            return new CachorroNatural();
        }

        public ITigre GetTigre()
        {
            return new TigreNatural();

        }
    }
}
