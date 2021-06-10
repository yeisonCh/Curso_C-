using System;
using System.Collections.Generic;

namespace Delegados_Predicados
{
    class Program
    {
        static void Main(string[] args)
        {
            //estos delegados solo devuelven true o false

            List<int> listaNumeros = new List<int>();


            //metemos dentro de la lista un array de estos valores
            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Predicate<int> ElDelegadoPred = new Predicate<int>(DamePares);

            //creamos una lista para almacenar los numeros pares 
            //le colocamos como nombre numPares que debe ser igual a la lista de numeros 
            //y usamos el metodo FindAll al cual le pasamos por parametro un predicado
            List<int> numPares = listaNumeros.FindAll(ElDelegadoPred);

            foreach(int num in numPares)
            {
                Console.WriteLine(num);
            }
        }

        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }

    }


}
