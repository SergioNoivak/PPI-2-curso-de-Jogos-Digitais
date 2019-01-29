using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Builder
{
    class Diretor
    {
        IBuilder builder;

        public void Construir(IBuilder builder)
        {
            this.builder = builder;
            builder.comecarOperacoes();
            builder.construirCorpo();
            builder.inserirRodas();
            builder.inserirLuzDeFrente();
            builder.terminarOperacoes();
        }
    }
}
