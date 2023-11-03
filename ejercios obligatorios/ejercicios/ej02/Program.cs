using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//2) Haz una clase llamada Persona que siga las siguientes condiciones:
//Sus atributos son: nombre, edad, DNI, sexo (H hombre, M mujer), peso y altura. No queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el más adecuado, también su tipo. Si quieres añadir algún atributo puedes hacerlo.
//Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una constante para ello.
//Se implantaran varios constructores:
//Un constructor por defecto.
//Un constructor con el nombre, edad y sexo, el resto por defecto.
//Un constructor con todos los atributos como parámetro.
//Los métodos que se implementarán son:
//calcularIMC(): calculará si la persona está en su peso ideal (peso en kg/(altura^2  en m)), si esta fórmula devuelve un valor menor que 20, la función devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), significa que está por debajo de su peso ideal la función devuelve un 0  y si devuelve un valor mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. Te recomiendo que uses constantes para devolver estos valores.
//esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.
//comprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Si no es correcto, será H. No será visible al exterior.
//generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de este su número su letra correspondiente. Este método será invocado cuando se construya el objeto. Puedes dividir el método para que te sea más fácil. No será visible al exterior.
//Métodos set de cada parámetro, excepto de DNI.
//Ahora, crea una clase ejecutable que haga lo siguiente:
//Pide por teclado el nombre, la edad, sexo, peso y altura.
//Crea 3 objetos de la clase anterior, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza los métodos set para darle a los atributos un valor.
//Para cada objeto, deberá comprobar si está en su peso ideal, tiene sobrepeso o por debajo de su peso ideal con un mensaje.
//Indicar para cada objeto si es mayor de edad.
//Por último, mostrar la información de cada objeto.
//Puedes usar métodos en la clase ejecutable, para que os sea mas fácil.

namespace ej3
{
    class Persona
    {
        string nombre = "";
        int edad = 0;
        int DNI;
        string sexo = "H";
        double peso = 0;
        double altura = 0;

        public Persona() { this.DNI = GenerarDni(); }
        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {

            this.nombre = nombre;

            this.edad = edad;
            this.DNI = GenerarDni();
            ComprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
        }
        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;

            this.edad = edad;
            this.DNI = GenerarDni();
            ComprobarSexo(sexo);
        }



        public void ComprobarSexo(string c)
        {
            const string sexos = "HMhm";

            if (sexos.Contains(c))
            {
                this.sexo = c;
            }
            else
            {
                this.sexo = "H";
            }


        }
        public int CalcularImc(double peso)
        {
            int imc = 0;
            peso = this.peso / (this.altura * this.altura);

            if (this.peso < 20)
            {
                imc = -1;
            }
            else if (this.peso > 20 && this.peso < 25)
            {
                imc = 0;
            }
            else if (this.peso > 25)
            {
                imc = 1;
            }

            return imc;

        }
        public bool EdadMayor(int edad)
        {
            if (this.edad > 18)
            {
                return true;
            }
            return false;

        }
        public int GenerarDni()
        {
            int rnd = new Random().Next(10000000, 99999999);
            return rnd;
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }
        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }
        public double Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }
        public int Dni
        {
            get { return this.DNI; }

        }
    }



    internal class Program
    {
        string a;
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            string name;
            Int16 edad = 0;
            string sex;
            double heavy = 0;
            double altura = 0;
            string a;
            string b;
            string c;
            Console.WriteLine("Ingrese nombre: ");
            name = Console.ReadLine();

            Console.WriteLine("Ingrese edad: ");

            a = Console.ReadLine();
            if (a == "")
            {
            }

            else
            {
                edad = Convert.ToInt16(a);
            }


            Console.WriteLine("Ingrese sexo: H/M ");
            sex = Console.ReadLine();
            if (sex == "")
            {
                sex = "H";
            }
            Console.WriteLine("Ingrese su peso en kg: ");
            b = Console.ReadLine();
            if (b == "" || b == null)
            {
            }

            else
            {
                heavy = Convert.ToDouble(b);
            }

            Console.WriteLine("Ingrese su altura en m: ");
            c = Console.ReadLine();
            if (c == "" || c == null)
            {
            }

            else
            {
                altura = Convert.ToDouble(c);
            }

            personas.Add(new Persona(name, edad, sex, heavy, altura));
            personas.Add(new Persona(name, edad, sex));
            personas.Add(new Persona());

            Console.Clear();
            for (int i = 0; i < personas.Count; i++)
            {
                Console.SetCursorPosition(0, i * 10);
                Console.WriteLine(personas[i].Nombre);
                Console.WriteLine(personas[i].Edad);
                if (personas[i].EdadMayor(personas[i].Edad))
                {
                    Console.WriteLine("Es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Es menor de edad");
                }
                Console.WriteLine(personas[i].Dni);
                Console.WriteLine(personas[i].Sexo);
                Console.WriteLine(personas[i].Peso);
                if (personas[i].CalcularImc(personas[i].Peso) == -1)
                {
                    Console.WriteLine("Debajo del peso ideal");
                }
                if (personas[i].CalcularImc(personas[i].Peso) == 0)
                {
                    Console.WriteLine("Esta en su peso ideal");
                }
                if (personas[i].CalcularImc(personas[i].Peso) == 1)
                {
                    Console.WriteLine("Esta sobre su peso ideal");
                }
                Console.WriteLine(personas[i].Altura);

            }
            Console.ReadKey();
        }
    }
}
