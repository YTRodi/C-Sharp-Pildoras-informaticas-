using System;

namespace clase_36___practica_arrays_en_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] miArray = new int[5];
            //int[] miArray ={ 10, 15, 65, 78, 45 };

            int[] miArray = new int[5] { 10, 15, 65, 78, 45 };
            //Con el new int[5] restrinjo a que sean solamente 5 elementos.

            int posicion = 0;

            //Carga aleatoria del array en C#.
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese posicion:");
                posicion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese valor:");
                miArray[posicion] = int.Parse(Console.ReadLine());
            }*/

            Console.WriteLine("\nLos valores son:");
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(miArray[i]);
            }
        }
    }
}
