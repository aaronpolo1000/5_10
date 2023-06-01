using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ej006
{

    

//6) Crear una clase Libro que contenga los siguientes atributos:
//– ISBN
//– Título
//– Autor
//– Número de páginas
//Crear sus respectivos métodos get y set correspondientes para cada atributo.Crear el método que muestre la información relativa al libro con el siguiente formato:
//«El libro con ISBN creado por el autor tiene páginas»
//En el fichero main, crear 2 objetos Libro (los valores que se quieran) y mostrarlos por pantalla.
//Por último, indicar cuál de los 2 tiene más páginas.



    public class Libro
    {
        string ISBN;
        string titulo;
        string autor;
        int numpa;
        public Libro() { }
        public Libro(string ISBN, string titulo,string autor,int numpa)
        {
            this.ISBN = ISBN;
            this.titulo= titulo;
            this.autor=autor;
            this.numpa=numpa;
        }


        public string isbn
        {
            get { return this.ISBN; }
            set { this.ISBN = value; }
        }
        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }
        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }
        public int Paginas
        {
            get { return this.numpa; }
            set { this.numpa = value; }
        }


        public string MostrarTodo()
        {
            return "El libro "+titulo+" con ISBN "+ISBN+" creado por el autor "+autor+" tiene "+numpa+" paginas";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Libro matadero = new Libro("123456789","matadero","echeverria",15);
            Libro pinocho = new Libro("987654321", "pinocho", "yoquese",80);
            Console.WriteLine(matadero.MostrarTodo());
            Console.WriteLine(pinocho.MostrarTodo());
            if (matadero.Paginas > pinocho.Paginas)
            {
                Console.WriteLine("el matadero tiene mas paginas");
            }
            else
            {
                Console.WriteLine("pinocho tiene mas paginas");
            }
        }
    }
}
