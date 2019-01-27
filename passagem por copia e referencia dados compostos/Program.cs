using ConsoleApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(11, 11);
            Console.WriteLine(p.toString());
            soma1(p);
            Console.WriteLine(p.toString());

            Vector v = new Vector(13, 13);
            Console.WriteLine(v.toString());
            soma1(v);
            Console.WriteLine(v.toString());



            Console.ReadLine();
        }

        static void soma1(Point point)
        {
            point.x++;
            point.y++;
        }

          static void soma1(Vector vector)
        {
            vector.x++;
            vector.y++;
        }



    }
}
