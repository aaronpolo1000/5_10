﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    internal class Profesor:Persona
    {
        private string materia;
        private static Random rd;

        public Profesor(string nombre, int edad, string genero, string materia) : base(nombre, edad, genero)
        {
            rd = new Random();
            if (materia.ToUpper() == "MATEMÁTICAS" || materia.ToUpper() == "FILOSOFÍA" || materia.ToUpper() == "FÍSICA")
                this.materia = materia.ToLower();
            else
                this.materia = "desconocido";
        }

        public string Materia
        {
            get { return this.materia; }
        }
        public bool SeEncuentra()
        {
            int al = rd.Next(0, 9);
            if (al >= 1)
                return true;
            return false;
        }
    }
}

