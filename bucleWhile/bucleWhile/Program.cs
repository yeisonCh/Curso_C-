using System;

namespace bucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // estructura de control de flujo BUCLE WHILE
            Console.WriteLine("deseas entrar en el bucle While");

            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estas ejecutando el interior del bucle while");

                Console.WriteLine("Introduce tu nombre por favor");

                string nombre = Console.ReadLine();

                Console.WriteLine( $"Saldras del bucle {nombre} cundo respondas 'no' " );

                Console.WriteLine("¿Deseas repetir otra vez?");

                respuesta = Console.ReadLine();

            }

            Console.WriteLine("Haz salido del bucle" );

            Console.WriteLine("ha terminado el programa");

            Console.WriteLine("Introduce el numero de mes para cálculo de la comisión");

            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {


                case 1:

                    Console.WriteLine("mes seleccionado enero la comisión es de ");
                    break;

                case 2:

                    Console.WriteLine("mes seleccionado Febrero ");
                    break;

                case 3:
                    Console.WriteLine("mes seleccionado Marzo ");
                    break;

                case 4:
                    Console.WriteLine("mes seleccionado Abril");
                    break;
                default:
                    Console.WriteLine("numero de mes no disponible");
                    break;

            }
        }
    }
}
