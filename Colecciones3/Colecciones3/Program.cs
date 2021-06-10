using System;
using System.Collections.Generic;

namespace Colecciones3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numeros = new List<int>();
            Console.WriteLine("Introduce elemntos en la coleccion (0 para parar y salir)");

            int elemento = 1;

            while (elemento != 0)
            {
                elemento = int.Parse(Console.ReadLine());

                Numeros.Add(elemento);

            }

            Numeros.RemoveAt(Numeros.Count-1);// esta instrucción me borra el ultimo elemento 
            // la instrucción es numeros cuentalos y dame la ultima posición 

            Console.WriteLine("------------Los números introducidos:-----------------");

            for(int i=0; i<Numeros.Count; i++)
            {
                Console.WriteLine(Numeros[i]);

            }

            Console.WriteLine("------------Los números introducidos recorridos con un foreach-----------------");

            foreach(int indice in Numeros)
            {
                Console.WriteLine(indice);
            }

        }
    }
}
