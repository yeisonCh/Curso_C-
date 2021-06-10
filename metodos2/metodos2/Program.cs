using System;

namespace metodos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(Suma(valor1,valor2));
        }

        //podemos realizar metodos sobrecardados de esta forma 
        static double Suma(int num1, double num2, double num3=0)
            //podemos asignar un valor obcional en un metodo, y esto lo hacemos coloca ndo un igual a cero en el parametro deseado
            //los parametros obcionales deben ir despues de los obloigatorios
        {
            return num1 + num2 + num3;
        }
    }
}
