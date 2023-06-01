using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class Vehiculo
    {
        string marca;
        int año;
        public Vehiculo() {
        }
        public Vehiculo(string marca,int año)
        {
            this.marca = marca;
            this.año = año;
        }
        public void MostrarInformacion() {
             Console.Write(" la marca es "+this.marca) ;
            Console.Write(" el año es " + this.año);
        }
   
    }
    public class Automovil : Vehiculo
    {
        string modelo;
        string marca;
        int año;
        public Automovil(string marca, int año,string modelo):base(marca,año)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.año = año;
        }
       new public void MostrarInformacion()
        {
            Console.Write(" la marca es " + marca);
            Console.Write(" el año es " + año);
            Console.WriteLine("  la marca es " + this.modelo);
        }
        public string Modelo
        {
            get {return this.modelo; }

        }
    }
    public class Camion : Vehiculo
    {
        int CapacidadDeCarga;
        string marca;
        int año;
        public Camion(string marca, int año,int capacidad) : base(marca, año)
        {
            this.CapacidadDeCarga = capacidad;
            this.marca = marca;
            this.año = año;
        }
   
        new public void MostrarInformacion()
        {
            Console.Write(" la marca es " + marca);
            Console.Write(" el año es " + año);
            Console.WriteLine("  la capacidad es " + this.CapacidadDeCarga);
        }
        
      public int capacidad
        {
            get { return this.CapacidadDeCarga; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          

            List<Camion> camiones = new List<Camion>();
            List<Automovil> automovil = new List<Automovil>();
            automovil.Add(new Automovil("renault", 2016, "aerepo1"));
            automovil.Add(new Automovil("peugeot", 2019, "aerepo2"));
            automovil.Add(new Automovil("mitsubushi", 2021, "aerepo3"));
            automovil.Add(new Automovil("mercedes", 2014, "aerepo4"));
            automovil.Add(new Automovil("audi", 2018, "aerepo5"));
            camiones.Add(new Camion("mercedes1", 2017, 200));
            camiones.Add(new Camion("mercedes2", 2012, 140));
            camiones.Add(new Camion("mercedes3", 2011, 30));
            camiones.Add(new Camion("mercedes4", 2022, 300));
            camiones.Add(new Camion("mercedes5", 2023, 90));


            foreach (var item in camiones)
            {

                if (item is Camion) {
                    item.MostrarInformacion();}
            }

            foreach (var item in automovil)
            {

                if (item is Automovil)
                {
                    item.MostrarInformacion();
                }
            }


            Console.ReadKey();

            Console.Clear();
            int posicion=0;
            int cantida = camiones[0].capacidad;
            int posicion1 = 0;
            int cantida1 = camiones[0].capacidad;

            for (int i = 0; i < camiones.Count; i++)
            {
                if (cantida < camiones[i].capacidad)
                {
                    cantida = camiones[i].capacidad;
                    posicion = i;
                }
                if (cantida1 > camiones[i].capacidad)
                {
                    cantida1 = camiones[i].capacidad;
                    posicion1= i;
                }
            }
            Console.WriteLine("El camion de mayor carga es : " ); camiones[posicion].MostrarInformacion();
            Console.WriteLine("El camion de menor carga es : "); camiones[posicion1].MostrarInformacion();
            Console.WriteLine("y fue eliminado el de menor carga");
            camiones.RemoveAt(posicion1);
            Console.ReadKey();

            Console.Clear();
            foreach (var item in camiones)
            {

                if (item is Camion)
                {
                    item.MostrarInformacion();
                }
            }

            foreach (var item in automovil)
            {

                if (item is Automovil)
                {
                    item.MostrarInformacion();
                }
            }
            Console.ReadKey();
        }
    }
}
