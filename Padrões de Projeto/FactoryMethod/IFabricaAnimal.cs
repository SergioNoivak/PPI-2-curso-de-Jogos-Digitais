using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.FactoryMethod
{
    public abstract class IFabricaAnimal
    {
        public abstract IAnimal criarAnimal();
    }
}
