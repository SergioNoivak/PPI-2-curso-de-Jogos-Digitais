using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.AbstractFactoryMethod
{
    class CachorroDomestico : ICachorro
    {
        public void agir()
        {
            Console.WriteLine("Cachorros domésticos preferem ficar em casa");
        }

        public void falar()
        {
            Console.WriteLine("AU AU");
        }
    }
}
