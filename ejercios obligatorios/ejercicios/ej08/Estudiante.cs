using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej08
{
    internal class Estudiante:Persona
    {
        private Calificacion calificacion;
        private static Random rd;

        public Estudiante(string nombre, int edad, string genero, Calificacion calificacion) : base(nombre, edad, genero)
        {
            rd = new Random(10);
            this.calificacion = calificacion;
        }
        public Calificacion Calificacion
        {
            get { return this.calificacion; }
        }

        public bool SeEncuentra()
        {
            int al = rd.Next(0, 9);
            if (al >= 4)
                return true;
            return false;
        }
    }
}

