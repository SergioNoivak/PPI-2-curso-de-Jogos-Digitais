using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAreas
{
     class Circulo : FormaGeometrica
    {
        private double raio;
        public Ponto2D centro;

        public double getDiametro()
        {
            return this.raio * 2;

        }
        public double getArea()
        {
            return Math.Pow(this.raio, 2) * Math.PI;
        }

        public Circulo(int lados, int vertices, int dimensao):base(lados,vertices,dimensao)
        {
        }

     
      


    }
}
