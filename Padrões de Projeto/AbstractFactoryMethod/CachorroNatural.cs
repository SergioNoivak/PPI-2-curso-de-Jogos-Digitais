using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.AbstractFactoryMethod
{
    class CachorroNatural : ICachorro
    {
        public void agir()
        {
            Console.WriteLine("Cachorro do mato defende a mata");
        }

        public void falar()
        {
            Console.WriteLine("AUUUUUUUUUUUUUUUUUUUU");
        
        }
    }
}
