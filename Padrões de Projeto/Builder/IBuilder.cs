using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Builder
{
    interface IBuilder
    {
        void comecarOperacoes();
        void construirCorpo();
        void inserirRodas();
        void inserirLuzDeFrente();
        void terminarOperacoes();
        Produto GetProduto();
    }
}
