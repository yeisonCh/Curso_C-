using System;
using System.Collections.Generic;

namespace Coleccion_Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //colecciones de tipo diccionario

            // creamos un objeto de tipo diccionario y usamos como clave un string para almacenar un nombre y el valor un entero para almacenar una edad
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //llenando el diccionario 

            edades.Add("Andres", 18);
            edades.Add("Sandra", 20);

            edades["Maria"] = 25;
            edades["Jose"] = 29;


            //recorrer el diccionario

            Console.WriteLine("-----------------Recorriendo el diccionario------------------");

            foreach(KeyValuePair<string, int> persona in edades)
            {

                Console.WriteLine("Nombre:{0} Edad: {1} ", persona.Key, persona.Value);
                //Console.WriteLine("Nombre: "+ persona.Key + " Edad:  "+ persona.Value);  es el equivalente de la linea anterior


            }

        }
    }
}
