using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    class Point
    {
        public double x{get; set;}
        public double y{ get; set;}
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public string toString()
        { 
            return "("+this.x+","+this.y+")";
        }
    }

    struct Vector
    {
        public double x ;
        public double y;
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public string toString()
        {
            return "(" + this.x + "," + this.y + ")";
        }
    }
}
