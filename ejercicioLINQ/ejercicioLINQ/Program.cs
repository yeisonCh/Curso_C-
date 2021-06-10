using System;
using System.Collections.Generic; //espacio de trabajo para uso de listas 
using System.Linq; // para hacer uso de LINQ

namespace ejercicioLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valoresNumericos = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 };
            Console.WriteLine("números pares");

            //List<int> numerosPares = new List<int>();

            /*foreach (int i in valoresNumericos)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
            }*/

            // esta intrucción remplaza la lista y nos permite presindir del foreach para recorrer el array y sacar los numeros pares 
            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

            foreach(int i in numerosPares)
            {
                Console.WriteLine(i);
            }
        }
    }
}
