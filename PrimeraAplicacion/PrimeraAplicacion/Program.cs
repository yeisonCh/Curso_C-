using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al curso de C#"); //esto imprime un comentario en consola

            /*Comentario 
             * de varias
             * lineas */

            int edad;

            edad = 28;

            Console.WriteLine(edad);

            edad++; //uso de operador ++ para incrementar 
            Console.WriteLine( 7 * 5);

            Console.WriteLine(7/5); // nos devuelve valores enteros 

            Console.WriteLine(7 / 5.0);// nos devuelve valores decimales
            Console.WriteLine(9 % 4);// nos devuelve el resido de la division 

            Console.WriteLine("Tu edad es: "+ edad);

            Console.WriteLine($"Tienes una edad de {edad} años ");//interpolacion de codigo
        }
    }
}
