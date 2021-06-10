using System;

namespace CrearMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mensajeEnPantalla();
            Console.WriteLine("Mensaje desde el Main ");
            mensajeEnPantalla();
            sumarNumeros(3, 4);
        }

        static void mensajeEnPantalla()// es necesario anteponer la palabra static para poder llamarlo desde el main 
        {
            Console.WriteLine("este mensaje se imprime desde el METODO");
        }
        static void sumarNumeros(int num1, int num2)
        {
            int suma;
            suma = num1 + num2;
            Console.WriteLine("la suma de los dos numeros es: "+ (num1+num2));
            Console.WriteLine("la suma de: " + num1 + " y " + num2 + " es igual a: " + suma );

            Console.WriteLine($"la suma de los dos números ingresados es: {num1+ num2}");

        }
    }
}
