using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAreas
{
    class Veiculo
    {
        protected string tipo;
        protected string estado;

        public Veiculo(string tipo)
        {
            parar();
            this.tipo = tipo;
            
        }
        public virtual void mover()
        {
            Console.WriteLine("Estou me movendo");
            this.estado = "Em movimento";
        }
        public virtual void parar()
        {
            Console.WriteLine("Estou parado");
            this.estado = "Parado";
        }


    }
}
