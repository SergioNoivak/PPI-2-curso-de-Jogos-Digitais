using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Builder
{
    class Produto
    {
        private LinkedList<string> pecas;

        public Produto()
        { 
            this.pecas = new LinkedList<string>();
        }
        
        public void Add(string peca)
        {
            this.pecas.AddLast(peca);
        }

        public void Show()
        { 
            foreach(string peca in this.pecas)
            {
                Console.WriteLine(peca);                
            }
        }
    }
}
