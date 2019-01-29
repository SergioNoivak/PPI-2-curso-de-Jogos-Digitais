using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Prototype.exemplo2
{
    class Bisseccao : EncontradorDeRaizReal
    {
        public override double getRaiz()
        {
            Console.WriteLine("Calculo de Raiz Real por Bisseccao");
            return 0;
        }

        public Bisseccao()
        {


        }

    }
}
