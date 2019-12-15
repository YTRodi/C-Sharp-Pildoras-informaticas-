using System;

namespace clase_28___Ejemplo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;    //Creamos nuestro primer obj perteneciente a la clase circulo.

            miCirculo = new Circulo(); //Iniciacion de una variable/objeto del tipo Circulo.
            //Instanciar una clase. Ejemplarizació. Creación de ejemplar de clase. SINONIMOS...

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(9));
        }
    }

    class Circulo
    {
        const double pi = 3.1416;  //Propiedad de una clase. Campo de clase //Constante. Nunca debe cambiar.
        public double calculoArea(int radio) //Metodo de clase. Que pueden hacer los objs de tipo circulo?
        {
            return pi * radio * radio;
        }
    }
}
