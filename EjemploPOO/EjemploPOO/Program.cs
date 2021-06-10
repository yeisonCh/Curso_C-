using System;

namespace EjemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;//creación objeto de tipo circulo. Variable/objeto de tipo circulo
            //inicialización de variable de tipo objeto
            miCirculo = new Circulo();//intaciar una clase 

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo otroCirculo = new Circulo();

            Console.WriteLine(otroCirculo.calculoArea(2));
        }
    }
    class Circulo //hemos creado un objeto Ciudulo
    {
        const double pi = 3.1416;// Propiedad o campo de clase Circulo
        // con la palabra reservada const hacemos que una variable deje de ser variable y se vuelva constatnte

        //crearemos un metodo al cual lo llamamos CalculoArea ó que puede hacer un Objeto
        public double calculoArea(int radio)
        {
            return pi * (radio * radio);
        }

    }
}
