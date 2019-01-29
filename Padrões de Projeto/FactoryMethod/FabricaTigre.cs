using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.FactoryMethod
{
    class FabricaTigre : IFabricaAnimal
    {
        public override IAnimal criarAnimal()
        {
            return new Tigre();
        }
    }
}
