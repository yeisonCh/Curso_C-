using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegular
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;

            string cadena = "Mi nombre es Juan y mi n° de telefono es (+34)123-45-67 y mi codigo postal es 29679";

            string patron = "[J]";

            string busqueda = @"\d{3}-";

            string prefijo = @"\d+34";

            Regex miRegex = new Regex(patron);

            Regex miRegex2 = new Regex(busqueda);

            Regex preRegex = new Regex(prefijo);

            //usamos la clese condicción 
            MatchCollection elMatch = miRegex.Matches(cadena);

            MatchCollection elMatch2 = miRegex2.Matches(cadena);

            MatchCollection matches = preRegex.Matches(cadena);

            cantidad = elMatch.Count;

            cantidad1 = elMatch2.Count;

            cantidad2 = matches.Count;


            if (elMatch.Count >0) Console.WriteLine("Se ha encontrado  {0} J",cantidad);
            else Console.WriteLine("No se ha encontrado J");

            if (elMatch2.Count > 0) Console.WriteLine("Se ha encontrado  {0}  grupo de tres digitos", cantidad1);
            else Console.WriteLine("No se ha encontrado  grupos de tres digitos");

            if (elMatch2.Count > 0) Console.WriteLine("Se ha encontrado  {0} vez el prefijo +34", cantidad2);
            else Console.WriteLine("No se ha encontrado  grupos de tres digitos");


        }
    }
}
