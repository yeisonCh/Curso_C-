using System;
using System.Collections.Generic;

namespace Colecciones_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> Numeros = new LinkedList<int>();

            //llenamos la LinkedList con un array

            foreach(int numero in new int[] {2,4,6,8,10 })
            {
                Numeros.AddFirst(numero);//siempre agrega el numero al inicio de la lista
            }

            //remover un numero de la lista ó metodo remove
            //   Numeros.Remove(6);


            //creamos un objeto de tipo LinkedListNode entero de nombre nodoInsertar al cual le damos un valor de 21 que esta en su interios
            LinkedListNode<int> nodoInsertar = new LinkedListNode<int>(21);

            //agregamos el nodo

            Numeros.AddLast(nodoInsertar);

            //por cada numero que haya en Numeros 
            /*foreach(int numero in Numeros)
            {
                Console.WriteLine(numero);
            }*/


            //un nodo LinkedList de tipo entero  al cual lo llamamos nodo 
            //mientras que nodo sea diferente de nulo, toma el nodo y colocalo en la posición siguiente
            for(LinkedListNode<int> nodo=Numeros.First; nodo!=null; nodo = nodo.Next)
            {
                int numero = nodo.Value;

                Console.WriteLine(numero);
            }
        }
    }
}
