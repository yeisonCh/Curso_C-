using System;
using System.Collections.Generic;

namespace Colecciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> DatosNumeros = new List<int>();

            Console.WriteLine("¿cuantos numeros quieres introducir");

            int elemnto = Int32.Parse(Console.ReadLine());//pra hacer el castin lo podemos hacer con int.parse ó con Int32.Parse

            for (int i = 0; i < elemnto; i++)
            {
                Console.WriteLine("introduce el número ");
                DatosNumeros.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("---------------Elementos introcucidos-------------------");
            for (int i = 0; i<DatosNumeros.Count; i++) //la función count nos permite contar los elementos con los que cuenta la lista
            {
                Console.WriteLine(DatosNumeros[i]);
            }
        }
    }
}
