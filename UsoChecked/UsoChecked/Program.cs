using System;

namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked //nos sirve para comprobar lo que tenemos dentro del codigo para evitar errores
            //{
                int numero = int.MaxValue;//MaxValue nos debuelve el valor maximo permitido para una variable de tipo int

                int resultado = numero + 20;

                Console.WriteLine(numero);
                Console.WriteLine(resultado);
            //}
            /*
             podemos activar el modo checked solo en visual studio para que nos verifique cuando 
            tenemos desvordamiento de datos
           - click derecho sobre el programa
            - propiedades 
            -en la parte inquierda va mos a compilación 
            - luego avanzado 
            - y activamos la comprobación de desbordamiento aridmetico
             
             */
        }
    }
}
