using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Proxy
{
    class Proxy:Sujeito
    {
        Sujeito cs;
        public override void facaAlgo()
        {
            if (this.cs == null)
                cs = new SujeitoConcreto();

            cs.facaAlgo();
        }
    }
}
