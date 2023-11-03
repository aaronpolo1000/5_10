using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_5
{
    interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
    }
    class Serie : Entregable
    {
        private string titulo = ""; 
        private string creador = ""; 
        private string genero = "";
        private int num_temp = 3;
        private bool entregado;

        public Serie()
        {

        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, string creador, string genero, int num_temp)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.genero = genero;
            this.num_temp = num_temp;
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        public string Creador
        {
            get
            {
                return creador;
            }
            set
            {
                creador = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public int Num_temp
        {
            get
            {
                return num_temp;
            }
            set
            {
                num_temp = value;
            }
        }
        public bool Entregado
        {
            get
            {
                return entregado;
            }
        }

        public void entregar()
        {
            entregado = true;
        }
        public void devolver()
        {
            entregado = false;
        }
        public bool isEntregado()
        {
            return entregado;
        }
        public bool compareTo(Serie serie)
        {
            if (num_temp > serie.Num_temp)
            {
                return true;
            }
            return false;
        }
    }

    class Videojuego : Entregable
    {
        private string titulo = "", genero = "", compañia = "";
        private int horas_estimadas = 10;
        private bool entregado;

        public Videojuego()
        {

        }
        public Videojuego(string titulo, int horas_estimadas)
        {
            this.titulo = titulo;
            this.horas_estimadas = horas_estimadas;
        }
        public Videojuego(string titulo, string genero, string compañia, int horas_estimadas)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.compañia = compañia;
            this.horas_estimadas = horas_estimadas;
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public string Compañia
        {
            get
            {
                return compañia;
            }
            set
            {
                compañia = value;
            }
        }
        public int Horas_estimadas
        {
            get
            {
                return horas_estimadas;
            }
            set
            {
                horas_estimadas = value;
            }
        }
        public bool Entregado
        {
            get
            {
                return entregado;
            }
        }
        public void entregar()
        {
            entregado = true;
        }
        public void devolver()
        {
            entregado = false;
        }
        public bool isEntregado()
        {
            return entregado;
        }
        public bool compareTo(Videojuego videojuego)
        {
            if (horas_estimadas > videojuego.Horas_estimadas)
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];
            series[0] = new Serie("Naruto", " Masashi Kishimoto");
            series[1] = new Serie();
            series[2] = new Serie("Beyblade", "Takao Aoki", "pelea trompos", 10);
            series[3] = new Serie();
            series[4] = new Serie("Kage no Jitsuryokusha ni Naritakute!", " Daisuke Aizawa, Anri Sakano");
            videojuegos[0] = new Videojuego();
            videojuegos[1] = new Videojuego("Pokemon Rojo", 20);
            videojuegos[2] = new Videojuego("Valorant", "Shooter", "Riot Games", 30);
            videojuegos[3] = new Videojuego();
            videojuegos[4] = new Videojuego("CS 2", 10);

            videojuegos[1].entregar();
            videojuegos[4].entregar();
            series[1].entregar();
            series[4].entregar();

            Serie seriescant = series[rd.Next(0, series.Count())];
            Videojuego juegoscant = videojuegos[rd.Next(0, videojuegos.Count())];
            int conts = 0;
            foreach (Serie ser in series)
            {
                if (ser.compareTo(seriescant))
                {
                    seriescant = ser;
                }
                if (ser.Entregado)
                {
                    ser.devolver();
                    conts++;
                }
            }
            int contv = 0;
            foreach (Videojuego jue in videojuegos)
            {
                if (jue.compareTo(juegoscant))
                {
                    juegoscant = jue;
                }
                if (jue.Entregado)
                {
                    jue.devolver();
                    contv++;
                }
            }
            Console.WriteLine("Habían "+contv+" videojuegos y "+conts+" series entregadas. Luego se devolvieron todas\n\n");
            Console.WriteLine("Videojuego\n\nTitulo: "+ juegoscant.Titulo+"\nCompañia: "+ juegoscant.Compañia+"\nGenero: "+ juegoscant.Genero+"\nHoras estimadas: "+ juegoscant.Horas_estimadas+"\nEntregado: " + juegoscant.Entregado );
            Console.WriteLine("\n\nSerie\n\nTitulo: "+ seriescant.Titulo+"\nCreador: "+ seriescant.Creador+"\nGenero: " + seriescant.Genero+"\nNumero de temporadas: "+ seriescant.Num_temp+"\nEntregado: " + seriescant.Entregado);
            Console.ReadKey();
        }
    }
}