using System;

namespace conflictoExcepciones
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


            do
            {

                try //le informamos al programa que intente ejecutar esta linea 
                {
                    numero1 = Int32.Parse(Console.ReadLine());
                }

                catch (FormatException ex)//  FormatException es generico o una clase hija de Exception
                {
                    Console.WriteLine("Has introducido texto");
                    numero1 = 0;
                }

                catch (Exception e) /*Controlamos la mayoria de excepciones de forma general 
                 YA QUE Excepcion es la clase padre para detectar excepciones no podemos utilizar formatException luego 
                pero si lo podemos hacer antes de usar la clase padre*/
                {
                    //Console.WriteLine(e.Message);
                    Console.WriteLine("No ha introducido un valor no permitido");
                    Console.WriteLine("Se tomara como número introducido el 0");
                    numero1 = 0;
                }


                contador++;

                if (numero1 > aleatorio) Console.WriteLine("el número generado por el programa es menor  <  intenta de nuevo");

                if (numero1 < aleatorio) Console.WriteLine("El número generado por el programa es MAYOR > intenta de nuevo");

            } while (numero1 != aleatorio);

            Console.WriteLine("has acertado con " + contador + " intentos, =)  el número generado es " + aleatorio);
            Console.WriteLine("Apartir de esta line el programa continua....");
        }
        
    }
}
