using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.AbstractFactoryMethod
{
    class TigreNatural : ITigre
    {
        public void agir()
        {
            Console.WriteLine("Tigres da mata defendem o território deles, não cruze seu caminho");
        }

        public void falar()
        {
            Console.WriteLine("RAUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUr");
        }
    }
}
