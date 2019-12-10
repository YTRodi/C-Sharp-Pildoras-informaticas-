using System;

namespace Clase_3_7_Sintaxis_basica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Conversion de texto a numero. Método: parse (CLASE 7)*/
            Console.WriteLine("Ingrese primer numero");
            int numOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero");
            int numTwo = int.Parse(Console.ReadLine());
            int resultado = numOne + numTwo;

            //Console.ReadLine();Espera el ingreso de algun dato y luego el programa seguirá.

            if (numOne >= 15 && numOne <= 20 && numTwo >= 15 && numTwo <= 20)
            {
                Console.WriteLine("El numero que ingreso el usuario es: " + numOne);
                Console.WriteLine("El numero que ingreso el usuario es: " + numTwo);
                Console.WriteLine("La suma de los dos numeros es:" + resultado);
            }
            else
            {
                Console.WriteLine("Fuera de rango");
            }

            

            /*
             * CLASE 3-6 APROX.
             * ----------------
            int edad = 15;
            Console.WriteLine("La edad de la variable es:" + edad);
            Console.WriteLine($"La edad de la variable es:{edad}");//Interpolación de STRINGS
            */
        }
    }
}
