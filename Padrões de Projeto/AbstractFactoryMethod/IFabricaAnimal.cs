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
