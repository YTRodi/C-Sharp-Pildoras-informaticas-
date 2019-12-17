using System;

namespace clase_30___uso_de_Constructores__ej_coche_
{
    class Program
    {
        static void Main(string[] args)
        {
            //crea una instancia perteneciente a la clase coche.
            //con new llamo al constructor.
            //dar un estado inicial a nuestro coche.
            Coche coche1 = new Coche();

            //Console.WriteLine("La cantidad de ruedas del coche es de " + coche1.getRuedas());
            Console.WriteLine(coche1.getInfoAuto());

            Coche coche2 = new Coche(4500.25, 1200.35);//Con el otro constructor----------.

            Console.WriteLine(coche2.getInfoAuto());
        }
    }

    class Coche
    {
        //datos encapsulados.
        private int ruedas;  //primera caracteristica.
        private double largo;  //del tipo double para + precisión.
        private double ancho;
        private bool climatizador;  //Que solo me diga TRUE O FALSE (coches tienen climatizador o no).
        private String tapiceria;  //cuero o tela, etc.

        //constructor (estado inicial de cada auto).
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;//centimetros.
        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }
        public int getRuedas()//Asi vamos a pedir info sobre propiedades del auto.
        {
            return ruedas;
        }

        public String getInfoAuto()
        {
            return "--Informacion del auto generico--\n" + "Ruedas: " + ruedas + "\nLargo: " + largo + "\nAncho: " + ancho;
        }

        
    }
}
