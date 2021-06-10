using System;
using System.Collections.Generic;

namespace Colecciones1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PAra usar las listas debemos utilizar o importar la classe System.Collections.Generic
            List<int> Numeros = new List<int>();
            //Numeros.Add(5);//nombre de la instalcia luego punto add y el valor en este caso un entero
            //Numeros.Add(4);
            //Numeros.Add(7);
            //Numeros.Add(52);
            //Numeros.Add(15);

            //for (int i=0; i<5; i++)
            //{
            //    Console.WriteLine(Numeros[i]);
            //}

            Console.WriteLine("----------------------------------------------------------------");
            int[] ListaNumeros = new int[] { 2, 3, 6, 8, 10, 50 };

            for(int i=0; i < 6; i++)
            {
                Numeros.Add(ListaNumeros[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Numeros[i]);
            }
        }
    }
}
