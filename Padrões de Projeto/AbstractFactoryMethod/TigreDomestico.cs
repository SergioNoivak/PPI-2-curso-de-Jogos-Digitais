using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.AbstractFactoryMethod
{
    class TigreDomestico : ITigre
    {
        public void agir()
        {
            Console.WriteLine("Esse tipo de tigre vive em circos");
        }

        public void falar()
        {
            Console.WriteLine("HALUMMMMM");

        }
    }
}
