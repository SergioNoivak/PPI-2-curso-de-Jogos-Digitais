using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAreas
{
    public class FormaGeometrica
    {
        protected int lados;
        protected int vertices;
        protected int dimensao;

        public FormaGeometrica(int lados,int vertices, int dimensao)
        {
            this.lados = lados;
            this.vertices = vertices;
            this.dimensao = dimensao;
        }

        public double getArea()
        {
            return 0.0;

        }
    }
}
