using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Prototype.exemplo2
{
    class FalsaPosicao:EncontradorDeRaizReal
    {

        public override double getRaiz()
        {

            Console.Write("Calculo de Raiz por Falsa Posicao ");
            return 0;

        }
    }
}
