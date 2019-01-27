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
          Console.WriteLine(multiplyBy12(1));
          Console.WriteLine(multiplyBy12(2));
            int variavel = 5;
            Console.WriteLine(multiplyBy12(variavel));

            Console.ReadLine();
          
        }

        static int multiplyBy12(int value)
        {

            return value * 12;

        }
    }
}
