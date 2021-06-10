using System;
using System.Collections.Generic;

namespace Colecciones_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //el ultimo elemento en entrar es el primero en salir LIFO 
            //Last Int Fisrt Out

            //usamos la clase Stack

            Stack<string> palabra = new Stack<string>();

            //rellenamos el stack con un array 

            foreach (string palabras in new string[4] {"Andres", "Sandra", "Josue", "Joel"})
            {
                palabra.Push(palabras);
            }

            Console.WriteLine("Los elemntos de tipo string que queremos agregar son: "+ "Andres, "+ "Sandra, "+ "Josue, " + "Joel");
            Console.WriteLine("-----------Recorriendo el stack-------------");
            foreach(string palabras in palabra)
            {
                Console.WriteLine(palabras);
            }


            Console.WriteLine("--------------eleiminando un elemento con el motodo pop--------------");

            palabra.Pop();

            Console.WriteLine("-----------Recorriendo el stack-------------");
            foreach (string palabras in palabra)
            {
                Console.WriteLine(palabras);
            }

            Console.WriteLine("--------Insertando un elemto usando el metodo Push--------------");

            palabra.Push("Alejandro");

            Console.WriteLine("-----------Recorriendo el stack-------------");
            foreach (string palabras in palabra)
            {
                Console.WriteLine(palabras);
            }
        }
    }
}
