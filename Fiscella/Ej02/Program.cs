using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 x;

            //string n1, n2;

            //Console.Write("Ingrese un numero: ");
            //n1 = Console.ReadLine();
            //Console.Write("Ingrese un numero: ");
            //n2 = Console.ReadLine();

            //Console.Write("La suma de n1 y n2 es {0}", (n1 + n2));
            //Console.ReadKey();

            int n1, n2, n3;
            string s;


            Console.Write("Ingrese un numero: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            //s = Convert.ToString(10);
            s = 10.ToString();

            Console.Write("La suma de n1 y n2 es {0}", (n1 + n2));
            Console.ReadKey();

        }
    }
}
