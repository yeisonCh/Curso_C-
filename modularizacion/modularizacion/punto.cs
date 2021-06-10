using System;
using System.Collections.Generic;
using System.Text;

namespace modularizacion
{
    class Punto
    {

        //constructor
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            //Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
            contadorDeObjetos++;

        }

        //constructor
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            //Console.WriteLine("Este es el constructor por defecto");
            contadorDeObjetos++;
        }
        public double DistanciaHasta(Punto otroPunto) //le pasamos por parametro un (parametro de tipo objeto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            //teorema de pitagoras.
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;
        }
        //metodo para acceder al valor que tenemos en contadorDeObjetos

        /*public static int ContadorDeObjetos()
        {
            return contadorDeObjetos;
        }*/

        public static int ContadorDeObjetos() => contadorDeObjetos;

        private int x, y;

        private static int contadorDeObjetos = 0;

    }
}
