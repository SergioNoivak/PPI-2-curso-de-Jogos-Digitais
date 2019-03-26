using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAreas
{
    class Retangulo : FormaGeometrica
    {
        Ponto2D[] pontos;

        public Retangulo(int lados, int vertices, int dimensao, Ponto2D[] pontos) : base(lados, vertices, dimensao)
        {
            this.pontos = pontos;
        }

        public double getArea()
        {
            return (pontos[3].x - pontos[0].x);
           

        }




    }
}
