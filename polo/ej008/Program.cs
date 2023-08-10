using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ej008
{

//8) Queremos representar con programación orientada a objetos, un aula con estudiantes y un profesor.
//Tanto de los estudiantes como de los profesores necesitamos saber su nombre, edad y sexo.De los estudiantes, queremos saber también su calificación actual (entre 0 y 10) y del profesor que materia da.
//Las materias disponibles son matemáticas, filosofía y física.
//Los estudiantes tendrán un 50% para no ir a clase, por lo que sí hacen faltazo no van a clase pero aunque no vayan quedará registrado en el aula (como que cada uno tiene su sitio).
//El profesor tiene un 20% de no encontrarse disponible(reuniones, baja, etc.)
//Las dos operaciones anteriores deben llamarse igual en Estudiante y Profesor(polimorfismo).
//El aula debe tener un identificador numérico, el número máximo de estudiantes y para que está destinada(matemáticas, filosofía o física). Piensa que más atributos necesita.
//Un aula para que se pueda dar clase necesita que el profesor esté disponible, que el profesor de la materia correspondiente esté en el aula correspondiente(un profesor de filosofía no puede dar en un aula de matemáticas) y que haya más del 50% de alumnos.
//El objetivo es crear un aula de alumnos y un profesor y determinar si puede darse clase, teniendo en cuenta las condiciones antes dichas.
//Si se puede dar clase mostrar cuántos alumnos y alumnas (por separado) están aprobados de momento (imaginad que les están entregando las notas).
//NOTA: Los datos pueden ser aleatorios(nombres, edad, calificaciones, etc.) siempre y cuando tengan sentido(edad no puede ser 80 en un estudiante o calificación ser 12).
public class Persona
    {
        static Random rnd2 = new Random();
        string nombre;
        int edad;
        string sexo;
        public Persona( string nombre,int edad,string sexo) {
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
        }
        public string Nombre {
           get { return nombre; } set {  nombre = value; }
        }
        public int Edad { get { return edad; } set { edad = value; } }
       virtual public int asistenciaa()
        {
            int rnd3 = rnd2.Next(0, 100);
            return rnd3;
        }
        public string sexoo()
        {
            string[] notas = { "H", "M" };
            int rnd1 = rnd2.Next(0, notas.Count() - 1);

            return notas[rnd1];
        }
        public string Sexo { get {  return sexo; } set {  sexo = value; } }
    }

    public class Estudiante : Persona
    {
     static Random rnd = new Random();
        int nota;
        int asistencia;
      
        public Estudiante(string nombre,int edad,string sexo):base(nombre,edad,sexo) {
            this.nota =notaa();
            this.asistencia=asistenciaa();
        }
        public int notaa()
        {
            int[] notas = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         int rnd1 = rnd.Next(0, notas.Count()-1);

            return notas[rnd1];
        }
        public int edaa()
        {
            int rnd1 = rnd.Next(12, 24);

            return rnd1;
        }

        public int Nota { get { return nota; } set { nota=value; } }
    }
    public class Profesor : Persona
    {
        static Random rnd = new Random();
        string materia;
        int asistencia;
        public Profesor(string nombre, int edad, string sexo) : base(nombre, edad, sexo)
        {
            this.materia = materiaa();
            this.asistencia = asistenciaa();
        }
        public int edaa()
        {
            int rnd1 = rnd.Next(24, 60);

            return rnd1;
        }
        public string materiaa()
        {
            string[] materias = { "matemáticas","filosofía" , "física" };
            int rnd1 = rnd.Next(0, materias.Count() - 1);

            return materias[rnd1];
        }
        public string Materia { get {  return materia; } set { materia = value; } }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<asd> list= new

        }
    }
}
