using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Prototype
{
    class Ford:Carro
    {
        public Ford(string m)
        {
            this.modelo = m;
        }
        public override Carro clone()
        {
            //Clone sombra
            return (Ford)this.MemberwiseClone();
        }


    }
}
