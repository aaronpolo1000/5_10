using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej008
{
    internal class Aula
    {
        static Random rnd2 = new Random();
        public int cantA;
        public int id;
        public string materia;
        public Profesor profesor;
        public List<Estudiante> estudiantes;
        public Aula(int id, int cantA,string materia,Profesor profesor,List<Estudiante>estudiantes) {
            this.id = id;
            this.cantA =cantA;
            this.materia=materiaa();
            this.profesor=profesor;
            this.estudiantes =estudiantes;
        }
        public string materiaa()
        {
            string[] materias = { "matemáticas", "filosofía", "física" };
            int rnd1 = rnd2.Next(0, materias.Count() - 1);

            return materias[rnd1];
        }
    }
}
