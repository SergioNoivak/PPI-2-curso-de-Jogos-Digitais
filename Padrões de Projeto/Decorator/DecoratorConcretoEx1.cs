using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Decorator
{
    class DecoratorConcretoEx1 : DecoratorAbstrato
    {
        public override void fazerCasa()
        {
            base.fazerCasa();
            //decorator
            adicionarPiso();


        }
        public void adicionarPiso(){
            Console.WriteLine("Adicionar piso");

            }

    }
}
