﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej13
{
    internal class Program
    {
        static Random rd = new Random();
        static void esperar(string msg)
        {
            Console.WriteLine(msg);
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter) break;
            }
        }
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            for (int i = 1; i <= 20; i++)
            {
                empleados.Add(new Repartidor("zona " + rd.Next(1, 10), "Repartidor" + i, rd.Next(50000, 100000), rd.Next(18, 50)));
                empleados.Add(new Comercial(rd.Next(100, 300), "Comercial" + i, rd.Next(50000, 100000), rd.Next(18, 50)));
            }
            Console.WriteLine("Lista de empleados:");
            foreach (Empleado Empleados in empleados)
            {
                Console.Write("Nombre: " + Empleados.Nombre + "\nEdad: " + Empleados.Edad + "\nSalario: " + Empleados.Salario + "\n");
                Empleados.plus();
                Console.Write("Salario con plus: " + Empleados.Salario + "\n\n");
            }
            esperar("Presiona enter para terminar el programa...");
        }
    }
}
