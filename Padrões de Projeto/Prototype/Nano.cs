using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Padrões_de_Projeto.Prototype
{
    public class Nano : Carro
    {
        public Nano(string m)
        {
            this.modelo = m;
        }

        public override Carro clone()
        {
            //clone sombra
            return (Nano)this.MemberwiseClone();
        }
    }
}

    