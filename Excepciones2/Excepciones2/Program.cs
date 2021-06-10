using System;

namespace Excepciones2
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

                /*catch (FormatException ex) //nos controla el formato insertado por el usuario
                {
                    Console.WriteLine("No ha introducido un valor númerico valido");
                    Console.WriteLine("Se tomara como número introducido el 0");
                    numero1 = 0; //inicializamos la variable numero1 ya que al meterla en el try no nosquedaria inicializada 
                    // y nos mostraria un error ya que no tiene que evaluar en el if
                }
                catch(OverflowException e) //nos controla el valor si es damciado grande
                {
                    Console.WriteLine("No ha introducido un valor demaciado grande");
                    Console.WriteLine("Se tomara como número introducido el 0");
                    numero1 = 0;
                }*/

                catch (Exception e) //Controlamos la mayoria de excepciones 
                {
                    Console.WriteLine(e.Message);
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
