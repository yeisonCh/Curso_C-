using System;

namespace ejemploPoo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;//creación objeto de tipo circulo. Variable/objeto de tipo circulo
            //inicialización de variable de tipo objeto
            miCirculo = new Circulo();//intaciar una clase 

            Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo otroCirculo = new Circulo();

            Console.WriteLine(otroCirculo.CalculoArea(2));

            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambioValorEuro(1.45);

            Console.WriteLine(obj.Convierte(50));
        }
    }
    class Circulo //hemos creado un objeto Ciudulo
    {
        //con el uso de la palabra private encapsulamos las propiedades o los metodos
        private const double pi = 3.1416;// Propiedad o campo de clase Circulo
        // con la palabra reservada const hacemos que una variable deje de ser variable y se vuelva constatnte

        //crearemos un metodo al cual lo llamamos CalculoArea ó que puede hacer un Objeto
        public double CalculoArea(int radio)
        {
            return pi * (radio * radio);
        }

    }

    class ConversorEuroDolar
    {
        //encapsulamos la variable euro
        private double euro = 1.253;

        public double Convierte (double cantidad)
        {
            return cantidad * euro;
        }

        //metodo de acceso
        public void CambioValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;
            
            else euro = nuevoValor;
        }
    }
}
