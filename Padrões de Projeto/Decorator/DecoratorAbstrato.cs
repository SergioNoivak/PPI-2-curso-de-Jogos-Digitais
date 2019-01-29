using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Decorator
{
    abstract class DecoratorAbstrato:Componente
    {
        protected Componente componente;

        public void SetComponent(Componente componente)
        {
            this.componente = componente;

        }
        public override void fazerCasa()
        {
            if (this.componente != null)
                componente.fazerCasa();//A tarefa foi delegada

            
        }
    }
}
