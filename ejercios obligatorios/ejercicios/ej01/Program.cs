using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using tp03;

namespace tp03
{

    class Cuenta
    {
        public string titular;
        public double cantidad;
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public Cuenta(string titular)
        {
            this.titular = titular;
        }


        public double IngresarCantidad(double cant)

        {

            if (cant < 0)
            {
                return this.cantidad;
            }
            return this.cantidad = cant + cantidad;
        }

        public double RetirarCantidad(double cant)

        {

            if (this.cantidad <= cant)
            {
                return this.cantidad = 0;
            }
            return this.cantidad = (this.cantidad - cant);
        }

    }
}


internal class Program
{
    static void Main(string[] args)
    {

        //            1) Crea una clase llamada Cuenta que tendrá los siguientes atributos: titular y cantidad(puede tener decimales).
        //El titular será obligatorio y la cantidad es opcional.Crea dos constructores que cumplan lo anterior.
        //Tendrá dos métodos especiales:
        //ingresar(double cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
        //retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
        double cant = -1;
        Cuenta rtn = new Cuenta("marcos", 10);
        Console.WriteLine(rtn.IngresarCantidad(cant));
        Console.ReadKey();
    }
}
