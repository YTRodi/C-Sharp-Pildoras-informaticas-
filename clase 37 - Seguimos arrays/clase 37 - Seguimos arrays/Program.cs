using System;

namespace clase_37___Seguimos_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //array implicito.
            var datos = new[] { "Yago", "Facu", "Joaco" };
            var valores = new[] { 15, 21, 27, 57, 50.44 };//convierte a todos en double.

            //array de objetos.
            Empleados[] arrayEmpleados = new Empleados[2];

            
        }
    }

    class Empleados
    {
        String nombre;
        int edad;
        public Empleados(String nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }


    }
}
