using System;

namespace convertirTextoANumero
{
    class Program
    {
        static void Main(string[] args)
        {
            //la sintaxis que necesitamos es int.parse()
            // o double.parse()

            Console.WriteLine("Introduce el primer numero");

            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo  numero");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma de los dos números es: " + (num1 + num2));


            Console.WriteLine("Introduce el primer numero");

            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el primer numero");

            double num4 = double.Parse(Console.ReadLine());


            Console.WriteLine("El resultado de la división de los dos números es: " + (num3 / num4));


        }
    }
}
