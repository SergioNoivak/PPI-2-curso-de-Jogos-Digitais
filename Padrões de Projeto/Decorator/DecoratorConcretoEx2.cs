using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Decorator
{
    class DecoratorConcretoEx2:DecoratorAbstrato
    {

        public override void fazerCasa()
        {
            base.fazerCasa();
            pintarCasa();
        }

        void pintarCasa()
        {

            Console.Write("Casa pintada");
        }

    }
}
