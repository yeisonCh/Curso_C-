using System;
using System.Collections.Generic;

namespace ExpresionesLanda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tenemos un operador Lambda =>
            // Parametros => expresión ó bloque de sentencia

            /* Persona P1 = new Persona();
             P1.Nombre = "Jua";
             P1.Edad = 18;

             Persona P2 = new Persona();
             P2.Nombre = "Andres";
             P2.Edad = 34;
            */

            //Uso del delegado 

            //OperacionesMatematicas operacion = new OperacionesMatematicas(Cuadrado);

           // Console.WriteLine(operacion(4));

            //simplificar el codigo anterior presindiendo de la función creada 

            OperacionesMatematicas operacion = new OperacionesMatematicas(num=> num*num);

            Console.WriteLine(operacion(4));

            Console.WriteLine("---------otro Ejemplo-----------------------");

            //cuando se usan más de un parametro se deben colocar entre parentesis
            OperacionSuma suma = new OperacionSuma((num1,num2)=> num1 + num2);

            Console.WriteLine(suma(4,3));
            Console.WriteLine("---------otro Ejemplo-----------------------");

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //creamos una lista para lamacenar los numeros pares 

            List<int> pares = numeros.FindAll(i => i % 2 == 0);

            //foreach(int i in pares) Console.WriteLine(i);

            // se puede escribir la linea anterior de otra forma otra forma de usar un ForEach
            pares.ForEach(numero => Console.WriteLine(numero));

            pares.ForEach(numero => { Console.WriteLine("---------------Un ejemplo  del uso del operador Lambda-----"); 
                Console.WriteLine(numero);
                Console.WriteLine("------------Aqui termina el ejemplo-------------------");
            });
        }

        public delegate int OperacionesMatematicas(int numero);

        public delegate int OperacionSuma(int numero1, int numero2);

        //creamos una función que nos debuelva el cuadrado de un valor numerico
        //public static int Cuadrado(int num)
        //{
        //    return num * num;
        //}

        //public static int Suma(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
    }
    class Persona
    {


        private string nombre;
        private int edad;

        //metodos Geter y Seter para las variables creadas
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
