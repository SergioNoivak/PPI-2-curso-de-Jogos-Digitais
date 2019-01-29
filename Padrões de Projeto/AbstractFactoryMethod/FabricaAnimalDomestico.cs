using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.AbstractFactoryMethod
{
    class FabricaAnimalDomestico : IFabricaAnimal
    {
        public ICachorro GetCachorro()
        {
            return new CachorroDomestico();
        }

        public ITigre GetTigre()
        {
            return new TigreDomestico();
        }
    }
}
