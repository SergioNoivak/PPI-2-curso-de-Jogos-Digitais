using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Prototype
{
 
        public abstract class Carro
        {
            public string modelo{ get; set; }
            public int preco { get; set; }
            public static int SetPreco()
            {
                int preco = 0;
                Random r = new Random();
                int p = r.Next(200000, 5000000);
                preco = p;
                return preco;
            }
        /* Se clone for abstrato todas as classes deverao implementa-lo */
            public abstract Carro clone();
        }
    
}


