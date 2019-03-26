using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAreas
{
    class Aeronave : Veiculo
    {
        public Aeronave(string tipo) : base(tipo)
        {
        }

        public override void mover()
        {
            decolar();
            voar();
        }

        private void decolar()
        {
            Console.WriteLine("A aronave está decolando");
            this.estado = "ESTADO CRITICO decolando";

        }
        private void voar()
        {
            Console.WriteLine("A aeronave está voando");
            this.estado = "voando";


        }

        public override void parar()
        {
            aterrissar();
            freiar();
        }

        private void aterrissar()
        {

            Console.WriteLine("A aeronave está aterrissando");
            this.estado = "ESTADO CRÍTICO aterrissando";
        }
        private void freiar()
        {
            Console.WriteLine("A aeronave está freiando");
            this.estado = "Parado";

        }

    }
}
