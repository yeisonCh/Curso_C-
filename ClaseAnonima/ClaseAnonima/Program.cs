using System;

namespace ClaseAnonima
{
    class Program
    {
        static void Main(string[] args)
        {

            //Clase anonima (No sabemos el nombre de la clase) y declaramos variables y las inicializamos
            var miVariable = new { Nombre = "Andres", Edad = 19 };

            Console.WriteLine(miVariable.Nombre+ " "+ miVariable.Edad);

            var otraClase = new { Nombre = "Sandra", Edad = 20 };

            // RESTICCIONES 
            /*
             -- Solo puede contener campos publicos 
             -- Todos los campos deben estar iniciados 
             -- Los campos no pueden ser static 
             -- No se puede definir metodos            
             
             */
        }
    }
}
