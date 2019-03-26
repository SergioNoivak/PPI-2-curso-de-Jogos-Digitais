using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAreas
{
    class Automovel : Veiculo
    {

        public Automovel(string tipo) : base(tipo)
        {
        }

        public override void mover()
        {
            Console.WriteLine("O Automóvel está acelerando");
            this.estado = "Em movimento";
            // this para classe subclasse e base para a classe
            //base
        }

        public override void parar()
        {
            Console.WriteLine("O Automóvel está freiando");
            this.estado = "Parado";

        }


    }
}
