using System;

namespace ArrayPorParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            ProcesaDatos(numeros);

            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }

            int[] arrayElementos = damedatos();

            Console.WriteLine("Imprimiendo desde el main");
            foreach(int i in arrayElementos) Console.WriteLine(i);
            

        }


        static void ProcesaDatos(int [] datos)
        {
            for (int i=0; i<4; i++)
            {
                datos[i] += 10;
            }

        }


        static int[] damedatos()
        {
            Console.WriteLine("¿cuantos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for(int i=0; i < numElementos; i++)
            {
                Console.WriteLine($"Intriduce el dato para la posiciíon {i}");

                respuesta = Console.ReadLine();
                int datosElementos = int.Parse(respuesta);

                datos[i] = datosElementos;

            }

            return datos;
        }
    }
}
