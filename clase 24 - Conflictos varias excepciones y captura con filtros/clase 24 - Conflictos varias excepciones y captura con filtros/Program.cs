using System;

namespace clase_23___24_Conflictos_con_varias_excepciones
{
    class Program
    {
        static void Main(string[] args)
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
                    //ESTO ES VALIDO, YA QUE HACEMOS LAS EXCEPCIONES ESPECIFICAS ANTES QUE LA GENERAL.(GENERICA)
                    /*catch(FormatException ex)
                    {
                        Console.WriteLine("Has introducido texto.\nSe tomara numero introducido el 0");
                        miNumero = 0;
                    }*/
                    catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                    {
                        Console.WriteLine("Ha habido un error\nSe tomara numero introducido el 0");
                        //No especificamos porque puede ser cualquier caso de excepcion.
                        miNumero = 0;
                        Console.WriteLine(ex.Message);
                        //Esto explica la excepcion que hubo. Tanto como si es una forma21231tException como un OverFlow
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Has introducido texto.\nSe tomara numero introducido el 0");
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
}