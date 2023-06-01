using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    //    3) Haz una clase llamada Password que siga las siguientes condiciones:
    //Que tenga los atributos longitud y contraseña.Por defecto, la longitud sera de 8.
    //Los constructores serán los siguiente:
    //Un constructor por defecto.
    //Un constructor con la longitud que nosotros le pasemos. Generará una contraseña aleatoria con esa longitud.
    //Los métodos que implementa serán:
    //esFuerte(): devuelve un booleano si es fuerte o no, para que sea fuerte debe tener mas de 2 mayúsculas, mas de 1 minúscula y mas de 5 números.
    //generarPassword():  genera la contraseña del objeto con la longitud que tenga.
    //Método get para contraseña y longitud.
    //Método set para longitud.
    //Ahora, crea una clase clase ejecutable:
    //Crea un array de Passwords con el tamaño que tu le indiques por teclado.
    //Crea un bucle que cree un objeto para cada posición del array.
    //Indica también por teclado la longitud de los Passwords (antes de bucle).
    //Crea otro array de booleanos donde se almacene si el password del array de Password es o no fuerte(usa el bucle anterior).
    //Al final, muestra la contraseña y si es o no fuerte(usa el bucle anterior). Usa este simple formato:
    //contraseña1 valor_booleano1
    //contraseña2 valor_bololeano2

    class Password
    {
        private int longitud = 8;
        private string password;
        public Password(int longitud)
        {
            this.longitud = longitud;
            this.password = Convert.ToString(GenerarPassword());
        }
        public Password() { this.password = Convert.ToString(GenerarPassword()); }


        public string GenerarPassword()
        {
            Random r = new Random();
            List<char> list = new List<char>();
            char[] caracteres = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string password = "";


            for (int i = 0; i < this.longitud; i++)
            {
                int rnd = r.Next(0, caracteres.Count());
                list.Add(caracteres[rnd]);


                if (i == this.longitud - 1)
                {
                    for (int j = 0; j < list.Count; j++)
                    {

                        password += list[j].ToString();


                    }
                }


            }




            return password;
        }

        public string contraseña
        {
            get { return this.password; }
        }
        public int largo
        {
            get { return this.longitud; }
            set { this.longitud = value; }
        }
        public bool EsFuerte(string contra)
        {

            char[] mayusculas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] minusculas = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] numeros = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] arr;
            arr = contra.ToCharArray();
            int m = 0;
            int n = 0;
            int num = 0;



            for (int i = 0; i < arr.Count(); i++)
            {
                if (mayusculas.Contains(arr[i]))
                {
                    m = m + 1;
                }
                if (minusculas.Contains(arr[i]))
                {
                    n = n + 1;
                }
                if (numeros.Contains(arr[i]))
                {
                    num = num + 1;
                }
            }

            if (m >= 2 && n >= 1 && num >= 5)
            {
                return true;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            int longitud = 0;

            List<Password> passwords = new List<Password>();
            Console.WriteLine("Cuantas contraseñas quiere crear");
            cant = Convert.ToInt16(Console.ReadLine());

            List<bool> trueofalse = new List<bool>();


            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("De cuanta longitud debe ser la contraseña número: " + (i + 1));
                longitud = Convert.ToInt16(Console.ReadLine());
                passwords.Add(new Password(longitud));
                if (passwords[i].EsFuerte(passwords[i].contraseña))
                {
                    trueofalse.Add(true);
                    Console.WriteLine(1);
                }
                else
                {
                    trueofalse.Add(false);
                }
            }

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine(passwords[i].contraseña + ",   " + trueofalse[i]);
            }

            Console.ReadKey();
        }
    }
}
