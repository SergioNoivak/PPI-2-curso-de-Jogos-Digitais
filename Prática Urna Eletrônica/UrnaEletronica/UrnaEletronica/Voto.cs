using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica
{
    class Voto
    {
       private Candidato candidato;
       private DateTime time;
       
       public Voto(Candidato candidatoDeFora)
        {
            this.candidato = candidatoDeFora;
            this.time = DateTime.Now;
        }

        public Candidato getCandidato()
        {

            return this.candidato;
        }

        public DateTime getTime()
        {

            return this.time;
        }

    }
}
