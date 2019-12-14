using System;

namespace clase_25___throw
{
    class Program
    {
        static void Main(string[] args)
        {
            //LANZAMIENTOS DE EXCEPCIONES.
            Console.WriteLine("Introduce un numero de mes:");
            int numeroMes = int.Parse(Console.ReadLine());

            Console.WriteLine(nombreDelMes(numeroMes));

            Console.WriteLine("Aqui continuaria la ejecución del programa");//esto es informativo nada mas.

        }


        //metodo
        public static string nombreDelMes(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "Enero";
                   
                case 2:
                    return "Febrero";
                   
                case 3:
                    return "Marzo";
                    
                case 4:
                    return "Abril";
                   
                case 5:
                    return "Mayo";
                   
                case 6:
                    return "Junio";
                    
                case 7:
                    return "Julio";
                    
                case 8:
                    return "Agosto";
                 
                case 9:
                    return "Septiembre";
                   
                case 10:
                    return "Octubre";
                    
                case 11:
                    return "Noviembre";
                    
                case 12:
                    return "Diciembre";

                default:
                    //return "No existe ese mes";
                    //podemos hacer en vez de que lance un mensaje de error, lanzar una EXCEPCION.
                    throw new ArgumentOutOfRangeException();//Lanza un objeto de este tipo.

            }
        }
    }
}
