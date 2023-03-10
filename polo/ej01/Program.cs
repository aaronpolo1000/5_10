using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    internal class Program
    {
        static Int32 suma(Int16 num1, Int16 num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            Int16 n1 = 10, n2 = 20;
            Int32 resultado1, resultado2, resultado3;
          
            resultado1 = suma(n1, n2);
            resultado2 = suma(40, 3);
            resultado3 = suma(1, 2);
            int [] num = { resultado1, resultado2, resultado3 };
            int mayor = num[0];
              for(int i=1;i<3;i++)

            {
                if (mayor < num[i])
                {
                    mayor = num[i];
                }
            }         

            Console.WriteLine("El numero mas grande es " +mayor);
            Console.ReadKey();
        }
    }
}