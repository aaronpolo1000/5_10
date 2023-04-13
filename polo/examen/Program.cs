using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace examen
{

    public class Persona
    {
        public Persona() { }
        public string nombre;
        public string apellido;
        public double peso1;
        public double altura1;
      
        public Persona(string name, string surname, double altura, double peso)
        {
            this.nombre = name;
            this.apellido = surname;
            this.peso1 = peso;
            this.altura1 = altura;
          
        }

    }


    internal class Program
    {
        

     

        static void Main(string[] args)
        {

            //            Comenzar con una lista de Personas.
            //Las mismas tienen que tener los atributos nombre(string), apellido(string), peso(float), altura(float),

            //1.Mostrar todos los datos en forma de lista de las personas con sus datos
            //2.Calcular el promedio de peso de todas las personas en la lista
            //3.Hacer un buscador de personas que muestre la info de la misma si es que la encuentra
            //4.El indice de masa corporal se calcula de la siguente manera. Peso / (altura * altura)
            //5 Indices se evaluan de la siguente manera(imc < 18.5 Peso bajo), (imc <

            //25  Peso normal), (imc < 18.5 Peso bajo), (imc < 30 Sobrepeso)
            //6.Cual es el porcentaje de cada escala.


            List<Persona> personas = new List<Persona>();
            Persona Buscar(string nombre2)
            {
                foreach (var item in personas)
                {
                      
                    if(item.nombre == nombre2)
                    {
                        Console.WriteLine(item.nombre + ", "  + item.apellido + ", "  + item.altura1 + ", "  + item.peso1);
                        return item;
                   
                    }
                   
                }
                return null;
            }

            personas.Add(new Persona("aaron", "polo", 160, 80));
            personas.Add(new Persona("aaron1", "polo1", 150, 60));
            personas.Add(new Persona("aaron2", "polo2", 190, 100));
            personas.Add(new Persona("aaron3", "polo3", 180, 90));
            double pesot = 0;
            int pb = 0;
            int pn = 0;
            int sp = 0;
            Console.WriteLine("El listado de personas");
            Console.ReadKey();
            for (int i = 0; i < personas.Count; i++)
            {


                pesot = pesot + personas[i].peso1;
                double imc;
              
                imc = personas[i].peso1 / ((personas[i].altura1/100) * (personas[i].altura1 / 100));
     
                if (imc < 18.5) {
                    pb++;
                }
                if (  imc>18.5 &&imc < 25)
                {
                    pn++;
                }
                if (imc > 25)
                {
                    sp++;
                }
                Console.WriteLine( pb+pn+sp);    
                int promb=(100*pb)/ personas.Count;

                int promn = (100 * pn) / personas.Count;

                int promsp = (100 * sp) / personas.Count;
                Console.WriteLine(personas[i].nombre + ", " + personas[i].apellido + ", " + personas[i].peso1 + ", " + personas[i].altura1);
            


                if (i == personas.Count - 1)
                {

                    double pesopromedio = pesot / personas.Count;
                    Console.WriteLine("El promedio de peso es: " + pesopromedio);
                    Console.WriteLine("El porcentaje de persona con peso bajo es: "+promb+"%");
                    Console.WriteLine("El porcentaje de persona con peso normal es: " + promn + "%");
                    Console.WriteLine("El porcentaje de persona con sobre peso es: " + promsp + "%");

                }



            }
            Console.ReadKey();

            Console.WriteLine("Ingrese nombre de la persona a buscar");
            string nombre3;
            nombre3 = Console.ReadLine();
            Buscar(nombre3);
            Console.ReadKey();



        }
    }
}
