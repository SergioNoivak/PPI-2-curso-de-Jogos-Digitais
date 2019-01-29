using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Proxy
{
    class SujeitoConcreto : Sujeito
    {
        public override void facaAlgo()
        {
            Console.WriteLine("Sujeito concreto fazendo algo");

        }
    }
}
