using System;
using System.Collections.Generic;
using System.Text;

namespace clase_32___conceptos_POO
{
    class Punto
    {
        private int x;
        private int y;

        private static int contadorDeObjetos = 0;//primera var static

        public Punto(int x, int y)
        {
            //Console.WriteLine($"Coordenada x: {x} \nCoordenada y: {y}");
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        public Punto()
        {
            //Console.WriteLine("Este es el constructor por defecto");
            //Cuando creemos una instancia en la clase Punto, tendran un valor de 0.
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public double DistanciaHasta(Punto otroPunto)//METODO.
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            //el cuadrado de la hipotenusa es igual a la suma de los catetos.
            //sqrt = la raiz cuadrada.
            return distanciaPuntos;
        }

        /*public static int CountDeObjetos()
        {
            return contadorDeObjetos;//devuelve el contenido de la variable static.
        }*/
        public static int CountDeObjetos() => contadorDeObjetos;//es lo mismo que lo de arriba. // metodo de acceso.
    }
}
