using System;

namespace variableConstante
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de constantes 

            const int VALOR = 5; // se debe inicializar la constante, se debe utilizar mayusculas para las constantes.

            const int VALOR2 = 2;

            Console.WriteLine("el valor de la constante es ",  VALOR);// podemos escribir sin concatenar solo con comas como segundo o tercer argumento
            // pero esto no nos muestra el valor de la constante, para esto debemos utilizar {}
            Console.WriteLine("el valor de la constante es {0}", VALOR);// con esto desimos que queremos reflejar el valor del primer valor o argumento

            Console.WriteLine("el valor de la constante es {0}{1}", VALOR, VALOR2);// esto tambien es valido y nos muestra los dos argumentos


            const double PI = 3.1416; 

            Console.WriteLine("ingrese un radio para calcular el area del circulo ");

            double radio = double.Parse(Console.ReadLine());

            double area = radio * radio * PI;
            Console.WriteLine("El area del circulo es: "+ area); 


        }
    }
}
