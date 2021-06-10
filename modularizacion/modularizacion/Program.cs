using System;
using static System.Math; //con esto importamos los metos estaticos de la clase Math 


namespace modularizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            //double raiz = Math.Sqrt(9);  Al importar la clase math podemos precindir de anteponer Math como lo vemos en la siguiente linea
            double raiz = Sqrt(9);
            double potencia = Math.Pow(3, 4);

            Console.WriteLine($"la raíz de 9 es: {raiz}" );
            Console.WriteLine($"la potencia de 3 a la 4 es: {potencia}");
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(128, 80);

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"la distancia entre los puntos es de: { distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");

        }
    }
}
