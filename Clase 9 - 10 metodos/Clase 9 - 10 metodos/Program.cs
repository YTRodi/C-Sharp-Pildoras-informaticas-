using System;

namespace Clase_9___10_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            int tam = 0;
            float acumulador = 0;
            float contador = 0;
            float contadorDeCeros = 0;

            Console.WriteLine("Ingrese cuantos numeros quiere ingresar:");
            tam = int.Parse(Console.ReadLine());

            for(int i=0;i<tam;i++)
            {
                Console.WriteLine("Ingrese numero:");
                numero = float.Parse(Console.ReadLine());
                contador++;
                acumulador = acumulador + numero;
                if(numero==0)
                { 
                    contadorDeCeros++;
                }
            }
            
            Console.WriteLine($"Contador es: {contador}");
            Console.WriteLine($"Contador de ceros: {contadorDeCeros}");
            Console.WriteLine($"Acumulador es: {acumulador}");
        }

        static void mostrarMensaje()
        {
            Console.WriteLine("Hola guachin");
        }

        static double dividirNumeros(double num1, double num2) => num1 / num2;
        //ESTO TAMBIEN ES VALIDO... CON EL OPERADOR FLECHA. SE DA POR SUPUESTA EL RETURN.

        
    }

}
