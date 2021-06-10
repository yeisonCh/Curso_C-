using System;

namespace BucleDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vamos a jugar, el programa ha generado un número aleatorio y debes adibinarlo");

            Random numero = new Random(); //Random genera numero aleatorio 

            int aleatorio = numero.Next(0, 100);// esto nos genera un número aleatorio entre 0 y 100

            int numero1;

            int contador = 0;

            Console.WriteLine("Introduce un número entre 0 y 100");

           
           do {


                numero1 = Int32.Parse(Console.ReadLine());

                contador++;

                if (numero1 > aleatorio) Console.WriteLine("el número generado por el programa es menor  <  intenta de nuevo");

                if (numero1 < aleatorio) Console.WriteLine("El número generado por el programa es MAYOR > intenta de nuevo");

            } while (numero1 != aleatorio);

                Console.WriteLine("has acertado con " + contador + " intentos, =)  el número generado es " + aleatorio);

            
        }
    }
}
