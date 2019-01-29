using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.FactoryMethod
{
    class Tigre : IAnimal
    {
        public void agir()
        {
            Console.WriteLine("Tigres dormem muito e levantam caçar");
        }

        public void falar()
        {
            Console.WriteLine("Tigres falam RAUUUUR");
        }
    }
}
