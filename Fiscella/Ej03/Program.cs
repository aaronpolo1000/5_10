using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;


            while (true)
            {
                Console.WriteLine("1 Lista");
                Console.WriteLine("2 Ingresar numero");
                Console.WriteLine("3 Salir");
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("presiono 1");
                }
                if (tecla.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("presiono 2");
                }
                if (tecla.Key == ConsoleKey.D3)
                { 
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Gracias por usar el programa");
            Console.ReadKey();




            //Console.WriteLine("1 Lista");
            //Console.WriteLine("2 Ingresar numero");
            //Console.WriteLine("3 Salir");

            //tecla = Console.ReadKey();
            //Console.Clear();
            //if (tecla.KeyChar == 49)
            //if (tecla.KeyChar == '1')
            //{
            //    Console.WriteLine("presiono 1");
            //}
            //if (tecla.KeyChar == '2')
            //{
            //    Console.WriteLine("presiono 2");
            //}

            //if (tecla.KeyChar == 13)
            //if (tecla.Key == ConsoleKey.Enter)




            //if (tecla.Key == ConsoleKey.D1)
            //{
            //    Console.WriteLine("presiono 1");
            //}
            //if (tecla.Key == ConsoleKey.D2)
            //{
            //    Console.WriteLine("presiono 2");
            //}

            //Console.ReadKey();

        }
    }
}
