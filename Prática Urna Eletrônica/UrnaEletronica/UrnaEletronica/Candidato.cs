using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    class Candidato
    {
        private int numero;

        public Candidato(int numeroDeFora)
        {
            this.numero = numeroDeFora;
        }

        public int getNumero()
        {

            return this.numero;
        }


    }
}
