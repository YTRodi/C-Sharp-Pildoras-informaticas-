using System;

namespace clase_29___encapsulamiento_y_convenciones
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.cambiarValorEuro(1.05);
            Console.WriteLine(obj.convierte(50));
        }
    }

    class Circulo
    {
        private const double pi = 3.1416;  //Propiedad de una clase. Campo de clase //Constante. Nunca debe cambiar.
        public double CalculoArea(int radio) //Metodo de clase. Que pueden hacer los objs de tipo circulo?
        {
            return pi * radio * radio;
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;//ejemplo.
        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }

        //metodo de acceso para entrar al campo euro y poder cambiar el valor.
        //sin tocar el valor original.
        public void cambiarValorEuro(double nuevoValor)
        {
            if(nuevoValor<0)
            {
                euro = 1.253;
                Console.WriteLine("No se pueden poner numeros negativos.");
            }
            else
            {
                euro = nuevoValor;
            }
        }
    }
}
