using System;
using static System.Math;//Con esto importamos todos los metodos de la clase Math

namespace clase_32___conceptos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            /*double raiz = Math.Sqrt(9);//raiz cuadrada de nueve
            double potencia = Math.Pow(3, 4);//potencia: 3 a la 4ta.

            Console.WriteLine(raiz);
            Console.WriteLine(potencia);*/

            //CLASES ANONIMAS:
            var miVariable = new {nombre = "Yago", edad = 21};
            Console.WriteLine(miVariable.nombre + " " + miVariable.edad + " ");

            
        }
        
        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(150,90);

            Punto otroPunto = new Punto();
            
            double distancia = origen.DistanciaHasta(destino);//double:para almacenar la distancia entre origen y destino.

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.CountDeObjetos()}");
        }
    }
}
