using System;

namespace clase_24___UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            /*checked
            {
                //lo que hay dentro lo checkee, que si hay un error (un desbordamiento, etc).
                //Hace que caiga el programa ( SI HAY UNA ERROR).

                int numero = int.MaxValue;//Es una propiedad de la clase integer.
                                          //devuelve el valor mas alto que admite el tipo primitivo INT.

                int resultado = numero + 20;//Si hago esto, se desborda. Pero C# lo ejecuta igual.
                                            //Console.WriteLine(numero);
                Console.WriteLine(resultado);
            }*/

            /*---------------------------------------------------------------------------
             Click derecho en el proyecto.
             -Properties.
             -Build.
             -Advance.
             -Marcamos la opcion de checkear si hay desbordamiento.
             Y NOS MOSTRARIA CUANDO HAY UN OVERFLOW, ETC, ETC.
             ---------------------------------------------------------------------------
            */

            int numero = int.MaxValue;//Es una propiedad de la clase integer.
                                      //devuelve el valor mas alto que admite el tipo primitivo INT.

            //int resultado = numero + 20;//Si hago esto, se desborda. Pero C# lo ejecuta igual.
            int resultado = unchecked (numero + 20);
                                        //Console.WriteLine(numero);
            Console.WriteLine(resultado);



        }
    }
}
