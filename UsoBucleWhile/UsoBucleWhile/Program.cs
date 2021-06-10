using System;

namespace UsoBucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas entrar el en bucle While?");

            string respuesta = Console.ReadLine(); //varible que es igua a lo que el usuario introcuce por consola

            while (respuesta !="no")
            {
                Console.WriteLine("estas dentro del bucle WHILE ");
                Console.WriteLine("Introduce nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine($"{nombre } Saldras del bucle cuando respondas 'no' a la pregunta");
                Console.WriteLine("Deseas repetir otra vez?");
                respuesta = Console.ReadLine();

            }

            Console.WriteLine("Has salido del bucle y continua la ejecución del programa");


        }
    }
}
