using System;
using System.Collections.Generic;

namespace Coleccion_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            //colecciones de tipo la primera en entrar primero en salir 

            //quiwi luego el tipo de dato
            Queue<int> numeros = new Queue<int>();

            //agregando elementos a la cola con la instrucción Enqueue

            //por cada número entero que hay en este array 
            foreach(int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(numero);
            }

            //recorriendo la cola 

            Console.WriteLine("----------------número almacenados-------------");

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //eliminado elementos de la cola ó Queue nos elimina el Fisrt de la colección

            numeros.Dequeue();

            Console.WriteLine("----------------Eliminando un elementos----------------");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
