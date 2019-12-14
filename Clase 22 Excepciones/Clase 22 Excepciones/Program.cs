using System;

namespace Clase_22_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandom = new Random();
            int aleatorio = numeroRandom.Next(0, 100);//Min y Max
            int miNumero;
            int intentos = 0;

            Console.WriteLine("Ingresa un n° entre 0 y 100");
            Console.WriteLine("----------------------------");

            do
            {
                intentos++;

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                /*catch(Exception ex)
                {
                    Console.WriteLine("No ingresaste un valor númerico válido\nSe tomara numero introducido el 0");
                    miNumero = 0;
                    Console.WriteLine(ex.Message);//Esto explica la excepcion que hubo. Tanto como si es una formatException como un OverFlow

                }*/
                catch(FormatException ex)
                {
                    Console.WriteLine("No ingresaste un valor númerico válido\nSe tomara numero introducido el 0");
                    miNumero = 0;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Has ingresado un numero demasiado alto\nSe tomara numero introducido el 0");
                    miNumero = 0;
                }

                if (miNumero > aleatorio) Console.WriteLine("El n° es mas bajo");
                if (miNumero < aleatorio) Console.WriteLine("El n° es mas alto");
            } while (aleatorio != miNumero);
            
            Console.WriteLine($"El numero ({miNumero}) es correcto!");
            Console.WriteLine($"Lo has hecho en {intentos} intentos");
        }
    }
}
