using System;

namespace metodosReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("la suma de los números es " + sumaNumeros(3, 7));

            Console.WriteLine("la división de los números es " + divideNumeros(18, 7));

            int otrasSuma;

            otrasSuma = sumaNumeros(3, 5) / 2;
            Console.WriteLine(otrasSuma);
            
        }

        static int sumaNumeros(int num1, int num2)
        {
            int suma;

            suma = num1 + num2;

            return suma;

            
        }

        static double divideNumeros(double num1, int num2) => num1 / num2; 
        //un metod simplificado con el uso de => ya que solo contiene una sola linea
        

       
    }
}
