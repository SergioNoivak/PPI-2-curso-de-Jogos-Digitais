using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.FactoryMethod
{
    class Cachorro : IAnimal
    {
        public void agir()
        {
            Console.WriteLine("Cachorros normalmente latem");
        }

        public void falar()
        {
            Console.WriteLine("Cachorros dizem AU AU");
        }
    }
}
