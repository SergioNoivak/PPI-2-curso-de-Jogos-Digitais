using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Decorator
{
    class ComponenteConcreto : Componente
    {
        public override void fazerCasa()
        {
            Console.WriteLine("A casa está completa e fechada para modificacao");


        }
    }
}
